using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBusProject
{
    public partial class AirCondtionControl : Form
    {
        private int inTemp;
        private int busTemp;
        private int passengerNumb;

        private bool autoMode = false;
        private bool heatmode = false;
        private bool coolmode = true;

        private System.Windows.Forms.Timer tempTimer;
        private int fanSpeed = 0;

        private Random random = new Random();
        public AirCondtionControl()
        {
            InitializeComponent();
            RandomValues();
            UpdateValues();

            tempTimer = new System.Windows.Forms.Timer();
            tempTimer.Interval = 1000;
            tempTimer.Tick += TempTimer_Tick;

            fanSpeed = 0;
            pbxFan.BackgroundImage = Properties.Resources.fan_low;
        }

        private void RandomValues()
        {
            inTemp = random.Next(16, 32);
            busTemp = random.Next(-5, 40);
            passengerNumb = random.Next(5, 60);

        }

        private void UpdateValues()
        {
            inTempLabel.Text = $"{inTemp}°C";
            outTempLabel.Text = $"Θερμοκρασία Λεωφορείου: {busTemp}°C";
            passengersLabel.Text = $"Αριθμός επιβατών: {passengerNumb}";
        }


        private void pbxAddTemp_Click(object sender, EventArgs e)
        {
            if (autoMode) return;

            if (inTemp >= 32)
            {
                MessageBox.Show("Η μέγιστη επιτρεπτή θερμοκρασία είναι 32°C.", "Όριο Θερμοκρασίας", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            inTemp++;
            UpdateValues();
        }

        private void pbxLowerTemp_Click(object sender, EventArgs e)
        {
            if (autoMode) return;

            if (inTemp <= 16)
            {
                MessageBox.Show("Η ελάχιστη επιτρεπτή θερμοκρασία είναι 16°C.", "Όριο Θερμοκρασίας", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            inTemp--;
            UpdateValues();
        }

        private void pbxAuto_Click(object sender, EventArgs e)
        {
            autoMode = !autoMode;

            if (autoMode)
            {
                pbxAuto.BackgroundImage = Properties.Resources.auto;
                ApplyAutoLogic();
                if (!autoMode) return;
                MessageBox.Show("Ενεργοποιήθηκε η αυτόματη ρύθμιση θερμοκρασίας.", "Auto Mode ON", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                pbxAuto.BackgroundImage = Properties.Resources.auto_off;
                MessageBox.Show("Η αυτόματη ρύθμιση απενεργοποιήθηκε.\nΜπορείτε να ρυθμίσετε χειροκίνητα τη θερμοκρασία.", "Auto Mode OFF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ApplyAutoLogic()
        {
            if (busTemp < inTemp)
            {
                heatmode = true;
                coolmode = false;

                pbxHeatMode.BackgroundImage = Properties.Resources.heat_mode_on;
                pbxCoolMode.BackgroundImage = Properties.Resources.cool_mode_off;
            }
            else if (busTemp > inTemp)
            {
                coolmode = true;
                heatmode = false;

                pbxCoolMode.BackgroundImage = Properties.Resources.cool_mode_on;
                pbxHeatMode.BackgroundImage = Properties.Resources.heat_mode_off;
            }
            else
            {
                MessageBox.Show("Δεν απαιτείται λειτουργία κλιματισμού.");
                autoMode = false;
                pbxAuto.BackgroundImage = Properties.Resources.auto_off;
                return;
            }

            ApplyFanLogic();
            tempTimer.Start();
        }
        private void SetFanFast()
        {
            fanSpeed = 1;
            tempTimer.Interval = 500;
            pbxFan.BackgroundImage = Properties.Resources.fan_fast;
        }

        private void SetFanLow()
        {
            fanSpeed = 0;
            tempTimer.Interval = 1500;
            pbxFan.BackgroundImage = Properties.Resources.fan_low;
        }

        private void ApplyFanLogic()
        {
            if (heatmode && busTemp <= 18)
                SetFanFast();
            else if (coolmode && busTemp >= 30)
                SetFanFast();
            else
                SetFanLow();
        }

        private void pbxHeatMode_Click(object sender, EventArgs e)
        {
            if (autoMode) return;

            heatmode = true;
            coolmode = false;

            pbxHeatMode.BackgroundImage = Properties.Resources.heat_mode_on;
            pbxCoolMode.BackgroundImage = Properties.Resources.cool_mode_off;

            tempTimer.Start();
        }

        private void pbxCoolMode_Click(object sender, EventArgs e)
        {
            if (autoMode) return;

            coolmode = true;
            heatmode = false;

            pbxCoolMode.BackgroundImage = Properties.Resources.cool_mode_on;
            pbxHeatMode.BackgroundImage = Properties.Resources.heat_mode_off;

            tempTimer.Start();
        }

        private void TempTimer_Tick(object sender, EventArgs e)
        {
            if (busTemp == inTemp)
            {
                //tempTimer.Stop();
                return;
            }

            if (heatmode && busTemp < inTemp)
                busTemp++;
            else if (coolmode && busTemp > inTemp)
                busTemp--;

            if(autoMode)ApplyFanLogic();
            UpdateValues();
        }

        private void pbxFan_Click(object sender, EventArgs e)
        {
            fanSpeed = fanSpeed == 0 ? 1 : 0;
            pbxFan.BackgroundImage = fanSpeed == 0 ? Properties.Resources.fan_low : Properties.Resources.fan_fast;
            MessageBox.Show(fanSpeed == 0 ? "Ανεμιστήρας: Χαμηλή ταχύτητα" : "Ανεμιστήρας: Υψηλή ταχύτητα", "Fan Speed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (fanSpeed == 0) 
                SetFanLow();
            else
                SetFanFast();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new AirConditionInfo().Show();
        }

        private void AirCondtionControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DriverMainForm driverMain = new DriverMainForm();
                driverMain.Show();
            }
        }
    }
}
