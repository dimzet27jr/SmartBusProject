using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartBusProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserName = new TextBox();
            Password = new TextBox();
            LoginLabel = new Label();
            LoginButton = new Button();
            RegisterButton = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Cursor = Cursors.IBeam;
            UserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            UserName.Location = new Point(384, 173);
            UserName.Name = "UserName";
            UserName.Size = new Size(238, 39);
            UserName.TabIndex = 16;
            UserName.Text = "Username";
            UserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Password.Location = new Point(384, 227);
            Password.Name = "Password";
            Password.Size = new Size(238, 39);
            Password.TabIndex = 16;
            Password.Text = "Password";
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            LoginLabel.ForeColor = Color.DodgerBlue;
            LoginLabel.Location = new Point(444, 111);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(120, 50);
            LoginLabel.TabIndex = 15;
            LoginLabel.Text = "Login";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DodgerBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            LoginButton.Location = new Point(410, 288);
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
            RegisterButton.Location = new Point(410, 341);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(193, 35);
            RegisterButton.TabIndex = 18;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHelp.BackColor = Color.Transparent;
            btnHelp.BackgroundImageLayout = ImageLayout.None;
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Image = Properties.Resources.helpIcon;
            btnHelp.Location = new Point(1, 512);
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
            btnExit.Location = new Point(929, 512);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 64);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(LoginLabel);
            Controls.Add(Password);
            Controls.Add(UserName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartBus - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private Label LoginLabel;
        private Button LoginButton;
        private Button RegisterButton;
        private Button btnHelp;
        private Button btnExit;
    }
}
