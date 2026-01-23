namespace SmartBusProject
{
    partial class WanderViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WanderViewForm));
            WanderTitle = new Label();
            btnBack = new Button();
            btnExit = new Button();
            Wander_Desc = new RichTextBox();
            pbxWander = new PictureBox();
            pbxMap = new PictureBox();
            btnSpeak = new Button();
            btnStop = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxWander).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMap).BeginInit();
            SuspendLayout();
            // 
            // WanderTitle
            // 
            WanderTitle.BackColor = Color.Transparent;
            WanderTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            WanderTitle.ForeColor = Color.White;
            WanderTitle.Location = new Point(150, 9);
            WanderTitle.Name = "WanderTitle";
            WanderTitle.Size = new Size(720, 70);
            WanderTitle.TabIndex = 1;
            WanderTitle.Text = "Κύριες Λειτουργίες Επιβάτη";
            WanderTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            btnBack.Location = new Point(12, 501);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(64, 64);
            btnBack.TabIndex = 5;
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
            btnExit.Location = new Point(918, 501);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 64);
            btnExit.TabIndex = 10;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Wander_Desc
            // 
            Wander_Desc.BackColor = Color.FromArgb(128, 64, 0);
            Wander_Desc.BorderStyle = BorderStyle.None;
            Wander_Desc.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Wander_Desc.ForeColor = Color.White;
            Wander_Desc.Location = new Point(548, 109);
            Wander_Desc.Name = "Wander_Desc";
            Wander_Desc.ReadOnly = true;
            Wander_Desc.ScrollBars = RichTextBoxScrollBars.Vertical;
            Wander_Desc.Size = new Size(370, 386);
            Wander_Desc.TabIndex = 11;
            Wander_Desc.Text = resources.GetString("Wander_Desc.Text");
            // 
            // pbxWander
            // 
            pbxWander.BackgroundImage = Properties.Resources.akropoli;
            pbxWander.BackgroundImageLayout = ImageLayout.Stretch;
            pbxWander.Location = new Point(150, 82);
            pbxWander.Name = "pbxWander";
            pbxWander.Size = new Size(354, 211);
            pbxWander.TabIndex = 12;
            pbxWander.TabStop = false;
            // 
            // pbxMap
            // 
            pbxMap.BackgroundImage = Properties.Resources.akropoli;
            pbxMap.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMap.Cursor = Cursors.Hand;
            pbxMap.Location = new Point(150, 309);
            pbxMap.Name = "pbxMap";
            pbxMap.Size = new Size(354, 211);
            pbxMap.TabIndex = 13;
            pbxMap.TabStop = false;
            pbxMap.Click += pbxMap_Click;
            // 
            // btnSpeak
            // 
            btnSpeak.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSpeak.BackColor = Color.Transparent;
            btnSpeak.BackgroundImageLayout = ImageLayout.Zoom;
            btnSpeak.Cursor = Cursors.Hand;
            btnSpeak.FlatAppearance.BorderSize = 0;
            btnSpeak.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSpeak.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSpeak.FlatStyle = FlatStyle.Flat;
            btnSpeak.Image = Properties.Resources.speak;
            btnSpeak.Location = new Point(638, 501);
            btnSpeak.Name = "btnSpeak";
            btnSpeak.Size = new Size(64, 64);
            btnSpeak.TabIndex = 14;
            btnSpeak.UseVisualStyleBackColor = false;
            btnSpeak.Click += btnSpeak_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStop.BackColor = Color.Transparent;
            btnStop.BackgroundImageLayout = ImageLayout.Zoom;
            btnStop.Cursor = Cursors.Hand;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStop.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Image = Properties.Resources.stop;
            btnStop.Location = new Point(727, 501);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(64, 64);
            btnStop.TabIndex = 15;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // WanderViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.wander_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnStop);
            Controls.Add(btnSpeak);
            Controls.Add(pbxMap);
            Controls.Add(pbxWander);
            Controls.Add(Wander_Desc);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(WanderTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "WanderViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WanderViewForm";
            FormClosing += DriverAssistanceForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbxWander).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label WanderTitle;
        private Button btnBack;
        private Button btnExit;
        private RichTextBox Wander_Desc;
        private PictureBox pbxWander;
        private PictureBox pbxMap;
        private Button btnSpeak;
        private Button btnStop;
    }
}