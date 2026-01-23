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
    public partial class DriverAssistanceForm : Form
    {
        private DriverAssistanceSystem assistanceSystem;
        private System.Windows.Forms.Timer speedTimer;

        private bool ShowMessage = false;

        public DriverAssistanceForm()
        {
            InitializeComponent();

            assistanceSystem = new DriverAssistanceSystem();
            speedTimer = new System.Windows.Forms.Timer();

            speedTimer.Interval = 200;
            speedTimer.Tick += SpeedTimer_Tick;
            speedTimer.Start();

            speedLimitLabel.Text = $"{assistanceSystem.speedLimit}";
        }

        private void pbxAccelarate_MouseDown(object sender, MouseEventArgs e)
        {
            pbxAccelarator.BackgroundImageLayout = ImageLayout.Zoom;
            if (assistanceSystem.SpeedLocked)
            {
                MessageBox.Show("Υπέρβαση ορίου ταχύτητας! Το γκάζι κλείδωσε!\nΜειώστε ταχύτητα", "Βοήθεια στην Οδήγηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            assistanceSystem.Accelarating = true;
        }

        private void pbxAccelarate_MouseUp(object sender, MouseEventArgs e)
        {
            pbxAccelarator.BackgroundImageLayout = ImageLayout.Stretch;
            assistanceSystem.Accelarating = false;
        }

        private void pbxBrake_MouseDown(object sender, MouseEventArgs e)
        {
            pbxBrake.BackgroundImageLayout = ImageLayout.Zoom;
            assistanceSystem.Braking = true;
        }

        private void pbxBrake_MouseUp(object sender, MouseEventArgs e)
        {
            pbxBrake.BackgroundImageLayout = ImageLayout.Stretch;
            assistanceSystem.Braking = false;
        }

        private void pbxTurnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if(assistanceSystem.currentSpeed > 0)
            {
                pbxTurnLeft.BackgroundImageLayout = ImageLayout.Zoom;
                assistanceSystem.TurnLeft();
            }
            else
            {
                MessageBox.Show("Το λεωφορείο είναι σταματημένο. Ξεκινήστε πρώτα.", "Βοήθεια στην Οδήγηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pbxTurnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            pbxTurnLeft.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void pbxTurnRight_MouseDown(object sender, MouseEventArgs e)
        {
            if(assistanceSystem.currentSpeed > 0)
            {
                pbxTurnRight.BackgroundImageLayout = ImageLayout.Zoom;
                assistanceSystem.TurnRight();
            }
            else
            {
                MessageBox.Show("Το λεωφορείο είναι σταματημένο. Ξεκινήστε πρώτα.", "Βοήθεια στην Οδήγηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pbxTurnRight_MouseUp(object sender, MouseEventArgs e)
        {
            pbxTurnRight.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void SpeedTimer_Tick(object sender, EventArgs e)
        {
            assistanceSystem.UpdateSpeed();
            
            busSpeedLabel.Text = $"{assistanceSystem.currentSpeed} km/h";

            bool laneWarning = assistanceSystem.UpdateLanePosition();

            if (assistanceSystem.BusLanePosition < -5)
            {
                LanePosition.Text = $"Κοντά στην αριστερή λωρίδα";
            }
            else if (assistanceSystem.BusLanePosition > 5)
            {
                LanePosition.Text = $"Κοντά στην δεξιά λωρίδα";
            }

            if (assistanceSystem.BusLanePosition < -10)
            {
                LanePosition.Text = $"Στην αριστερή λωρίδα";
            }
            else if (assistanceSystem.BusLanePosition > 10)
            {
                LanePosition.Text = $"Στην δεξιά λωρίδα";
            }

            if(assistanceSystem.BusLanePosition == 0)
            {
                LanePosition.Text = $"Στο κέντρο της λωρίδας";
            }

            if (laneWarning)
            {
                MessageBox.Show("Προσοχή! Απόκλιση από την λωρίδα", "Βοήθεια στην Οδήγηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (assistanceSystem.UpdateTired())
            {
                MessageBox.Show("Δείχνετε κουρασμένος\nΜήπως να κάνετε μια στάση ή να πιείτε έναν καφέ.", "Βοήθεια στην Οδήγηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (assistanceSystem.SpeedLocked && !ShowMessage)
            {
                ShowMessage = true;
                MessageBox.Show("Υπέρβαση ορίου ταχύτητας για πάνω από 3 δευτερόλεπτα!\nΗ επιτάχυνση μπλοκαρίστηκε.", "Βοήθεια στην Οδήγηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!assistanceSystem.speedAlert)
            {
                ShowMessage = false;
            }
        }

        private void DriverAssistanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DriverMainForm driverMain = new DriverMainForm();
                driverMain.Show();
            }
        }
    }
}
