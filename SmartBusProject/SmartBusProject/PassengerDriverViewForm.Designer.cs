namespace SmartBusProject
{
    partial class PassengerDriverViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerDriverViewForm));
            driverViewVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)driverViewVideo).BeginInit();
            SuspendLayout();
            // 
            // driverViewVideo
            // 
            driverViewVideo.Enabled = true;
            driverViewVideo.Location = new Point(-1, 1);
            driverViewVideo.Name = "driverViewVideo";
            driverViewVideo.OcxState = (AxHost.State)resources.GetObject("driverViewVideo.OcxState");
            driverViewVideo.Size = new Size(1001, 598);
            driverViewVideo.TabIndex = 0;
            // 
            // PassengerDriverViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 600);
            Controls.Add(driverViewVideo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1000, 600);
            Name = "PassengerDriverViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Θέα Οδηγού";
            FormClosing += DriverView_FormClosing;
            ((System.ComponentModel.ISupportInitialize)driverViewVideo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer driverViewVideo;
    }
}