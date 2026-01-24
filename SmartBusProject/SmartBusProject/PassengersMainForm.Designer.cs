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
        private Button btnView;
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
            btnView = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            btnWanders = new Button();
            btnNavigation = new Button();
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
            btnCafe.Text = "Διαθέσιμες Καφετέριες";
            btnCafe.UseVisualStyleBackColor = false;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(25, 118, 210);
            btnView.Cursor = Cursors.Hand;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnView.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 12F);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(566, 171);
            btnView.Name = "btnView";
            btnView.Size = new Size(300, 90);
            btnView.TabIndex = 3;
            btnView.Text = "Θέα στον δρόμο";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
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
            // btnWanders
            // 
            btnWanders.BackColor = Color.FromArgb(25, 118, 210);
            btnWanders.Cursor = Cursors.Hand;
            btnWanders.FlatAppearance.BorderSize = 0;
            btnWanders.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnWanders.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnWanders.FlatStyle = FlatStyle.Flat;
            btnWanders.Font = new Font("Segoe UI", 12F);
            btnWanders.ForeColor = Color.White;
            btnWanders.Location = new Point(146, 324);
            btnWanders.Name = "btnWanders";
            btnWanders.Size = new Size(300, 90);
            btnWanders.TabIndex = 6;
            btnWanders.Text = "Αξιοθέατα";
            btnWanders.UseVisualStyleBackColor = false;
            btnWanders.Click += btnWanders_Click;
            // 
            // btnNavigation
            // 
            btnNavigation.BackColor = Color.FromArgb(25, 118, 210);
            btnNavigation.Cursor = Cursors.Hand;
            btnNavigation.FlatAppearance.BorderSize = 0;
            btnNavigation.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 39, 70);
            btnNavigation.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 152, 233);
            btnNavigation.FlatStyle = FlatStyle.Flat;
            btnNavigation.Font = new Font("Segoe UI", 12F);
            btnNavigation.ForeColor = Color.White;
            btnNavigation.Location = new Point(566, 324);
            btnNavigation.Name = "btnNavigation";
            btnNavigation.Size = new Size(300, 90);
            btnNavigation.TabIndex = 7;
            btnNavigation.Text = "Πλοήγηση";
            btnNavigation.UseVisualStyleBackColor = false;
            btnNavigation.Click += btnNavigation_Click;
            // 
            // PassengersMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnNavigation);
            Controls.Add(btnWanders);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(lblTitle);
            Controls.Add(btnCafe);
            Controls.Add(btnView);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "PassengersMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passenger Main Menu";
            FormClosing += PassengerMainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnWanders;
        private Button btnNavigation;
    }
}