namespace SmartBusProject
{
    partial class HelpForm
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
            HelpTextBox = new RichTextBox();
            HelpListBox = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(136, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(720, 70);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Βοήθεια Εφαρμογής";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HelpTextBox
            // 
            HelpTextBox.Location = new Point(193, 94);
            HelpTextBox.Name = "HelpTextBox";
            HelpTextBox.ReadOnly = true;
            HelpTextBox.Size = new Size(623, 412);
            HelpTextBox.TabIndex = 2;
            HelpTextBox.Text = "";
            // 
            // HelpListBox
            // 
            HelpListBox.BackColor = SystemColors.Window;
            HelpListBox.ForeColor = SystemColors.WindowText;
            HelpListBox.FormattingEnabled = true;
            HelpListBox.Location = new Point(837, 94);
            HelpListBox.Name = "HelpListBox";
            HelpListBox.Size = new Size(150, 104);
            HelpListBox.TabIndex = 3;
            HelpListBox.SelectedIndexChanged += ChangeIndex;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(HelpListBox);
            Controls.Add(HelpTextBox);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Βοήθεια";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private RichTextBox HelpTextBox;
        private ListBox HelpListBox;
    }
}