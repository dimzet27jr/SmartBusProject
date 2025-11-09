using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SmartBusProject
{
    partial class CartForm
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
            CartLabel = new Label();
            CartProductsLayout = new FlowLayoutPanel();
            MasterCardButton = new Button();
            PayPalButton = new Button();
            PayLabel = new Label();
            TotalPriceLabel = new Label();
            EmptyCart = new Button();
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
            // CartLabel
            // 
            CartLabel.BackColor = Color.Transparent;
            CartLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            CartLabel.ForeColor = Color.White;
            CartLabel.Location = new Point(139, 19);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(720, 70);
            CartLabel.TabIndex = 0;
            CartLabel.Text = "Καλάθι";
            CartLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartProductsLayout
            // 
            CartProductsLayout.AutoScroll = true;
            CartProductsLayout.BackColor = Color.Transparent;
            CartProductsLayout.FlowDirection = FlowDirection.TopDown;
            CartProductsLayout.Location = new Point(139, 119);
            CartProductsLayout.Name = "CartProductsLayout";
            CartProductsLayout.Size = new Size(720, 365);
            CartProductsLayout.TabIndex = 6;
            CartProductsLayout.WrapContents = false;
            // 
            // MasterCardButton
            // 
            MasterCardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MasterCardButton.BackColor = Color.Transparent;
            MasterCardButton.BackgroundImage = Properties.Resources.Mastercard;
            MasterCardButton.BackgroundImageLayout = ImageLayout.Zoom;
            MasterCardButton.Cursor = Cursors.Hand;
            MasterCardButton.FlatAppearance.BorderSize = 0;
            MasterCardButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            MasterCardButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            MasterCardButton.FlatStyle = FlatStyle.Flat;
            MasterCardButton.Location = new Point(811, 522);
            MasterCardButton.Name = "MasterCardButton";
            MasterCardButton.Size = new Size(64, 53);
            MasterCardButton.TabIndex = 5;
            MasterCardButton.UseVisualStyleBackColor = false;
            MasterCardButton.Click += MasterCardButton_Click;
            // 
            // PayPalButton
            // 
            PayPalButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PayPalButton.BackColor = Color.Transparent;
            PayPalButton.BackgroundImage = Properties.Resources.Paypal;
            PayPalButton.BackgroundImageLayout = ImageLayout.Stretch;
            PayPalButton.Cursor = Cursors.Hand;
            PayPalButton.FlatAppearance.BorderSize = 0;
            PayPalButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            PayPalButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            PayPalButton.FlatStyle = FlatStyle.Flat;
            PayPalButton.Location = new Point(881, 528);
            PayPalButton.Name = "PayPalButton";
            PayPalButton.Size = new Size(101, 40);
            PayPalButton.TabIndex = 5;
            PayPalButton.UseVisualStyleBackColor = false;
            PayPalButton.Click += PayPalButton_Click;
            // 
            // PayLabel
            // 
            PayLabel.BackColor = Color.Transparent;
            PayLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            PayLabel.ForeColor = Color.White;
            PayLabel.Location = new Point(610, 524);
            PayLabel.Name = "PayLabel";
            PayLabel.Size = new Size(195, 44);
            PayLabel.TabIndex = 0;
            PayLabel.Text = "Πληρωμή με:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.BackColor = Color.Transparent;
            TotalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TotalPriceLabel.ForeColor = Color.White;
            TotalPriceLabel.Location = new Point(438, 528);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(112, 28);
            TotalPriceLabel.TabIndex = 7;
            TotalPriceLabel.Text = "Total Price";
            // 
            // EmptyCart
            // 
            EmptyCart.BackColor = Color.FromArgb(25, 118, 210);
            EmptyCart.Cursor = Cursors.Hand;
            EmptyCart.FlatAppearance.BorderSize = 0;
            EmptyCart.FlatStyle = FlatStyle.Flat;
            EmptyCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmptyCart.ForeColor = Color.White;
            EmptyCart.Location = new Point(125, 531);
            EmptyCart.Name = "EmptyCart";
            EmptyCart.Size = new Size(244, 34);
            EmptyCart.TabIndex = 8;
            EmptyCart.Text = "Άδειασμα Καλαθιού";
            EmptyCart.UseVisualStyleBackColor = true;
            EmptyCart.Click += EmptyCart_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(EmptyCart);
            Controls.Add(TotalPriceLabel);
            Controls.Add(PayLabel);
            Controls.Add(PayPalButton);
            Controls.Add(MasterCardButton);
            Controls.Add(CartProductsLayout);
            Controls.Add(CartLabel);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel CreateCartItemPanel(CartItem product)
        {
            var cartProductpanel = new Panel();
            cartProductpanel.Height = 85;
            cartProductpanel.Width = 680;
            cartProductpanel.BorderStyle = BorderStyle.FixedSingle;
            cartProductpanel.Margin = new Padding(6);
            cartProductpanel.BackColor = Color.FromArgb(150, 255, 255, 255);

            var cartProductName = new Label();
            cartProductName.Text = product.Product.getName();
            cartProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cartProductName.AutoSize = false;
            cartProductName.Location = new Point(10, 8);
            cartProductName.Size = Size = new Size(cartProductpanel.Width - 220, 22);
            cartProductName.BackColor = Color.Transparent;

            var cartProductPrice = new Label();
            cartProductPrice.Text = $"{Convert.ToDecimal(product.Product.getPrice()):0.00} €";
            cartProductPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            cartProductPrice.AutoSize = false;
            cartProductPrice.Location = new Point(10, 36);
            cartProductPrice.Size = new Size(100, 18);
            cartProductPrice.BackColor = Color.Transparent;

            var cartProductQuantity = new Label();
            cartProductQuantity.Text = $"Ποσότητα: {product.Quantity}";
            cartProductQuantity.TextAlign = ContentAlignment.MiddleRight;
            cartProductQuantity.AutoSize = false;
            cartProductQuantity.Location = new Point(cartProductpanel.Width - 200, 10);
            cartProductQuantity.Size = new Size(120, 20);
            cartProductQuantity.BackColor = Color.Transparent;

            var cartProductTotalPrice = new Label();
            cartProductTotalPrice.Text = $"Σύνολο: {product.TotalPrice:0.00} €";
            cartProductTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            cartProductTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cartProductTotalPrice.AutoSize = false;
            cartProductTotalPrice.Location = new Point(cartProductpanel.Width - 200, 36);
            cartProductTotalPrice.Size = new Size(160, 20);
            cartProductTotalPrice.BackColor = Color.Transparent;

            var btnRemove = new Button();
            btnRemove.Text = "Αφαίρεση";
            btnRemove.Size = new Size(100, 28);
            btnRemove.Location = new Point(cartProductpanel.Width - 100, 24);
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.ForeColor = Color.White;
            btnRemove.BackColor = Color.FromArgb(25, 118, 210);
           
            btnRemove.Click += (s, e) =>
            {
                Program.cartProducts.Remove(product);
                PopulateCart();
            };

            cartProductpanel.Controls.Add(cartProductName);
            cartProductpanel.Controls.Add(cartProductPrice);
            cartProductpanel.Controls.Add(cartProductQuantity);
            cartProductpanel.Controls.Add(cartProductTotalPrice);
            cartProductpanel.Controls.Add(btnRemove);

            int rightMargin = 10;
            int spacing = 8;

            cartProductpanel.SizeChanged += (s, e) =>
            { 
                btnRemove.Location = new Point(cartProductpanel.ClientSize.Width - btnRemove.Width - rightMargin,(cartProductpanel.Height - btnRemove.Height) / 2);
                cartProductTotalPrice.Location = new Point(btnRemove.Location.X - spacing - cartProductTotalPrice.Width, (cartProductpanel.Height - cartProductTotalPrice.Height) / 2);
                cartProductQuantity.Location = new Point(cartProductTotalPrice.Location.X - spacing - cartProductQuantity.Width, (cartProductpanel.Height - cartProductQuantity.Height) / 2);
            };

            return cartProductpanel;
        }

        private Panel CreateEmptyCartPanel()
        {
            var cartEmptypanel = new Panel();
            cartEmptypanel.Height = 85;
            cartEmptypanel.Width = 680;
            cartEmptypanel.BorderStyle = BorderStyle.FixedSingle;
            cartEmptypanel.Margin = new Padding(6);
            cartEmptypanel.BackColor = Color.FromArgb(150, 255, 255, 255);

            var cartEmptyLabel = new Label();
            cartEmptyLabel.Text = "Το καλάθι σας είναι άδειο";
            cartEmptyLabel.TextAlign = ContentAlignment.MiddleCenter;
            cartEmptyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cartEmptyLabel.AutoSize = false;
            cartEmptyLabel.Dock = DockStyle.Fill;
            cartEmptyLabel.BackColor = Color.Transparent;
            cartEmptyLabel.ForeColor = Color.Black;

            cartEmptypanel.Controls.Add(cartEmptyLabel); 

            return cartEmptypanel;
        }

        #endregion

        private Button btnBack;
        private Label CartLabel;
        private FlowLayoutPanel CartProductsLayout;
        private Button MasterCardButton;
        private Button PayPalButton;
        private Label PayLabel;
        private Label TotalPriceLabel;
        private Button EmptyCart;
    }
}