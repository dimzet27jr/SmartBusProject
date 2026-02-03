namespace SmartBusProject
{
    partial class DriverMainForm
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
            lblTitle = new Label();
            btnHelp = new Button();
            btnExit = new Button();
            btnVacuum = new Button();
            btnAircondition = new Button();
            btnEnergy = new Button();
            btnDriverHelp = new Button();
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
            lblTitle.Text = "Κύριες Λειτουργίες Οδηγού";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            btnVacuum.Location = new Point(146, 168);
            btnVacuum.Name = "btnVacuum";
            btnVacuum.Size = new Size(300, 90);
            btnVacuum.TabIndex = 3;
            btnVacuum.Text = "Έλεγχος Σκούπας";
            btnVacuum.UseVisualStyleBackColor = false;
            btnVacuum.Click += btnVacuum_Click;
            // 
            // btnAircondition
            // 
            btnAircondition.BackColor = Color.FromArgb(25, 118, 210);
            btnAircondition.Cursor = Cursors.Hand;
            btnAircondition.FlatAppearance.BorderSize = 0;
            btnAircondition.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnAircondition.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnAircondition.FlatStyle = FlatStyle.Flat;
            btnAircondition.Font = new Font("Segoe UI", 12F);
            btnAircondition.ForeColor = Color.White;
            btnAircondition.Location = new Point(557, 168);
            btnAircondition.Name = "btnAircondition";
            btnAircondition.Size = new Size(300, 90);
            btnAircondition.TabIndex = 6;
            btnAircondition.Text = "Ρύθμιση Θερμοκρασίας";
            btnAircondition.UseVisualStyleBackColor = false;
            btnAircondition.Click += btnAircondition_Click;
            // 
            // btnEnergy
            // 
            btnEnergy.BackColor = Color.FromArgb(25, 118, 210);
            btnEnergy.Cursor = Cursors.Hand;
            btnEnergy.FlatAppearance.BorderSize = 0;
            btnEnergy.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnEnergy.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnEnergy.FlatStyle = FlatStyle.Flat;
            btnEnergy.Font = new Font("Segoe UI", 12F);
            btnEnergy.ForeColor = Color.White;
            btnEnergy.Location = new Point(146, 314);
            btnEnergy.Name = "btnEnergy";
            btnEnergy.Size = new Size(300, 90);
            btnEnergy.TabIndex = 7;
            btnEnergy.Text = "Φωτοβολταϊκά";
            btnEnergy.UseVisualStyleBackColor = false;
            btnEnergy.Click += btnEnergy_Click;
            // 
            // btnDriverHelp
            // 
            btnDriverHelp.BackColor = Color.FromArgb(25, 118, 210);
            btnDriverHelp.Cursor = Cursors.Hand;
            btnDriverHelp.FlatAppearance.BorderSize = 0;
            btnDriverHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnDriverHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnDriverHelp.FlatStyle = FlatStyle.Flat;
            btnDriverHelp.Font = new Font("Segoe UI", 12F);
            btnDriverHelp.ForeColor = Color.White;
            btnDriverHelp.Location = new Point(557, 314);
            btnDriverHelp.Name = "btnDriverHelp";
            btnDriverHelp.Size = new Size(300, 90);
            btnDriverHelp.TabIndex = 8;
            btnDriverHelp.Text = "Βοήθεια στην Οδήγηση";
            btnDriverHelp.UseVisualStyleBackColor = false;
            btnDriverHelp.Click += btnDriverHelp_Click;
            // 
            // DriverMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnDriverHelp);
            Controls.Add(btnEnergy);
            Controls.Add(btnAircondition);
            Controls.Add(btnVacuum);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "DriverMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Μενού Οδηγού";
            FormClosing += DriverMainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnHelp;
        private Button btnExit;
        private Button btnVacuum;
        private Button btnAircondition;
        private Button btnEnergy;
        private Button btnDriverHelp;
    }
}