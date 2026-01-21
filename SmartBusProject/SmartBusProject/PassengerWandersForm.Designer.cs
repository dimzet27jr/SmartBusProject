namespace SmartBusProject
{
    partial class PassengerWandersForm
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
            labelWanders = new Label();
            btnBack = new Button();
            pbxAcropoli = new PictureBox();
            pbxTheseio = new PictureBox();
            pbxHrodio = new PictureBox();
            pbxEthnikoMouseio = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxAcropoli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTheseio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHrodio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxEthnikoMouseio).BeginInit();
            SuspendLayout();
            // 
            // labelWanders
            // 
            labelWanders.BackColor = Color.Transparent;
            labelWanders.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            labelWanders.ForeColor = Color.White;
            labelWanders.Location = new Point(154, 9);
            labelWanders.Name = "labelWanders";
            labelWanders.Size = new Size(720, 70);
            labelWanders.TabIndex = 1;
            labelWanders.Text = "Κοντινά Αξιοθέατα";
            labelWanders.TextAlign = ContentAlignment.MiddleCenter;
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
            btnBack.Location = new Point(12, 511);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(64, 64);
            btnBack.TabIndex = 4;
            btnBack.TabStop = false;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pbxAcropoli
            // 
            pbxAcropoli.BackgroundImage = Properties.Resources.akropoli;
            pbxAcropoli.BackgroundImageLayout = ImageLayout.Stretch;
            pbxAcropoli.Cursor = Cursors.Hand;
            pbxAcropoli.Location = new Point(164, 101);
            pbxAcropoli.Name = "pbxAcropoli";
            pbxAcropoli.Size = new Size(307, 164);
            pbxAcropoli.TabIndex = 5;
            pbxAcropoli.TabStop = false;
            pbxAcropoli.Click += pbxAcropoli_Click;
            // 
            // pbxTheseio
            // 
            pbxTheseio.BackgroundImage = Properties.Resources.theseio;
            pbxTheseio.BackgroundImageLayout = ImageLayout.Stretch;
            pbxTheseio.Cursor = Cursors.Hand;
            pbxTheseio.Location = new Point(531, 101);
            pbxTheseio.Name = "pbxTheseio";
            pbxTheseio.Size = new Size(307, 164);
            pbxTheseio.TabIndex = 6;
            pbxTheseio.TabStop = false;
            pbxTheseio.Click += pbxTheseio_Click;
            // 
            // pbxHrodio
            // 
            pbxHrodio.BackgroundImage = Properties.Resources.hrodio;
            pbxHrodio.BackgroundImageLayout = ImageLayout.Stretch;
            pbxHrodio.Cursor = Cursors.Hand;
            pbxHrodio.Location = new Point(531, 298);
            pbxHrodio.Name = "pbxHrodio";
            pbxHrodio.Size = new Size(307, 164);
            pbxHrodio.TabIndex = 7;
            pbxHrodio.TabStop = false;
            pbxHrodio.Click += pbxHrodio_Click;
            // 
            // pbxEthnikoMouseio
            // 
            pbxEthnikoMouseio.BackgroundImage = Properties.Resources.pnika;
            pbxEthnikoMouseio.BackgroundImageLayout = ImageLayout.Stretch;
            pbxEthnikoMouseio.Cursor = Cursors.Hand;
            pbxEthnikoMouseio.Location = new Point(164, 298);
            pbxEthnikoMouseio.Name = "pbxEthnikoMouseio";
            pbxEthnikoMouseio.Size = new Size(307, 164);
            pbxEthnikoMouseio.TabIndex = 8;
            pbxEthnikoMouseio.TabStop = false;
            pbxEthnikoMouseio.Click += pbxEthnikoMouseio_Click;
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
            btnExit.Location = new Point(918, 511);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 64);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // PassengerWandersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.app_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 577);
            Controls.Add(btnExit);
            Controls.Add(pbxEthnikoMouseio);
            Controls.Add(pbxHrodio);
            Controls.Add(pbxTheseio);
            Controls.Add(pbxAcropoli);
            Controls.Add(btnBack);
            Controls.Add(labelWanders);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1012, 624);
            MinimumSize = new Size(1012, 624);
            Name = "PassengerWandersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Κοντινά Αξιοθέατα";
            FormClosing += PassengerWandersForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbxAcropoli).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTheseio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHrodio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxEthnikoMouseio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelWanders;
        private Button btnBack;
        private PictureBox pbxAcropoli;
        private PictureBox pbxTheseio;
        private PictureBox pbxHrodio;
        private PictureBox pbxEthnikoMouseio;
        private Button btnExit;
    }
}