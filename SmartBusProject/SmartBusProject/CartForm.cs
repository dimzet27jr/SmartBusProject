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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            PopulateCart();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm().Show();
        }

        private void MasterCardButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MasterCardForm().Show();
        }

        private void PayPalButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new PayPalForm().Show();
        }

        private void PopulateCart()
        {
            CartProductsLayout.Controls.Clear();

            if (Program.cartProducts.Count == 0)
            {
                CartProductsLayout.Controls.Add(CreateEmptyCartPanel());
                TotalPriceLabel.Text = "Σύνολο: 0.00 €";
                return;
            }

            foreach (var product in Program.cartProducts)
            {
                var cartpanel = CreateCartItemPanel(product);
                CartProductsLayout.Controls.Add(cartpanel);
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = Program.cartProducts.Sum(product => product.TotalPrice);
            TotalPriceLabel.Text = $"Σύνολο: {total:0.00} €";
        }

        private void EmptyCart_Click(object sender, EventArgs e)
        {
            if (Program.cartProducts.Count == 0)
            {
                MessageBox.Show("Το καλάθι σας είναι άδειο.", "Δεν μπορείτε να το αδειάσετε.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.cartProducts.Clear();
                this.Hide();
                new CartForm().Show();
            }
        }

        private void CartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }
    }
}
