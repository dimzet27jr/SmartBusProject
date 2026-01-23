using System.Windows.Forms;

namespace SmartBusProject
{
    partial class CafeForm
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
            btnExit = new Button();
            CafeLabel = new Label();
            CafeFlowLayout = new FlowLayoutPanel();
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
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.exitIcon;
            btnExit.Location = new Point(928, 511);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 64);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // CafeLabel
            // 
            CafeLabel.BackColor = Color.Transparent;
            CafeLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            CafeLabel.ForeColor = Color.White;
            CafeLabel.Location = new Point(139, 19);
            CafeLabel.Name = "CafeLabel";
            CafeLabel.Size = new Size(720, 70);
            CafeLabel.TabIndex = 0;
            CafeLabel.Text = "Διαθέσιμες Καφετέριες";
            CafeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CafeFlowLayout
            // 
            CafeFlowLayout.AutoScroll = true;
            CafeFlowLayout.BackColor = Color.Transparent;
            CafeFlowLayout.FlowDirection = FlowDirection.TopDown;
            CafeFlowLayout.Location = new Point(139, 119);
            CafeFlowLayout.Name = "CafeFlowLayout";
            CafeFlowLayout.Size = new Size(720, 365);
            CafeFlowLayout.TabIndex = 6;
            CafeFlowLayout.WrapContents = false;
            // 
            // CafeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.cafebackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(CafeFlowLayout);
            Controls.Add(CafeLabel);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "CafeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Διαθέσιμες Καφετέριες";
            FormClosing += CafeForm_FormClosing;
            ResumeLayout(false);
        }

        private Panel CreateCafePanel(Cafes cafe)
        {
            var cardPanel = new Panel();
            cardPanel.Width = 680;
            cardPanel.Height = 85;
            cardPanel.Margin = new Padding(0, 0, 0, 16);
            cardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);

            var cafeName = new Label();
            cafeName.Text = cafe.getName();
            cafeName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            cafeName.Location = new System.Drawing.Point(8, 8);
            cafeName.AutoSize = true;
            cafeName.BackColor = Color.Transparent;
            cafeName.ForeColor = Color.FromArgb(30, 30, 30);

            cardPanel.Controls.Add(cafeName);

            var lblAddress = new Label();
            lblAddress.Text = cafe.getAddress();
            lblAddress.AutoSize = false;
            lblAddress.Size = new Size(240, 18);
            lblAddress.Location = new System.Drawing.Point(8, 41);
            lblAddress.BackColor = Color.Transparent;
            lblAddress.ForeColor = Color.FromArgb(80, 80, 80);

            cardPanel.Controls.Add(lblAddress);

            var minutes = new Label();
            minutes.Text = $"Χρόνος προετοιμασίας: {cafe.getMinutes()}'";
            minutes.Font = new Font("Segoe UI", 10);
            minutes.Location = new System.Drawing.Point(8, 60);
            minutes.AutoSize = true;
            minutes.BackColor = Color.Transparent;
            minutes.ForeColor = Color.FromArgb(80, 80, 80);

            cardPanel.Controls.Add(minutes);

            var btnMenu = new Button();
            btnMenu.Text = "Άνοιγμα μενού";
            btnMenu.Size = new Size(140, 36);
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.BackColor = Color.FromArgb(212, 163, 115);

            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.Location = new Point(cardPanel.Width - btnMenu.Width - 14, (cardPanel.Height - btnMenu.Height) / 2);

            btnMenu.Click += (s, e) =>
            {
                this.Hide();
                var menu = new MenuForm();
                menu.FormClosed += (ms, me) => this.Show();
                menu.Show();
            };
            cardPanel.Controls.Add(btnMenu);


            return cardPanel;
        }

        #endregion

        private Button btnBack;
        private Button btnExit;
        private Label CafeLabel;
        private FlowLayoutPanel CafeFlowLayout;
    }
}