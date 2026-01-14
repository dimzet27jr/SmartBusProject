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
    public partial class PassengerWandersForm : Form
    {
        public PassengerWandersForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PassengersMainForm().Show();
        }

        private void pbxAcropoli_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Acropoli, Program.Acropoli_Desc, Properties.Resources.ancient_acropoli, Properties.Resources.acropoli_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void pbxTheseio_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Theseio, Program.Theseio_Desc, Properties.Resources.theseio, Properties.Resources.theseio_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void pbxEthnikoMouseio_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Ethniko_Mouseio, Program.Ethniko_Mouseio_Desc, Properties.Resources.pnika, Properties.Resources.pnika_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void pbxHrodio_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Hrodio, Program.Hrodio_Desc, Properties.Resources.hrodio, Properties.Resources.hrodio_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
