using System.Windows.Forms;

namespace SmartBusProject
{
    partial class MasterCardForm
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
            CardOwner = new TextBox();
            CardCVV = new TextBox();
            CardNumber = new TextBox();
            ExpirationMonth = new TextBox();
            ExpirationYear = new TextBox();
            MonthLabel = new Label();
            YearLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            CompleteOrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CardOwner
            // 
            CardOwner.Cursor = Cursors.IBeam;
            CardOwner.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            CardOwner.Location = new Point(33, 151);
            CardOwner.Name = "CardOwner";
            CardOwner.Size = new Size(315, 40);
            CardOwner.TabIndex = 2;
            // 
            // CardCVV
            // 
            CardCVV.Cursor = Cursors.IBeam;
            CardCVV.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            CardCVV.Location = new Point(354, 151);
            CardCVV.Name = "CardCVV";
            CardCVV.Size = new Size(175, 40);
            CardCVV.TabIndex = 3;
            // 
            // CardNumber
            // 
            CardNumber.Cursor = Cursors.IBeam;
            CardNumber.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            CardNumber.Location = new Point(33, 237);
            CardNumber.Name = "CardNumber";
            CardNumber.Size = new Size(501, 40);
            CardNumber.TabIndex = 4;
            // 
            // ExpirationMonth
            // 
            ExpirationMonth.Cursor = Cursors.IBeam;
            ExpirationMonth.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            ExpirationMonth.Location = new Point(33, 325);
            ExpirationMonth.Name = "ExpirationMonth";
            ExpirationMonth.Size = new Size(111, 40);
            ExpirationMonth.TabIndex = 5;
            // 
            // ExpirationYear
            // 
            ExpirationYear.Cursor = Cursors.IBeam;
            ExpirationYear.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            ExpirationYear.Location = new Point(160, 325);
            ExpirationYear.Name = "ExpirationYear";
            ExpirationYear.Size = new Size(72, 40);
            ExpirationYear.TabIndex = 6;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.BackColor = Color.White;
            MonthLabel.Font = new Font("Segoe UI Light", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            MonthLabel.Location = new Point(57, 368);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(61, 20);
            MonthLabel.TabIndex = 7;
            MonthLabel.Text = "MONTH";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.BackColor = Color.White;
            YearLabel.Font = new Font("Segoe UI Light", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            YearLabel.Location = new Point(176, 368);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(42, 20);
            YearLabel.TabIndex = 8;
            YearLabel.Text = "YEAR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(329, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 52);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(467, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 52);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // CompleteOrderButton
            // 
            CompleteOrderButton.BackColor = Color.MediumAquamarine;
            CompleteOrderButton.Cursor = Cursors.Hand;
            CompleteOrderButton.Font = new Font("Segoe UI", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 161);
            CompleteOrderButton.Location = new Point(33, 409);
            CompleteOrderButton.Name = "CompleteOrderButton";
            CompleteOrderButton.Size = new Size(501, 51);
            CompleteOrderButton.TabIndex = 11;
            CompleteOrderButton.Text = "Complete Order";
            CompleteOrderButton.UseVisualStyleBackColor = false;
            CompleteOrderButton.Click += CompleteOrderButton_Click;
            // 
            // MasterCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.credit_card_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 500);
            Controls.Add(CompleteOrderButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(YearLabel);
            Controls.Add(MonthLabel);
            Controls.Add(ExpirationYear);
            Controls.Add(ExpirationMonth);
            Controls.Add(CardNumber);
            Controls.Add(CardCVV);
            Controls.Add(CardOwner);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MasterCardForm";
            Text = "PayWithMasterCard";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CardOwner;
        private TextBox CardCVV;
        private TextBox CardNumber;
        private TextBox ExpirationMonth;
        private TextBox ExpirationYear;
        private Label MonthLabel;
        private Label YearLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button CompleteOrderButton;
    }
}