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
            //new HelpForm().Show();
            //this.Hide();
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
    }
}
