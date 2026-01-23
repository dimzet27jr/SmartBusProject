namespace SmartBusProject
{
    partial class AirCondtionControl
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
            components = new System.ComponentModel.Container();
            inTempLabel = new Label();
            outTempLabel = new Label();
            passengersLabel = new Label();
            pbxHeatMode = new PictureBox();
            pbxCoolMode = new PictureBox();
            pbxAddTemp = new PictureBox();
            pbxLowerTemp = new PictureBox();
            pbxFan = new PictureBox();
            pbxAuto = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxHeatMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCoolMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAddTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLowerTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAuto).BeginInit();
            SuspendLayout();
            // 
            // inTempLabel
            // 
            inTempLabel.AutoSize = true;
            inTempLabel.BackColor = Color.Transparent;
            inTempLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inTempLabel.ForeColor = Color.White;
            inTempLabel.Location = new Point(12, 242);
            inTempLabel.Name = "inTempLabel";
            inTempLabel.Size = new Size(111, 54);
            inTempLabel.TabIndex = 0;
            inTempLabel.Text = "--ΑΑ";
            // 
            // outTempLabel
            // 
            outTempLabel.AutoSize = true;
            outTempLabel.BackColor = Color.Transparent;
            outTempLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outTempLabel.ForeColor = Color.White;
            outTempLabel.Location = new Point(12, 9);
            outTempLabel.Name = "outTempLabel";
            outTempLabel.Size = new Size(310, 28);
            outTempLabel.TabIndex = 1;
            outTempLabel.Text = "Εξωτερική Θερμοκρασία: 25ΑΑ";
            // 
            // passengersLabel
            // 
            passengersLabel.AutoSize = true;
            passengersLabel.BackColor = Color.Transparent;
            passengersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passengersLabel.ForeColor = Color.White;
            passengersLabel.Location = new Point(12, 48);
            passengersLabel.Name = "passengersLabel";
            passengersLabel.Size = new Size(227, 28);
            passengersLabel.TabIndex = 2;
            passengersLabel.Text = "Αριθμός επιβατών: 23";
            // 
            // pbxHeatMode
            // 
            pbxHeatMode.BackColor = Color.Transparent;
            pbxHeatMode.BackgroundImage = Properties.Resources.heat_mode_on;
            pbxHeatMode.BackgroundImageLayout = ImageLayout.Center;
            pbxHeatMode.Cursor = Cursors.Hand;
            pbxHeatMode.Location = new Point(798, 330);
            pbxHeatMode.Name = "pbxHeatMode";
            pbxHeatMode.Size = new Size(125, 62);
            pbxHeatMode.TabIndex = 3;
            pbxHeatMode.TabStop = false;
            pbxHeatMode.Click += pbxHeatMode_Click;
            // 
            // pbxCoolMode
            // 
            pbxCoolMode.BackColor = Color.Transparent;
            pbxCoolMode.BackgroundImage = Properties.Resources.cool_mode_on;
            pbxCoolMode.BackgroundImageLayout = ImageLayout.Center;
            pbxCoolMode.Cursor = Cursors.Hand;
            pbxCoolMode.Location = new Point(798, 432);
            pbxCoolMode.Name = "pbxCoolMode";
            pbxCoolMode.Size = new Size(125, 62);
            pbxCoolMode.TabIndex = 4;
            pbxCoolMode.TabStop = false;
            pbxCoolMode.Click += pbxCoolMode_Click;
            // 
            // pbxAddTemp
            // 
            pbxAddTemp.BackColor = Color.Transparent;
            pbxAddTemp.BackgroundImage = Properties.Resources.tempup;
            pbxAddTemp.BackgroundImageLayout = ImageLayout.Center;
            pbxAddTemp.Cursor = Cursors.Hand;
            pbxAddTemp.Location = new Point(12, 153);
            pbxAddTemp.Name = "pbxAddTemp";
            pbxAddTemp.Size = new Size(125, 62);
            pbxAddTemp.TabIndex = 5;
            pbxAddTemp.TabStop = false;
            pbxAddTemp.Click += pbxAddTemp_Click;
            // 
            // pbxLowerTemp
            // 
            pbxLowerTemp.BackColor = Color.Transparent;
            pbxLowerTemp.BackgroundImage = Properties.Resources.tempdown;
            pbxLowerTemp.BackgroundImageLayout = ImageLayout.Center;
            pbxLowerTemp.Cursor = Cursors.Hand;
            pbxLowerTemp.Location = new Point(12, 316);
            pbxLowerTemp.Name = "pbxLowerTemp";
            pbxLowerTemp.Size = new Size(125, 62);
            pbxLowerTemp.TabIndex = 6;
            pbxLowerTemp.TabStop = false;
            pbxLowerTemp.Click += pbxLowerTemp_Click;
            // 
            // pbxFan
            // 
            pbxFan.BackColor = Color.Transparent;
            pbxFan.BackgroundImage = Properties.Resources.fan_low;
            pbxFan.BackgroundImageLayout = ImageLayout.Center;
            pbxFan.Location = new Point(798, 234);
            pbxFan.Name = "pbxFan";
            pbxFan.Size = new Size(125, 62);
            pbxFan.TabIndex = 7;
            pbxFan.TabStop = false;
            pbxFan.Click += pbxFan_Click;
            // 
            // pbxAuto
            // 
            pbxAuto.BackColor = Color.Transparent;
            pbxAuto.BackgroundImage = Properties.Resources.auto_off;
            pbxAuto.BackgroundImageLayout = ImageLayout.Center;
            pbxAuto.Cursor = Cursors.Hand;
            pbxAuto.Location = new Point(798, 132);
            pbxAuto.Name = "pbxAuto";
            pbxAuto.Size = new Size(125, 62);
            pbxAuto.TabIndex = 8;
            pbxAuto.TabStop = false;
            pbxAuto.Click += pbxAuto_Click;
            // 
            // btnInfo
            // 
            btnInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInfo.BackColor = Color.Transparent;
            btnInfo.BackgroundImage = Properties.Resources.info_icon;
            btnInfo.BackgroundImageLayout = ImageLayout.Center;
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Image = Properties.Resources.explain_icon;
            btnInfo.Location = new Point(798, 12);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(125, 64);
            btnInfo.TabIndex = 24;
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // AirCondtionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 527);
            Controls.Add(btnInfo);
            Controls.Add(pbxAuto);
            Controls.Add(pbxFan);
            Controls.Add(pbxLowerTemp);
            Controls.Add(pbxAddTemp);
            Controls.Add(pbxCoolMode);
            Controls.Add(pbxHeatMode);
            Controls.Add(passengersLabel);
            Controls.Add(outTempLabel);
            Controls.Add(inTempLabel);
            Name = "AirCondtionControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ρύθμιση Θερμοκρασίας";
            FormClosing += AirCondtionControl_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbxHeatMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCoolMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAddTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLowerTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAuto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inTempLabel;
        private Label outTempLabel;
        private Label passengersLabel;
        private PictureBox pbxHeatMode;
        private PictureBox pbxCoolMode;
        private PictureBox pbxAddTemp;
        private PictureBox pbxLowerTemp;
        private PictureBox pbxFan;
        private PictureBox pbxAuto;
        private System.Windows.Forms.Timer timer1;
        private Button btnInfo;
    }
}