using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using 

namespace SmartBusProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            PopulateProducts();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CartForm().Show();
        }

        private void PopulateProducts()
        {
            ProductFlowPanel.Controls.Clear();

            if (Program.product.Count == 0)
            {
                ProductFlowPanel.Controls.Add(CreateEmptyProductPanel());
                return;
            }

            foreach (SmartBusProject.Product p in Program.product)
            {
                var productPanel = CreateProductPanel(p);
                ProductFlowPanel.Controls.Add(productPanel);
            }

            ResizeProductPanels();
        }

        private void ResizeProductPanels()
        {
            foreach (Control c in ProductFlowPanel.Controls)
            {
                if (c is Panel p)
                {
                    p.Width = Math.Max(360, ProductFlowPanel.ClientSize.Width - 20);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CafeForm().Show();
        }
    }
}
