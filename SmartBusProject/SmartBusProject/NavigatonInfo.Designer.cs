namespace SmartBusProject
{
    partial class NavigatonInfo
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
            btnExit = new Button();
            button1 = new Button();
            button2 = new Button();
            navigatonInfoLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
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
            btnExit.Image = Properties.Resources.bus_stop;
            btnExit.Location = new Point(35, 78);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 78);
            btnExit.TabIndex = 18;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.wander_location;
            button1.Location = new Point(35, 240);
            button1.Name = "button1";
            button1.Size = new Size(84, 70);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.bus_stop_selected;
            button2.Location = new Point(35, 162);
            button2.Name = "button2";
            button2.Size = new Size(84, 72);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            // 
            // navigatonInfoLabel
            // 
            navigatonInfoLabel.BackColor = Color.Transparent;
            navigatonInfoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navigatonInfoLabel.ForeColor = Color.Black;
            navigatonInfoLabel.Location = new Point(63, 5);
            navigatonInfoLabel.Name = "navigatonInfoLabel";
            navigatonInfoLabel.Size = new Size(288, 70);
            navigatonInfoLabel.TabIndex = 21;
            navigatonInfoLabel.Text = "Εικονίδια Χάρτη";
            navigatonInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(116, 92);
            label1.Name = "label1";
            label1.Size = new Size(220, 43);
            label1.TabIndex = 22;
            label1.Text = ": Διαθέσιμη Στάση";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(116, 173);
            label2.Name = "label2";
            label2.Size = new Size(235, 43);
            label2.TabIndex = 23;
            label2.Text = ": Επιλεγμένη Στάση";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(116, 250);
            label3.Name = "label3";
            label3.Size = new Size(246, 43);
            label3.TabIndex = 24;
            label3.Text = ": Κοντινό Αξιοθέατο";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(116, 326);
            label4.Name = "label4";
            label4.Size = new Size(258, 43);
            label4.TabIndex = 25;
            label4.Text = ": Κοντινό Εστιατόριο";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.restaurant;
            button3.Location = new Point(35, 316);
            button3.Name = "button3";
            button3.Size = new Size(84, 70);
            button3.TabIndex = 26;
            button3.UseVisualStyleBackColor = false;
            // 
            // NavigatonInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(404, 456);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(navigatonInfoLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Name = "NavigatonInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Εικονίδια Χάρτη";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button button1;
        private Button button2;
        private Label navigatonInfoLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
    }
}