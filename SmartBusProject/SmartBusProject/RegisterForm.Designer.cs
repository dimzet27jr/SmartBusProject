using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartBusProject
{
    partial class RegisterForm
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
            UserName = new TextBox();
            Password = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            RegisterLabel = new Label();
            btnHelp = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Cursor = Cursors.IBeam;
            UserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            UserName.Location = new Point(382, 162);
            UserName.Name = "UserName";
            UserName.Size = new Size(238, 39);
            UserName.TabIndex = 16;
            UserName.Text = "Username";
            UserName.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Password.Location = new Point(382, 221);
            Password.Name = "Password";
            Password.Size = new Size(238, 39);
            Password.TabIndex = 16;
            Password.Text = "Password";
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DodgerBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            LoginButton.Location = new Point(407, 338);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(193, 35);
            LoginButton.TabIndex = 18;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.DodgerBlue;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            RegisterButton.Location = new Point(407, 280);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(193, 35);
            RegisterButton.TabIndex = 18;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.BackColor = Color.Transparent;
            RegisterLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            RegisterLabel.ForeColor = Color.DodgerBlue;
            RegisterLabel.Location = new Point(422, 94);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(164, 50);
            RegisterLabel.TabIndex = 15;
            RegisterLabel.Text = "Register";
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
            btnHelp.Location = new Point(0, 510);
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
            btnExit.Location = new Point(930, 510);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 64);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(RegisterLabel);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(UserName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartBus - Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private Button LoginButton;
        private Button RegisterButton;
        private Label RegisterLabel;
        private Button btnHelp;
        private Button btnExit;
    }
}