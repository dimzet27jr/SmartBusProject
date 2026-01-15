using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace SmartBusProject
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            PayButton = new Button();
            MenuLabel = new Label();
            ProductFlowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.arrowback;
            btnBack.Location = new Point(2, 513);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(64, 64);
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PayButton
            // 
            PayButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PayButton.BackColor = Color.Transparent;
            PayButton.BackgroundImageLayout = ImageLayout.Zoom;
            PayButton.Cursor = Cursors.Hand;
            PayButton.FlatAppearance.BorderSize = 0;
            PayButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            PayButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            PayButton.FlatStyle = FlatStyle.Flat;
            PayButton.Image = Properties.Resources.cartIcon;
            PayButton.Location = new Point(928, 511);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(64, 64);
            PayButton.TabIndex = 5;
            PayButton.UseVisualStyleBackColor = false;
            PayButton.Click += PayButton_Click;
            // 
            // MenuLabel
            // 
            MenuLabel.BackColor = Color.Transparent;
            MenuLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            MenuLabel.ForeColor = Color.White;
            MenuLabel.Location = new Point(139, 19);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(720, 70);
            MenuLabel.TabIndex = 0;
            MenuLabel.Text = "Μενού";
            MenuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductFlowPanel
            // 
            ProductFlowPanel.AutoScroll = true;
            ProductFlowPanel.BackColor = Color.Transparent;
            ProductFlowPanel.FlowDirection = FlowDirection.TopDown;
            ProductFlowPanel.Location = new Point(139, 119);
            ProductFlowPanel.Name = "ProductFlowPanel";
            ProductFlowPanel.Size = new Size(720, 365);
            ProductFlowPanel.TabIndex = 6;
            ProductFlowPanel.WrapContents = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.cafebackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(ProductFlowPanel);
            Controls.Add(MenuLabel);
            Controls.Add(PayButton);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            ResumeLayout(false);
        }

        private Panel CreateProductPanel(Product p)
        {
            var productpanel = new Panel();
            productpanel.Height = 85;
            productpanel.Width = 680;
            productpanel.BorderStyle = BorderStyle.FixedSingle;
            productpanel.Margin = new Padding(6);
            productpanel.BackColor = Color.FromArgb(150, 255, 255, 255);

            var productName = new Label();
            productName.Text = $"{p.getName()}";
            productName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            productName.AutoSize = false;
            productName.Location = new Point(10, 8);
            productName.Size = new Size(productpanel.Width - 150, 22);
            productName.BackColor = Color.Transparent;

            var productPrice = new Label();
            productPrice.Text = $"{$"{p.getPrice()}":0.00} €";
            productPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            productPrice.AutoSize = false;
            productPrice.Location = new Point(10, 34);
            productPrice.Size = new Size(120, 18);
            productPrice.BackColor = Color.Transparent;

            var totalPrice = new Label();
            totalPrice.Text = $"Σύνολο: {Convert.ToDecimal(p.getPrice()):0.00} €";
            totalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            totalPrice.AutoSize = false;
            totalPrice.Size = new Size(160, 18);
            totalPrice.Location = new Point(140, 34);
            totalPrice.BackColor = Color.Transparent;

            var btnMinus = new Button();
            btnMinus.Text = "-";
            btnMinus.Size = new Size(28, 28);
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMinus.BackColor = Color.FromArgb(212, 163, 115); /*FromArgb(25, 118, 210)*/
            btnMinus.ForeColor = Color.White;
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            var quantity = new TextBox();
            quantity.Text = "1";
            quantity.Size = new Size(46, 28);
            quantity.TextAlign = HorizontalAlignment.Center;
            quantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            quantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            var btnPlus = new Button();
            btnPlus.Text = "+";
            btnPlus.Size = new Size(28, 28);
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.Cursor = Cursors.Hand;
            btnPlus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPlus.BackColor = Color.FromArgb(212, 163, 115);
            btnPlus.ForeColor = Color.White;
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            var btnAdd = new Button();
            btnAdd.Text = "Προσθήκη";
            btnAdd.Size = new Size(100, 28);
            btnAdd.Location = new Point(productpanel.Width - 110, 22);
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.BackColor = Color.FromArgb(212, 163, 115);

            btnAdd.FlatAppearance.BorderSize = 0;

            Action normalizeQty = () =>
            {
                if (!int.TryParse(quantity.Text, out int q) || q < 1)
                {
                    quantity.Text = "1";
                    q = 1;
                }
                decimal unit = Convert.ToDecimal(p.getPrice());
                decimal subtotal = unit * q;
                totalPrice.Text = $"Σύνολο: {subtotal:0.00} €";

                btnMinus.Enabled = q > 1;
            };

            btnPlus.Click += (s, e) =>
            {
                if (!int.TryParse(quantity.Text, out int q)) q = 1;
                q++;
                quantity.Text = q.ToString();
                normalizeQty();
            };

            btnMinus.Click += (s, e) =>
            {
                if (!int.TryParse(quantity.Text, out int q)) q = 1;
                q = Math.Max(1, q - 1);
                quantity.Text = q.ToString();
                normalizeQty();
            };

            quantity.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            quantity.Leave += (s, e) => normalizeQty();

            btnAdd.Click += (s, e) =>
            {
                if (!int.TryParse(quantity.Text, out int q) || q < 1) q = 1;

                var existing = Program.cartProducts.FirstOrDefault(ci => ci.Product.getName() == p.getName());
                if (existing != null)
                {
                    existing.Quantity += q;
                }
                else
                {
                    Program.cartProducts.Add(new CartItem(p, q));
                }

                normalizeQty();

                MessageBox.Show($"Προστέθηκε στο καλάθι: {p.getName()}\nΠοσότητα: {q}\nΣύνολο για το προϊόν: {(Convert.ToDecimal(p.getPrice()) * q):0.00} €",
                    "Προσθήκη προϊόντος", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            productpanel.Controls.Add(productName);
            productpanel.Controls.Add(productPrice);
            productpanel.Controls.Add(btnMinus); 
            productpanel.Controls.Add(totalPrice);
            productpanel.Controls.Add(quantity);
            productpanel.Controls.Add(btnPlus);
            productpanel.Controls.Add(btnAdd);

            productpanel.SizeChanged += (s, e) =>
            {
                btnAdd.Location = new Point(productpanel.Width - btnAdd.Width - 10, btnAdd.Location.Y + 3);

                int spacing = 6;
                int xBtnAdd = btnAdd.Location.X;
                btnMinus.Location = new Point(xBtnAdd - spacing - btnMinus.Width, (productpanel.Height - btnMinus.Height) / 2);
                quantity.Location = new Point(btnMinus.Location.X - spacing - quantity.Width, (productpanel.Height - quantity.Height) / 2);
                btnPlus.Location = new Point(quantity.Location.X - spacing - btnPlus.Width, (productpanel.Height - btnPlus.Height) / 2);
            };

            return productpanel;
        }

        private Panel CreateEmptyProductPanel()
        {
            var Emptypanel = new Panel();
            Emptypanel.Height = 85;
            Emptypanel.Width = 680;
            Emptypanel.BorderStyle = BorderStyle.FixedSingle;
            Emptypanel.Margin = new Padding(6);
            Emptypanel.BackColor = Color.FromArgb(150, 255, 255, 255);

            var EmptyLabel = new Label();
            EmptyLabel.Text = "Δεν υπάρχει διαθέσιμο προϊόν";
            EmptyLabel.TextAlign = ContentAlignment.MiddleCenter;
            EmptyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmptyLabel.AutoSize = false;
            EmptyLabel.Dock = DockStyle.Fill;
            EmptyLabel.BackColor = Color.Transparent;
            EmptyLabel.ForeColor = Color.Black;

            Emptypanel.Controls.Add(EmptyLabel);

            return Emptypanel;
        }
        #endregion

        private Button btnBack;
        private Button PayButton;
        private Label MenuLabel;
        private FlowLayoutPanel ProductFlowPanel;
    }
}