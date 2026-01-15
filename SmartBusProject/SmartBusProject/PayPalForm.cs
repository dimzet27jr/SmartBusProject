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
    public partial class PayPalForm : Form
    {
        public PayPalForm()
        {
            InitializeComponent();
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (ShowPassword.Tag == "unchecked")
            {
                PayPalPassword.UseSystemPasswordChar = false;
                ShowPassword.BackgroundImage = Properties.Resources.ShowPass2;
                ShowPassword.Tag = "checked";
            }
            else
            {
                PayPalPassword.UseSystemPasswordChar = true;
                ShowPassword.BackgroundImage = Properties.Resources.ShowPass;
                ShowPassword.Tag = "unchecked";
            }
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            if (PayPalEmail.Text != "" && PayPalPassword.Text != "")
            {
                if (Program.cartProducts == null || Program.cartProducts.Count == 0)
                {
                    MessageBox.Show("Το καλάθι είναι άδειο. Πρόσθεσε προϊόντα πριν την ολοκλήρωση.", "Άδειο καλάθι",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    new MenuForm().Show();
                    return;
                }

                var order = new StringBuilder();
                order.AppendLine("Ευχαριστούμε για την παραγγελία!");
                order.AppendLine();
                order.AppendLine("Αγορές:");
                decimal total = 0m;

                foreach (var product in Program.cartProducts)
                {
                    decimal productPrice = Convert.ToDecimal(product.Product.getPrice());
                    decimal totalPrice = product.TotalPrice;
                    total += totalPrice;
                    order.AppendLine($"{product.Product.getName()} × {product.Quantity} = {totalPrice:0.00} €  ({productPrice:0.00} €/τεμ)");
                }

                order.AppendLine();
                order.AppendLine($"Συνολικό πληρωτέο ποσό: {total:0.00} €");

                Program.cartProducts.Clear();
                MessageBox.Show(order.ToString(), "Παραγγελία ολοκληρώθηκε", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                new CafeForm().Show();
            }
            else
            {
                MessageBox.Show("Συμπλήρωσε όλα τα πεδία της κάρτας πριν συνεχίσεις.", "Ελλιπείς πληροφορίες",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
