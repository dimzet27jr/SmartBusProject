using System.Windows.Forms;

namespace SmartBusProject
{
    partial class PayPalForm
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
            PayPalPicture = new PictureBox();
            PayPalEmail = new TextBox();
            PayPalPassword = new TextBox();
            ShowPassword = new PictureBox();
            Email = new Label();
            Password = new Label();
            CompleteOrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PayPalPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowPassword).BeginInit();
            SuspendLayout();
            // 
            // PayPalPicture
            // 
            PayPalPicture.BackgroundImage = Properties.Resources.Paypal;
            PayPalPicture.BackgroundImageLayout = ImageLayout.Stretch;
            PayPalPicture.Location = new Point(101, 12);
            PayPalPicture.Name = "PayPalPicture";
            PayPalPicture.Size = new Size(238, 75);
            PayPalPicture.TabIndex = 0;
            PayPalPicture.TabStop = false;
            // 
            // PayPalEmail
            // 
            PayPalEmail.Cursor = Cursors.IBeam;
            PayPalEmail.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            PayPalEmail.Location = new Point(101, 148);
            PayPalEmail.Name = "PayPalEmail";
            PayPalEmail.Size = new Size(238, 40);
            PayPalEmail.TabIndex = 1;
            // 
            // PayPalPassword
            // 
            PayPalPassword.Cursor = Cursors.IBeam;
            PayPalPassword.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            PayPalPassword.Location = new Point(101, 243);
            PayPalPassword.Name = "PayPalPassword";
            PayPalPassword.Size = new Size(238, 40);
            PayPalPassword.TabIndex = 2;
            PayPalPassword.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            ShowPassword.BackgroundImage = Properties.Resources.ShowPass;
            ShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            ShowPassword.Location = new Point(359, 243);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(47, 40);
            ShowPassword.TabIndex = 3;
            ShowPassword.TabStop = false;
            ShowPassword.Tag = "unchecked";
            ShowPassword.Click += ShowPassword_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Email.Location = new Point(101, 117);
            Email.Name = "Email";
            Email.Size = new Size(134, 28);
            Email.TabIndex = 4;
            Email.Text = "Email Address";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Password.Location = new Point(101, 212);
            Password.Name = "Password";
            Password.Size = new Size(93, 28);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // CompleteOrderButton
            // 
            CompleteOrderButton.BackColor = Color.Goldenrod;
            CompleteOrderButton.Cursor = Cursors.Hand;
            CompleteOrderButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 161);
            CompleteOrderButton.Location = new Point(101, 328);
            CompleteOrderButton.Name = "CompleteOrderButton";
            CompleteOrderButton.Size = new Size(238, 49);
            CompleteOrderButton.TabIndex = 6;
            CompleteOrderButton.Text = "Confirm";
            CompleteOrderButton.UseVisualStyleBackColor = false;
            CompleteOrderButton.Click += CompleteOrderButton_Click;
            // 
            // PayPalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            MaximumSize = new Size(449, 428);
            MinimumSize = new Size(449, 428);
            ClientSize = new Size(449, 428);
            Controls.Add(CompleteOrderButton);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(ShowPassword);
            Controls.Add(PayPalPassword);
            Controls.Add(PayPalEmail);
            Controls.Add(PayPalPicture);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PayPalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayPalForm";
            ((System.ComponentModel.ISupportInitialize)PayPalPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PayPalPicture;
        private TextBox PayPalEmail;
        private TextBox PayPalPassword;
        private PictureBox ShowPassword;
        private Label Email;
        private Label Password;
        private Button CompleteOrderButton;
    }
}