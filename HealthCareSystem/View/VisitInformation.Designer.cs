namespace HealthCareSystem.View
{
    partial class VisitInformation
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
            healthCareNamePanel = new Panel();
            back_btn = new Button();
            healthCareNameLabel = new Label();
            symbolPictureBox = new PictureBox();
            patientIDLabel = new Label();
            patientnameLabel = new Label();
            bloodpressureTextBox = new TextBox();
            label1 = new Label();
            temperatureTextbox = new TextBox();
            temperatureLabel = new Label();
            pulseLabel = new Label();
            pulseTextbox = new TextBox();
            symptomsLabel = new Label();
            symptomsTextbox = new RichTextBox();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(back_btn);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(83, 0);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(562, 76);
            healthCareNamePanel.TabIndex = 2;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.FromArgb(255, 255, 242);
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.ForeColor = Color.Black;
            back_btn.Location = new Point(451, 39);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 1;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(12, 29);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(1, 0);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            symbolPictureBox.TabIndex = 3;
            symbolPictureBox.TabStop = false;
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientIDLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientIDLabel.Location = new Point(40, 104);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new Size(75, 17);
            patientIDLabel.TabIndex = 4;
            patientIDLabel.Text = "Patient ID: ";
            // 
            // patientnameLabel
            // 
            patientnameLabel.AutoSize = true;
            patientnameLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientnameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientnameLabel.Location = new Point(191, 104);
            patientnameLabel.Name = "patientnameLabel";
            patientnameLabel.Size = new Size(94, 17);
            patientnameLabel.TabIndex = 5;
            patientnameLabel.Text = "Patient Name:";
            // 
            // bloodpressureTextBox
            // 
            bloodpressureTextBox.BackColor = Color.FromArgb(255, 255, 242);
            bloodpressureTextBox.Location = new Point(52, 196);
            bloodpressureTextBox.Name = "bloodpressureTextBox";
            bloodpressureTextBox.Size = new Size(116, 23);
            bloodpressureTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 243, 244);
            label1.Location = new Point(52, 176);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 7;
            label1.Text = "Blood Pressure";
            // 
            // temperatureTextbox
            // 
            temperatureTextbox.BackColor = Color.FromArgb(255, 255, 242);
            temperatureTextbox.Location = new Point(247, 196);
            temperatureTextbox.Name = "temperatureTextbox";
            temperatureTextbox.Size = new Size(63, 23);
            temperatureTextbox.TabIndex = 8;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temperatureLabel.ForeColor = Color.FromArgb(242, 243, 244);
            temperatureLabel.Location = new Point(247, 176);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(139, 17);
            temperatureLabel.TabIndex = 9;
            temperatureLabel.Text = "Body Temperature (F)";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pulseLabel.ForeColor = Color.FromArgb(255, 255, 242);
            pulseLabel.Location = new Point(472, 176);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(40, 17);
            pulseLabel.TabIndex = 10;
            pulseLabel.Text = "Pulse";
            // 
            // pulseTextbox
            // 
            pulseTextbox.BackColor = Color.FromArgb(255, 255, 242);
            pulseTextbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseTextbox.Location = new Point(472, 196);
            pulseTextbox.Name = "pulseTextbox";
            pulseTextbox.Size = new Size(63, 23);
            pulseTextbox.TabIndex = 11;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            symptomsLabel.ForeColor = Color.FromArgb(255, 255, 242);
            symptomsLabel.Location = new Point(52, 252);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(73, 17);
            symptomsLabel.TabIndex = 12;
            symptomsLabel.Text = "Symptoms";
            // 
            // symptomsTextbox
            // 
            symptomsTextbox.BackColor = Color.FromArgb(255, 255, 242);
            symptomsTextbox.ForeColor = Color.Black;
            symptomsTextbox.Location = new Point(52, 272);
            symptomsTextbox.Name = "symptomsTextbox";
            symptomsTextbox.Size = new Size(483, 108);
            symptomsTextbox.TabIndex = 13;
            symptomsTextbox.Text = "";
            // 
            // VisitInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(625, 424);
            Controls.Add(symptomsTextbox);
            Controls.Add(symptomsLabel);
            Controls.Add(pulseTextbox);
            Controls.Add(pulseLabel);
            Controls.Add(temperatureLabel);
            Controls.Add(temperatureTextbox);
            Controls.Add(label1);
            Controls.Add(bloodpressureTextBox);
            Controls.Add(patientnameLabel);
            Controls.Add(patientIDLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Name = "VisitInformation";
            Text = "VisitInformation";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private Button back_btn;
        private Label healthCareNameLabel;
        private PictureBox symbolPictureBox;
        private Label patientIDLabel;
        private Label patientnameLabel;
        private TextBox bloodpressureTextBox;
        private Label label1;
        private TextBox temperatureTextbox;
        private Label temperatureLabel;
        private Label pulseLabel;
        private TextBox pulseTextbox;
        private Label symptomsLabel;
        private RichTextBox symptomsTextbox;
    }
}