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
    public partial class CafeForm : Form
    {
        public CafeForm()
        {
            InitializeComponent();
            Cafes_Load();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new PassengersMainForm().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cafes_Load()
        {

            foreach (SmartBusProject.Cafes cafe in Program.cafes)
            {
                var cardPanel = CreateCafePanel(cafe);
                CafeFlowLayout.Controls.Add(cardPanel);
            }
        }
    }
}
