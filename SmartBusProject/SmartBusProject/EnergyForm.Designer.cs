namespace SmartBusProject
{
    partial class EnergyForm
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
            pbxPanelControls = new PictureBox();
            pbxAirCondControl = new PictureBox();
            PanelInfoLabel = new Label();
            AcInfoLabel = new Label();
            BusBattery = new ProgressBar();
            ButtaryLabel = new Label();
            EnergyFlowLabel = new Label();
            EnergyOutLabel = new Label();
            WeatherLabel = new Label();
            pbxWeather = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxPanelControls).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAirCondControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxWeather).BeginInit();
            SuspendLayout();
            // 
            // pbxPanelControls
            // 
            pbxPanelControls.BackColor = Color.Transparent;
            pbxPanelControls.BackgroundImage = Properties.Resources.panel_on;
            pbxPanelControls.BackgroundImageLayout = ImageLayout.Center;
            pbxPanelControls.Cursor = Cursors.Hand;
            pbxPanelControls.Location = new Point(645, 218);
            pbxPanelControls.Name = "pbxPanelControls";
            pbxPanelControls.Size = new Size(125, 68);
            pbxPanelControls.TabIndex = 0;
            pbxPanelControls.TabStop = false;
            pbxPanelControls.Click += pbxPanelControls_Click;
            // 
            // pbxAirCondControl
            // 
            pbxAirCondControl.BackColor = Color.Transparent;
            pbxAirCondControl.BackgroundImage = Properties.Resources.ac_off;
            pbxAirCondControl.BackgroundImageLayout = ImageLayout.Center;
            pbxAirCondControl.Cursor = Cursors.Hand;
            pbxAirCondControl.Location = new Point(440, 218);
            pbxAirCondControl.Name = "pbxAirCondControl";
            pbxAirCondControl.Size = new Size(125, 68);
            pbxAirCondControl.TabIndex = 1;
            pbxAirCondControl.TabStop = false;
            pbxAirCondControl.Click += pbxAirCondControl_Click;
            // 
            // PanelInfoLabel
            // 
            PanelInfoLabel.AutoSize = true;
            PanelInfoLabel.BackColor = Color.Transparent;
            PanelInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelInfoLabel.ForeColor = Color.White;
            PanelInfoLabel.Location = new Point(655, 187);
            PanelInfoLabel.Name = "PanelInfoLabel";
            PanelInfoLabel.Size = new Size(111, 28);
            PanelInfoLabel.TabIndex = 2;
            PanelInfoLabel.Text = "Panels: On";
            // 
            // AcInfoLabel
            // 
            AcInfoLabel.AutoSize = true;
            AcInfoLabel.BackColor = Color.Transparent;
            AcInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AcInfoLabel.ForeColor = Color.White;
            AcInfoLabel.Location = new Point(462, 187);
            AcInfoLabel.Name = "AcInfoLabel";
            AcInfoLabel.Size = new Size(76, 28);
            AcInfoLabel.TabIndex = 3;
            AcInfoLabel.Text = "AC: On";
            // 
            // BusBattery
            // 
            BusBattery.ForeColor = Color.RoyalBlue;
            BusBattery.Location = new Point(278, 413);
            BusBattery.Maximum = 3000;
            BusBattery.Name = "BusBattery";
            BusBattery.Size = new Size(416, 29);
            BusBattery.TabIndex = 4;
            // 
            // ButtaryLabel
            // 
            ButtaryLabel.AutoSize = true;
            ButtaryLabel.BackColor = Color.Transparent;
            ButtaryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtaryLabel.ForeColor = Color.White;
            ButtaryLabel.Location = new Point(700, 414);
            ButtaryLabel.Name = "ButtaryLabel";
            ButtaryLabel.Size = new Size(70, 28);
            ButtaryLabel.TabIndex = 5;
            ButtaryLabel.Text = ":100%";
            // 
            // EnergyFlowLabel
            // 
            EnergyFlowLabel.AutoSize = true;
            EnergyFlowLabel.BackColor = Color.Transparent;
            EnergyFlowLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnergyFlowLabel.ForeColor = Color.White;
            EnergyFlowLabel.Location = new Point(12, 9);
            EnergyFlowLabel.Name = "EnergyFlowLabel";
            EnergyFlowLabel.Size = new Size(297, 28);
            EnergyFlowLabel.TabIndex = 6;
            EnergyFlowLabel.Text = "Παραγωγή Ενέργειας: 12 Kwh";
            // 
            // EnergyOutLabel
            // 
            EnergyOutLabel.AutoSize = true;
            EnergyOutLabel.BackColor = Color.Transparent;
            EnergyOutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnergyOutLabel.ForeColor = Color.White;
            EnergyOutLabel.Location = new Point(655, 9);
            EnergyOutLabel.Name = "EnergyOutLabel";
            EnergyOutLabel.Size = new Size(327, 28);
            EnergyOutLabel.TabIndex = 7;
            EnergyOutLabel.Text = "Κατανάλωση Ενέργειας: -12 Kwh";
            // 
            // WeatherLabel
            // 
            WeatherLabel.AutoSize = true;
            WeatherLabel.BackColor = Color.Transparent;
            WeatherLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WeatherLabel.ForeColor = Color.White;
            WeatherLabel.Location = new Point(236, 187);
            WeatherLabel.Name = "WeatherLabel";
            WeatherLabel.Size = new Size(84, 28);
            WeatherLabel.TabIndex = 8;
            WeatherLabel.Text = "Καιρός:";
            // 
            // pbxWeather
            // 
            pbxWeather.BackColor = Color.Transparent;
            pbxWeather.BackgroundImage = Properties.Resources.sunny_weather;
            pbxWeather.BackgroundImageLayout = ImageLayout.Center;
            pbxWeather.Location = new Point(216, 218);
            pbxWeather.Name = "pbxWeather";
            pbxWeather.Size = new Size(125, 68);
            pbxWeather.TabIndex = 9;
            pbxWeather.TabStop = false;
            // 
            // EnergyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(pbxWeather);
            Controls.Add(WeatherLabel);
            Controls.Add(EnergyOutLabel);
            Controls.Add(EnergyFlowLabel);
            Controls.Add(ButtaryLabel);
            Controls.Add(BusBattery);
            Controls.Add(AcInfoLabel);
            Controls.Add(PanelInfoLabel);
            Controls.Add(pbxAirCondControl);
            Controls.Add(pbxPanelControls);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "EnergyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Διαχείριση Ενέργειας - Φωτοβολταϊκών";
            FormClosing += EnergyForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbxPanelControls).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAirCondControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxWeather).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxPanelControls;
        private PictureBox pbxAirCondControl;
        private Label PanelInfoLabel;
        private Label AcInfoLabel;
        private ProgressBar BusBattery;
        private Label ButtaryLabel;
        private Label EnergyFlowLabel;
        private Label EnergyOutLabel;
        private Label WeatherLabel;
        private PictureBox pbxWeather;
    }
}