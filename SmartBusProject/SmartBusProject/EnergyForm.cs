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
    public partial class EnergyForm : Form
    {
        private EnergySystem energySystem;
        private System.Windows.Forms.Timer energyTimer;

        private bool lowEnergyWarningShown = false;
        private bool criticalEnergyWarningShown = false;
        private bool emptyBatteryWarning = false;
        private bool panelWarningShown = false;
        public EnergyForm()
        {
            InitializeComponent();
            energySystem = new EnergySystem();

            energyTimer = new System.Windows.Forms.Timer();
            energyTimer.Interval = 1000;
            energyTimer.Tick += EnergyTimer_Tick;
            energyTimer.Start();

            UpdateLabels();
        }

        private void EnergyTimer_Tick(object sender, EventArgs e)
        {
            bool wasAcOpen = energySystem.AcOpen;

            energySystem.UpdateEnergy();

            if (wasAcOpen && !energySystem.AcOpen && energySystem.EnergyLevel/30 < 20)
            {
                energySystem.BusEngineConsumption = 8;
                energySystem.BusScreenConsumption = 12;
                MessageBox.Show("Η μπαταρία είναι κάτω από 20%.\n Το σύστημα μειώνει την κατανάλωση της μηχανής και των οθονών και κλείνει το AirCondition.", "Λειτουργία Εξοικονόμησης Ενέργειας", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (energySystem.EnergyLevel/30 < 20 && !lowEnergyWarningShown)
            {
                lowEnergyWarningShown = true;
                energySystem.BusEngineConsumption = 8;
                energySystem.BusScreenConsumption = 12;
                MessageBox.Show("Η μπαταρία είναι κάτω από 20%.\n Το σύστημα μειώνει την κατανάλωση της μηχανής και των οθονών.", "Λειτουργία Εξοικονόμησης Ενέργειας", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (energySystem.EnergyLevel/30 <= 10 && !criticalEnergyWarningShown)
            {
                criticalEnergyWarningShown = true;
                MessageBox.Show("Κρίσιμη στάθμη μπαταρίας!\n Το λεωφορείο χρειάζεται άμεση φόρτιση.", "Κρίσιμη Σταύθμη Μπαταρίας", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            if (energySystem.EnergyLevel == 0 && !emptyBatteryWarning)
            {
                emptyBatteryWarning = true;
                MessageBox.Show("H μπαταρία είναι άδεια!\n Το λεωφορείο χρειάζεται άμεση φόρτιση.", "Ξεφόρτιστο Λεωφορείο", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            BusBattery.Value = energySystem.EnergyLevel;
            ButtaryLabel.Text = $": {energySystem.EnergyLevel/30}%";

            PanelInfoLabel.Text = energySystem.OpenRoof ? "Panels: On" : "Panels: Off";
            pbxPanelControls.BackgroundImage = energySystem.OpenRoof ? Properties.Resources.panel_on : Properties.Resources.panel_off;
            AcInfoLabel.Text = energySystem.AcOpen ? "AC: On" : "AC: Off";
            pbxAirCondControl.BackgroundImage = energySystem.AcOpen ? Properties.Resources.ac_on : Properties.Resources.ac_off;
            EnergyFlowLabel.Text = $"Παραγωγή Ενέργειας: +{energySystem.SolarPanelProduction/10} KwH";
            EnergyOutLabel.Text = $"Κατανάλωση Ενέργειας: -{energySystem.TotalEnergyConsumption/10}KwH";

            if (energySystem.Weather == WeatherType.Sunny)
            {
                pbxWeather.BackgroundImage = Properties.Resources.sunny_weather;
                pbxPanelControls.Enabled = true;
            }
            else if (energySystem.Weather == WeatherType.Rainy)
            {
                pbxWeather.BackgroundImage= Properties.Resources.rainy_weather;
                if (!panelWarningShown)
                {
                    panelWarningShown = true;
                    MessageBox.Show("Τα φωτοβολταϊκά δεν μπορούν να ανοίξουν!\n Το λεωφορείο χρειάζεται άμεση φόρτιση.", "Ξεφόρτιστο Λεωφορείο", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
                pbxPanelControls.Enabled = false;
            }
        }

        private void EnergyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            energyTimer.Stop();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DriverMainForm driverMain = new DriverMainForm();
                driverMain.Show();
            }
        }

        private void pbxAirCondControl_Click(object sender, EventArgs e)
        {
            energySystem.AcOpen = !energySystem.AcOpen;
            
            UpdateLabels();
        }

        private void pbxPanelControls_Click(object sender, EventArgs e)
        {
            energySystem.OpenRoof = !energySystem.OpenRoof;
            UpdateLabels();
        }
    }
}
