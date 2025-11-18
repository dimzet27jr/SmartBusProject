using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartBusProject
{
    partial class PassengersMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnCafe;
        private Button btnVacuum;
        private Button btnHelp;
        private Button btnExit;
        private Label lblTitle;

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
            lblTitle = new Label();
            btnCafe = new Button();
            btnVacuum = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(146, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(720, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Κύριες Λειτουργίες Επιβάτη";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCafe
            // 
            btnCafe.BackColor = Color.FromArgb(25, 118, 210);
            btnCafe.Cursor = Cursors.Hand;
            btnCafe.FlatAppearance.BorderSize = 0;
            btnCafe.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnCafe.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnCafe.FlatStyle = FlatStyle.Flat;
            btnCafe.Font = new Font("Segoe UI", 12F);
            btnCafe.ForeColor = Color.White;
            btnCafe.Location = new Point(146, 171);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(300, 90);
            btnCafe.TabIndex = 2;
            btnCafe.Text = "☕ Είσοδος Καφετέριας";
            btnCafe.UseVisualStyleBackColor = false;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnVacuum
            // 
            btnVacuum.BackColor = Color.FromArgb(25, 118, 210);
            btnVacuum.Cursor = Cursors.Hand;
            btnVacuum.FlatAppearance.BorderSize = 0;
            btnVacuum.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnVacuum.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnVacuum.FlatStyle = FlatStyle.Flat;
            btnVacuum.Font = new Font("Segoe UI", 12F);
            btnVacuum.ForeColor = Color.White;
            btnVacuum.Location = new Point(566, 171);
            btnVacuum.Name = "btnVacuum";
            btnVacuum.Size = new Size(300, 90);
            btnVacuum.TabIndex = 3;
            btnVacuum.Text = "\U0001f9f9 Έλεγχος Σκούπας (Οδηγός)";
            btnVacuum.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHelp.BackColor = Color.Transparent;
            btnHelp.BackgroundImageLayout = ImageLayout.Zoom;
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Image = Properties.Resources.helpIcon;
            btnHelp.Location = new Point(1, 511);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(64, 64);
            btnHelp.TabIndex = 4;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
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
            // PassengersMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(lblTitle);
            Controls.Add(btnCafe);
            Controls.Add(btnVacuum);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "PassengersMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passenger Main Menu";
            ResumeLayout(false);
        }

        #endregion
    }
}