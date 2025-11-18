using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SmartBusProject
{
    partial class VacuumForm
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
            VacuumTitle = new Label();
            ControlsPanel = new Panel();
            CleaningProssess = new ProgressBar();
            FloorSelector = new ComboBox();
            btnCharge = new Button();
            StatusLabel = new Label();
            BatteryPersent = new Label();
            BatteryLife = new ProgressBar();
            BatteryTitle = new Label();
            ZoneSelector = new Label();
            ModesSelections = new ComboBox();
            VacuumModes = new Label();
            btnEmergency = new Button();
            btnStop = new Button();
            btnPause = new Button();
            btnStart = new Button();
            ZonesPanels = new FlowLayoutPanel();
            EventsPanel = new Panel();
            EventList = new ListView();
            TimeHeader = new ColumnHeader();
            FloorHeader = new ColumnHeader();
            SeatHeader = new ColumnHeader();
            ItemHeader = new ColumnHeader();
            ImportanseHeader = new ColumnHeader();
            cleaningTimer = new System.Windows.Forms.Timer(components);
            chargeTimer = new System.Windows.Forms.Timer(components);
            ControlsPanel.SuspendLayout();
            EventsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // VacuumTitle
            // 
            VacuumTitle.AutoSize = true;
            VacuumTitle.BackColor = Color.Transparent;
            VacuumTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            VacuumTitle.ForeColor = Color.FromArgb(30, 30, 30);
            VacuumTitle.Location = new Point(354, 0);
            VacuumTitle.Name = "VacuumTitle";
            VacuumTitle.Size = new Size(268, 41);
            VacuumTitle.TabIndex = 0;
            VacuumTitle.Text = "Έλεγχος Σκούπας";
            VacuumTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControlsPanel
            // 
            ControlsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ControlsPanel.BackColor = Color.FromArgb(250, 250, 250);
            ControlsPanel.Controls.Add(CleaningProssess);
            ControlsPanel.Controls.Add(FloorSelector);
            ControlsPanel.Controls.Add(btnCharge);
            ControlsPanel.Controls.Add(StatusLabel);
            ControlsPanel.Controls.Add(BatteryPersent);
            ControlsPanel.Controls.Add(BatteryLife);
            ControlsPanel.Controls.Add(BatteryTitle);
            ControlsPanel.Controls.Add(ZoneSelector);
            ControlsPanel.Controls.Add(ModesSelections);
            ControlsPanel.Controls.Add(VacuumModes);
            ControlsPanel.Controls.Add(btnEmergency);
            ControlsPanel.Controls.Add(btnStop);
            ControlsPanel.Controls.Add(btnPause);
            ControlsPanel.Controls.Add(btnStart);
            ControlsPanel.Location = new Point(0, 44);
            ControlsPanel.Name = "ControlsPanel";
            ControlsPanel.Size = new Size(335, 535);
            ControlsPanel.TabIndex = 1;
            // 
            // CleaningProssess
            // 
            CleaningProssess.Location = new Point(20, 296);
            CleaningProssess.Name = "CleaningProssess";
            CleaningProssess.Size = new Size(294, 18);
            CleaningProssess.TabIndex = 14;
            // 
            // FloorSelector
            // 
            FloorSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            FloorSelector.FormattingEnabled = true;
            FloorSelector.Items.AddRange(new object[] { "Ισόγειο", "1ος Όροφος", "2ος Όροφος" });
            FloorSelector.Location = new Point(20, 262);
            FloorSelector.Name = "FloorSelector";
            FloorSelector.Size = new Size(140, 28);
            FloorSelector.TabIndex = 13;
            // 
            // btnCharge
            // 
            btnCharge.BackColor = Color.LimeGreen;
            btnCharge.FlatAppearance.BorderSize = 0;
            btnCharge.FlatStyle = FlatStyle.Flat;
            btnCharge.ForeColor = Color.White;
            btnCharge.Location = new Point(108, 494);
            btnCharge.Name = "btnCharge";
            btnCharge.Size = new Size(120, 28);
            btnCharge.TabIndex = 12;
            btnCharge.Text = "Charge";
            btnCharge.UseVisualStyleBackColor = false;
            btnCharge.Click += btnCharge_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            StatusLabel.ForeColor = Color.Gray;
            StatusLabel.Location = new Point(20, 327);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(78, 20);
            StatusLabel.TabIndex = 11;
            StatusLabel.Text = "Status: Idle";
            // 
            // BatteryPersent
            // 
            BatteryPersent.AutoSize = true;
            BatteryPersent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BatteryPersent.Location = new Point(222, 468);
            BatteryPersent.Name = "BatteryPersent";
            BatteryPersent.Size = new Size(49, 20);
            BatteryPersent.TabIndex = 10;
            BatteryPersent.Text = "100%";
            // 
            // BatteryLife
            // 
            BatteryLife.Location = new Point(16, 468);
            BatteryLife.Name = "BatteryLife";
            BatteryLife.Size = new Size(200, 20);
            BatteryLife.TabIndex = 9;
            BatteryLife.Value = 100;
            // 
            // BatteryTitle
            // 
            BatteryTitle.AutoSize = true;
            BatteryTitle.Font = new Font("Segoe UI", 10F);
            BatteryTitle.Location = new Point(16, 440);
            BatteryTitle.Name = "BatteryTitle";
            BatteryTitle.Size = new Size(131, 23);
            BatteryTitle.TabIndex = 8;
            BatteryTitle.Text = "Vacuum Battery";
            // 
            // ZoneSelector
            // 
            ZoneSelector.AutoSize = true;
            ZoneSelector.Font = new Font("Segoe UI", 10F);
            ZoneSelector.Location = new Point(20, 236);
            ZoneSelector.Name = "ZoneSelector";
            ZoneSelector.Size = new Size(98, 23);
            ZoneSelector.TabIndex = 6;
            ZoneSelector.Text = "Select Floor";
            // 
            // ModesSelections
            // 
            ModesSelections.DropDownStyle = ComboBoxStyle.DropDownList;
            ModesSelections.FormattingEnabled = true;
            ModesSelections.Items.AddRange(new object[] { "Auto", "Spot", "Edge", "Quick", "Deep" });
            ModesSelections.Location = new Point(16, 196);
            ModesSelections.Name = "ModesSelections";
            ModesSelections.Size = new Size(151, 28);
            ModesSelections.TabIndex = 5;
            // 
            // VacuumModes
            // 
            VacuumModes.AutoSize = true;
            VacuumModes.Font = new Font("Segoe UI", 10F);
            VacuumModes.Location = new Point(16, 170);
            VacuumModes.Name = "VacuumModes";
            VacuumModes.Size = new Size(126, 23);
            VacuumModes.TabIndex = 4;
            VacuumModes.Text = "Cleaning Mode";
            // 
            // btnEmergency
            // 
            btnEmergency.BackColor = Color.FromArgb(200, 30, 30);
            btnEmergency.FlatAppearance.BorderSize = 0;
            btnEmergency.FlatStyle = FlatStyle.Flat;
            btnEmergency.ForeColor = Color.White;
            btnEmergency.Location = new Point(173, 179);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(140, 60);
            btnEmergency.TabIndex = 3;
            btnEmergency.Text = "Emergency \nStop";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click_1;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(220, 53, 69);
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(97, 80);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(140, 44);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click_1;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.FromArgb(245, 193, 53);
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Location = new Point(170, 18);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(140, 44);
            btnPause.TabIndex = 1;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click_1;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(25, 118, 210);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(20, 18);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(140, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click_1;
            // 
            // ZonesPanels
            // 
            ZonesPanels.AutoScroll = true;
            ZonesPanels.BackColor = Color.Transparent;
            ZonesPanels.BackgroundImage = Properties.Resources.VacuumBackground;
            ZonesPanels.BackgroundImageLayout = ImageLayout.Stretch;
            ZonesPanels.Location = new Point(10, 10);
            ZonesPanels.Name = "ZonesPanels";
            ZonesPanels.Size = new Size(640, 246);
            ZonesPanels.TabIndex = 7;
            // 
            // EventsPanel
            // 
            EventsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EventsPanel.BackColor = Color.WhiteSmoke;
            EventsPanel.Controls.Add(ZonesPanels);
            EventsPanel.Controls.Add(EventList);
            EventsPanel.Location = new Point(334, 44);
            EventsPanel.Name = "EventsPanel";
            EventsPanel.Size = new Size(660, 532);
            EventsPanel.TabIndex = 2;
            // 
            // EventList
            // 
            EventList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EventList.Columns.AddRange(new ColumnHeader[] { TimeHeader, FloorHeader, SeatHeader, ItemHeader, ImportanseHeader });
            EventList.FullRowSelect = true;
            EventList.Location = new Point(10, 256);
            EventList.Name = "EventList";
            EventList.Size = new Size(640, 265);
            EventList.TabIndex = 1;
            EventList.UseCompatibleStateImageBehavior = false;
            EventList.View = View.Details;
            // 
            // TimeHeader
            // 
            TimeHeader.Text = "Time";
            TimeHeader.Width = 140;
            // 
            // FloorHeader
            // 
            FloorHeader.Text = "Floor";
            FloorHeader.Width = 140;
            // 
            // SeatHeader
            // 
            SeatHeader.Text = "Seat";
            SeatHeader.Width = 100;
            // 
            // ItemHeader
            // 
            ItemHeader.Text = "Item";
            ItemHeader.Width = 150;
            // 
            // ImportanseHeader
            // 
            ImportanseHeader.Text = "Importanse";
            ImportanseHeader.Width = 120;
            // 
            // cleaningTimer
            // 
            cleaningTimer.Interval = 500;
            cleaningTimer.Tick += CleaningTimer_Tick;
            // 
            // chargeTimer
            // 
            chargeTimer.Interval = 600;
            chargeTimer.Tick += ChargeTimer_Tick;
            // 
            // VacuumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(EventsPanel);
            Controls.Add(ControlsPanel);
            Controls.Add(VacuumTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "VacuumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vacuum";
            ControlsPanel.ResumeLayout(false);
            ControlsPanel.PerformLayout();
            EventsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VacuumTitle;
        private Panel ControlsPanel;
        private Button btnStart;
        private Button btnPause;
        private Button btnStop;
        private Button btnEmergency;
        private Label VacuumModes;
        private ComboBox ModesSelections;
        private Label ZoneSelector;
        private FlowLayoutPanel ZonesPanels;
        private Label BatteryTitle;
        private ProgressBar BatteryLife;
        private Label BatteryPersent;
        private Label StatusLabel;
        private Button btnCharge;
        private Panel EventsPanel;
        private ListView EventList;
        private ColumnHeader TimeHeader;
        private ColumnHeader FloorHeader;
        private ColumnHeader ItemHeader;
        private ComboBox FloorSelector;
        private ProgressBar CleaningProssess;
        private ColumnHeader SeatHeader;
        private ColumnHeader ImportanseHeader;
        private System.Windows.Forms.Timer cleaningTimer;
        private System.Windows.Forms.Timer chargeTimer;
    }
}