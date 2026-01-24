using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBusProject
{
    public partial class DriverMainForm : Form
    {
        public DriverMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenHelp(@"HelpFiles\pages\driver.html");
        }

        private void btnVacuum_Click(object sender, EventArgs e)
        {
            new VacuumForm().Show();
            this.Hide();
        }

        private void btnAircondition_Click(object sender, EventArgs e)
        {
            new AirCondtionControl().Show();
            this.Hide();
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            new EnergyForm().Show();
            this.Hide();
        }

        private void btnDriverHelp_Click(object sender, EventArgs e)
        {
            new DriverAssistanceForm().Show();
            this.Hide();
        }

        private void OpenHelp(string relativePath)
        {
            string fullPath = Path.Combine(Application.StartupPath, relativePath);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("Το αρχείο δεν βρέθηκε:\n" + fullPath);
                return;
            }

            var psi = new ProcessStartInfo
            {
                FileName = fullPath,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void DriverMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
