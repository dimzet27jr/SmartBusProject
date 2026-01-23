namespace SmartBusProject
{
    partial class DriverAssistanceForm
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
            pbxSpeedLimit = new PictureBox();
            speedLimitLabel = new Label();
            SpeedLimit = new Label();
            label1 = new Label();
            busSpeedLabel = new Label();
            pbxAccelarator = new PictureBox();
            pbxBrake = new PictureBox();
            pbxTurnLeft = new PictureBox();
            pbxTurnRight = new PictureBox();
            pbxMapDriverAssistance = new PictureBox();
            LanePosition = new Label();
            LanePositionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxSpeedLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAccelarator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTurnLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTurnRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMapDriverAssistance).BeginInit();
            SuspendLayout();
            // 
            // pbxSpeedLimit
            // 
            pbxSpeedLimit.BackColor = Color.Transparent;
            pbxSpeedLimit.BackgroundImage = Properties.Resources.speed_limit;
            pbxSpeedLimit.BackgroundImageLayout = ImageLayout.Stretch;
            pbxSpeedLimit.Location = new Point(810, 252);
            pbxSpeedLimit.Name = "pbxSpeedLimit";
            pbxSpeedLimit.Size = new Size(75, 75);
            pbxSpeedLimit.TabIndex = 0;
            pbxSpeedLimit.TabStop = false;
            // 
            // speedLimitLabel
            // 
            speedLimitLabel.AutoSize = true;
            speedLimitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            speedLimitLabel.Location = new Point(827, 272);
            speedLimitLabel.Name = "speedLimitLabel";
            speedLimitLabel.Size = new Size(40, 31);
            speedLimitLabel.TabIndex = 1;
            speedLimitLabel.Text = "70";
            // 
            // SpeedLimit
            // 
            SpeedLimit.AutoSize = true;
            SpeedLimit.BackColor = Color.Transparent;
            SpeedLimit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpeedLimit.ForeColor = Color.White;
            SpeedLimit.Location = new Point(764, 208);
            SpeedLimit.Name = "SpeedLimit";
            SpeedLimit.Size = new Size(169, 28);
            SpeedLimit.TabIndex = 2;
            SpeedLimit.Text = "Όριο Ταχύτητας";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(797, 349);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 3;
            label1.Text = "Ταχύτητα";
            // 
            // busSpeedLabel
            // 
            busSpeedLabel.AutoSize = true;
            busSpeedLabel.BackColor = Color.Transparent;
            busSpeedLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            busSpeedLabel.ForeColor = Color.White;
            busSpeedLabel.Location = new Point(790, 391);
            busSpeedLabel.Name = "busSpeedLabel";
            busSpeedLabel.Size = new Size(112, 38);
            busSpeedLabel.TabIndex = 4;
            busSpeedLabel.Text = "0 km/h";
            // 
            // pbxAccelarator
            // 
            pbxAccelarator.BackColor = Color.Transparent;
            pbxAccelarator.BackgroundImage = Properties.Resources.accelerator_icon;
            pbxAccelarator.BackgroundImageLayout = ImageLayout.Stretch;
            pbxAccelarator.Location = new Point(879, 473);
            pbxAccelarator.Name = "pbxAccelarator";
            pbxAccelarator.Size = new Size(103, 92);
            pbxAccelarator.TabIndex = 6;
            pbxAccelarator.TabStop = false;
            pbxAccelarator.MouseDown += pbxAccelarate_MouseDown;
            pbxAccelarator.MouseUp += pbxAccelarate_MouseUp;
            // 
            // pbxBrake
            // 
            pbxBrake.BackColor = Color.Transparent;
            pbxBrake.BackgroundImage = Properties.Resources.brake_icon;
            pbxBrake.BackgroundImageLayout = ImageLayout.Stretch;
            pbxBrake.Location = new Point(714, 473);
            pbxBrake.Name = "pbxBrake";
            pbxBrake.Size = new Size(103, 92);
            pbxBrake.TabIndex = 7;
            pbxBrake.TabStop = false;
            pbxBrake.MouseDown += pbxBrake_MouseDown;
            pbxBrake.MouseUp += pbxBrake_MouseUp;
            // 
            // pbxTurnLeft
            // 
            pbxTurnLeft.BackColor = Color.Transparent;
            pbxTurnLeft.BackgroundImage = Properties.Resources.turn_left;
            pbxTurnLeft.BackgroundImageLayout = ImageLayout.Stretch;
            pbxTurnLeft.Location = new Point(12, 473);
            pbxTurnLeft.Name = "pbxTurnLeft";
            pbxTurnLeft.Size = new Size(103, 92);
            pbxTurnLeft.TabIndex = 8;
            pbxTurnLeft.TabStop = false;
            pbxTurnLeft.MouseDown += pbxTurnLeft_MouseDown;
            pbxTurnLeft.MouseUp += pbxTurnLeft_MouseUp;
            // 
            // pbxTurnRight
            // 
            pbxTurnRight.BackColor = Color.Transparent;
            pbxTurnRight.BackgroundImage = Properties.Resources.turn_right;
            pbxTurnRight.BackgroundImageLayout = ImageLayout.Stretch;
            pbxTurnRight.Location = new Point(187, 473);
            pbxTurnRight.Name = "pbxTurnRight";
            pbxTurnRight.Size = new Size(103, 92);
            pbxTurnRight.TabIndex = 9;
            pbxTurnRight.TabStop = false;
            pbxTurnRight.MouseDown += pbxTurnRight_MouseDown;
            pbxTurnRight.MouseUp += pbxTurnRight_MouseUp;
            // 
            // pbxMapDriverAssistance
            // 
            pbxMapDriverAssistance.BackgroundImage = Properties.Resources.gps_assistance;
            pbxMapDriverAssistance.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMapDriverAssistance.Location = new Point(312, -1);
            pbxMapDriverAssistance.Name = "pbxMapDriverAssistance";
            pbxMapDriverAssistance.Size = new Size(382, 577);
            pbxMapDriverAssistance.TabIndex = 10;
            pbxMapDriverAssistance.TabStop = false;
            // 
            // LanePosition
            // 
            LanePosition.AutoSize = true;
            LanePosition.BackColor = Color.Transparent;
            LanePosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LanePosition.ForeColor = Color.White;
            LanePosition.Location = new Point(12, 312);
            LanePosition.Name = "LanePosition";
            LanePosition.Size = new Size(291, 28);
            LanePosition.TabIndex = 11;
            LanePosition.Text = "Κοντά στην αριστερή λορίδα";
            // 
            // LanePositionLabel
            // 
            LanePositionLabel.AutoSize = true;
            LanePositionLabel.BackColor = Color.Transparent;
            LanePositionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LanePositionLabel.ForeColor = Color.White;
            LanePositionLabel.Location = new Point(12, 275);
            LanePositionLabel.Name = "LanePositionLabel";
            LanePositionLabel.Size = new Size(190, 28);
            LanePositionLabel.TabIndex = 12;
            LanePositionLabel.Text = "Θέση Λεωφορείου:";
            // 
            // DriverAssistanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(LanePositionLabel);
            Controls.Add(LanePosition);
            Controls.Add(pbxMapDriverAssistance);
            Controls.Add(pbxTurnRight);
            Controls.Add(pbxTurnLeft);
            Controls.Add(pbxBrake);
            Controls.Add(pbxAccelarator);
            Controls.Add(busSpeedLabel);
            Controls.Add(label1);
            Controls.Add(SpeedLimit);
            Controls.Add(speedLimitLabel);
            Controls.Add(pbxSpeedLimit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "DriverAssistanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Βοήθεια στην Οδήγηση";
            FormClosing += DriverAssistanceForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbxSpeedLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAccelarator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrake).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTurnLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTurnRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMapDriverAssistance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxSpeedLimit;
        private Label speedLimitLabel;
        private Label SpeedLimit;
        private Label label1;
        private Label busSpeedLabel;
        private PictureBox pbxAccelarator;
        private PictureBox pbxBrake;
        private PictureBox pbxTurnLeft;
        private PictureBox pbxTurnRight;
        private PictureBox pbxMapDriverAssistance;
        private Label LanePosition;
        private Label LanePositionLabel;
    }
}