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
    public partial class PassengerDriverViewForm : Form
    {
        public PassengerDriverViewForm()
        {
            InitializeComponent();
            PassengerDriverViewForm_Load();
        }

        private void PassengerDriverViewForm_Load()
        {
            string videoPath = System.IO.Path.Combine(Application.StartupPath, "Assets", "Videos", "driver_view.mp4");
            driverViewVideo.URL = videoPath;
            driverViewVideo.uiMode = "none";               
            driverViewVideo.stretchToFit = true;           
            driverViewVideo.settings.autoStart = true;     
            driverViewVideo.settings.setMode("loop", true);

        }

        private void DriverView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                driverViewVideo.Ctlcontrols.stop();
            }
            catch { }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                PassengersMainForm passengerMain = new PassengersMainForm();
                passengerMain.Show();
            }
        }
    }
}
