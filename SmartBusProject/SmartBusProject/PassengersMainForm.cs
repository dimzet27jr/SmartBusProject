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
    public partial class PassengersMainForm : Form
    {
        public PassengersMainForm()
        {
            InitializeComponent();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            new CafeForm().Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenHelp(@"HelpFiles\pages\passenger.html");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWanders_Click(object sender, EventArgs e)
        {
            new PassengerWandersForm().Show();
            this.Hide();
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            NavigationForm navigationForm = new NavigationForm(this);
            this.Hide();
            navigationForm.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new PassengerDriverViewForm().Show();
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

        private void PassengerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
