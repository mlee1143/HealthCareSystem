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
            diagnosisTextbox = new RichTextBox();
            heightTextbox = new TextBox();
            label2 = new Label();
            weightTextbox = new TextBox();
            label3 = new Label();
            doctorIDLabel = new Label();
            label5 = new Label();
            submitButton = new Button();
            errorLabel = new Label();
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
            back_btn.Click += back_btn_Click;
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
            patientIDLabel.Location = new Point(40, 88);
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
            patientnameLabel.Location = new Point(40, 105);
            patientnameLabel.Name = "patientnameLabel";
            patientnameLabel.Size = new Size(94, 17);
            patientnameLabel.TabIndex = 5;
            patientnameLabel.Text = "Patient Name:";
            // 
            // bloodpressureTextBox
            // 
            bloodpressureTextBox.BackColor = Color.FromArgb(255, 255, 242);
            bloodpressureTextBox.Location = new Point(95, 220);
            bloodpressureTextBox.Name = "bloodpressureTextBox";
            bloodpressureTextBox.Size = new Size(47, 23);
            bloodpressureTextBox.TabIndex = 6;
            bloodpressureTextBox.TextChanged += bloodpressureTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 243, 244);
            label1.Location = new Point(83, 200);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 7;
            label1.Text = "Blood Pressure";
            // 
            // temperatureTextbox
            // 
            temperatureTextbox.BackColor = Color.FromArgb(255, 255, 242);
            temperatureTextbox.ForeColor = Color.Black;
            temperatureTextbox.Location = new Point(448, 220);
            temperatureTextbox.Name = "temperatureTextbox";
            temperatureTextbox.Size = new Size(63, 23);
            temperatureTextbox.TabIndex = 8;
            temperatureTextbox.TextChanged += temperatureTextbox_TextChanged;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temperatureLabel.ForeColor = Color.FromArgb(242, 243, 244);
            temperatureLabel.Location = new Point(431, 200);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(100, 17);
            temperatureLabel.TabIndex = 9;
            temperatureLabel.Text = "Temperature (F)";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseLabel.ForeColor = Color.FromArgb(255, 255, 242);
            pulseLabel.Location = new Point(276, 200);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(38, 17);
            pulseLabel.TabIndex = 10;
            pulseLabel.Text = "Pulse";
            // 
            // pulseTextbox
            // 
            pulseTextbox.BackColor = Color.FromArgb(255, 255, 242);
            pulseTextbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseTextbox.Location = new Point(264, 220);
            pulseTextbox.Name = "pulseTextbox";
            pulseTextbox.Size = new Size(63, 23);
            pulseTextbox.TabIndex = 11;
            pulseTextbox.TextChanged += pulseTextbox_TextChanged;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsLabel.ForeColor = Color.FromArgb(255, 255, 242);
            symptomsLabel.Location = new Point(95, 280);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(69, 17);
            symptomsLabel.TabIndex = 12;
            symptomsLabel.Text = "Symptoms";
            // 
            // symptomsTextbox
            // 
            symptomsTextbox.BackColor = Color.FromArgb(255, 255, 242);
            symptomsTextbox.ForeColor = Color.Black;
            symptomsTextbox.Location = new Point(96, 300);
            symptomsTextbox.Name = "symptomsTextbox";
            symptomsTextbox.Size = new Size(415, 70);
            symptomsTextbox.TabIndex = 13;
            symptomsTextbox.Text = "";
            // 
            // diagnosisTextbox
            // 
            diagnosisTextbox.BackColor = Color.FromArgb(255, 255, 242);
            diagnosisTextbox.ForeColor = Color.Black;
            diagnosisTextbox.Location = new Point(95, 408);
            diagnosisTextbox.Name = "diagnosisTextbox";
            diagnosisTextbox.Size = new Size(415, 63);
            diagnosisTextbox.TabIndex = 14;
            diagnosisTextbox.Text = "";
            // 
            // heightTextbox
            // 
            heightTextbox.Location = new Point(180, 167);
            heightTextbox.Name = "heightTextbox";
            heightTextbox.Size = new Size(60, 23);
            heightTextbox.TabIndex = 15;
            heightTextbox.TextChanged += heightTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(242, 243, 244);
            label2.Location = new Point(180, 149);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 16;
            label2.Text = "Height (in.)";
            // 
            // weightTextbox
            // 
            weightTextbox.Location = new Point(349, 167);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Size = new Size(66, 23);
            weightTextbox.TabIndex = 17;
            weightTextbox.TextChanged += weightTextbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(244, 243, 242);
            label3.Location = new Point(349, 149);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 18;
            label3.Text = "Weight (lbs.)";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorIDLabel.ForeColor = Color.FromArgb(244, 243, 242);
            doctorIDLabel.Location = new Point(483, 88);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new Size(69, 17);
            doctorIDLabel.TabIndex = 19;
            doctorIDLabel.Text = "Doctor ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(244, 243, 242);
            label5.Location = new Point(96, 388);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 20;
            label5.Text = "Initial Diagnosis";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(249, 498);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(90, 23);
            submitButton.TabIndex = 21;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.FromArgb(244, 243, 242);
            errorLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(157, 256);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 17);
            errorLabel.TabIndex = 22;
            // 
            // VisitInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(624, 533);
            Controls.Add(errorLabel);
            Controls.Add(submitButton);
            Controls.Add(label5);
            Controls.Add(doctorIDLabel);
            Controls.Add(label3);
            Controls.Add(weightTextbox);
            Controls.Add(label2);
            Controls.Add(heightTextbox);
            Controls.Add(diagnosisTextbox);
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
        private RichTextBox diagnosisTextbox;
        private TextBox heightTextbox;
        private Label label2;
        private TextBox weightTextbox;
        private Label label3;
        private Label doctorIDLabel;
        private Label label5;
        private Button submitButton;
        private Label errorLabel;
    }
}