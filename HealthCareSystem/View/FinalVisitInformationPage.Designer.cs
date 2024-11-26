namespace HealthCareSystem.View
{
    partial class FinalVisitInformationPage
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
            symbolPictureBox = new PictureBox();
            healthCareNamePanel = new Panel();
            healthCareNameLabel = new Label();
            visitInforGroupBox = new GroupBox();
            orderedTestDataGridView = new DataGridView();
            finalDiagnosisTextBox = new TextBox();
            initialDiagnosisTextBox = new TextBox();
            symptomsTextBox = new TextBox();
            orderedTestsLabel = new Label();
            finalDiagnosisLabel = new Label();
            intialDIagnosisLabel = new Label();
            symptomsLabel = new Label();
            bloodPressureLabel = new Label();
            pulseLabel = new Label();
            temperatureLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            patientInfoLabel = new Label();
            goBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            visitInforGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderedTestDataGridView).BeginInit();
            SuspendLayout();
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(0, 0);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 0;
            symbolPictureBox.TabStop = false;
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(87, 0);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(677, 76);
            healthCareNamePanel.TabIndex = 1;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(6, 20);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 2;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // visitInforGroupBox
            // 
            visitInforGroupBox.Controls.Add(orderedTestDataGridView);
            visitInforGroupBox.Controls.Add(finalDiagnosisTextBox);
            visitInforGroupBox.Controls.Add(initialDiagnosisTextBox);
            visitInforGroupBox.Controls.Add(symptomsTextBox);
            visitInforGroupBox.Controls.Add(orderedTestsLabel);
            visitInforGroupBox.Controls.Add(finalDiagnosisLabel);
            visitInforGroupBox.Controls.Add(intialDIagnosisLabel);
            visitInforGroupBox.Controls.Add(symptomsLabel);
            visitInforGroupBox.Controls.Add(bloodPressureLabel);
            visitInforGroupBox.Controls.Add(pulseLabel);
            visitInforGroupBox.Controls.Add(temperatureLabel);
            visitInforGroupBox.Controls.Add(heightLabel);
            visitInforGroupBox.Controls.Add(weightLabel);
            visitInforGroupBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            visitInforGroupBox.ForeColor = Color.FromArgb(242, 243, 244);
            visitInforGroupBox.Location = new Point(12, 141);
            visitInforGroupBox.Name = "visitInforGroupBox";
            visitInforGroupBox.Size = new Size(729, 393);
            visitInforGroupBox.TabIndex = 2;
            visitInforGroupBox.TabStop = false;
            visitInforGroupBox.Text = "Information Summary";
            // 
            // orderedTestDataGridView
            // 
            orderedTestDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderedTestDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            orderedTestDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderedTestDataGridView.Location = new Point(372, 256);
            orderedTestDataGridView.Name = "orderedTestDataGridView";
            orderedTestDataGridView.ReadOnly = true;
            orderedTestDataGridView.Size = new Size(338, 112);
            orderedTestDataGridView.TabIndex = 12;
            // 
            // finalDiagnosisTextBox
            // 
            finalDiagnosisTextBox.Location = new Point(4, 256);
            finalDiagnosisTextBox.Multiline = true;
            finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            finalDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.Size = new Size(338, 112);
            finalDiagnosisTextBox.TabIndex = 11;
            // 
            // initialDiagnosisTextBox
            // 
            initialDiagnosisTextBox.Location = new Point(372, 107);
            initialDiagnosisTextBox.Multiline = true;
            initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            initialDiagnosisTextBox.ReadOnly = true;
            initialDiagnosisTextBox.Size = new Size(338, 112);
            initialDiagnosisTextBox.TabIndex = 10;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.Location = new Point(6, 107);
            symptomsTextBox.Multiline = true;
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.ReadOnly = true;
            symptomsTextBox.Size = new Size(338, 112);
            symptomsTextBox.TabIndex = 9;
            // 
            // orderedTestsLabel
            // 
            orderedTestsLabel.AutoSize = true;
            orderedTestsLabel.Location = new Point(372, 234);
            orderedTestsLabel.Name = "orderedTestsLabel";
            orderedTestsLabel.Size = new Size(98, 19);
            orderedTestsLabel.TabIndex = 8;
            orderedTestsLabel.Text = "Ordered Tests:";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new Point(6, 234);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new Size(107, 19);
            finalDiagnosisLabel.TabIndex = 7;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // intialDIagnosisLabel
            // 
            intialDIagnosisLabel.AutoSize = true;
            intialDIagnosisLabel.Location = new Point(372, 85);
            intialDIagnosisLabel.Name = "intialDIagnosisLabel";
            intialDIagnosisLabel.Size = new Size(113, 19);
            intialDIagnosisLabel.TabIndex = 6;
            intialDIagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new Point(6, 85);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(78, 19);
            symptomsLabel.TabIndex = 5;
            symptomsLabel.Text = "Symptoms:";
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoSize = true;
            bloodPressureLabel.Location = new Point(539, 35);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new Size(104, 19);
            bloodPressureLabel.TabIndex = 4;
            bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new Point(405, 35);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(45, 19);
            pulseLabel.TabIndex = 3;
            pulseLabel.Text = "Pulse:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(222, 35);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(90, 19);
            temperatureLabel.TabIndex = 2;
            temperatureLabel.Text = "Temperature:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(107, 35);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(54, 19);
            heightLabel.TabIndex = 1;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(6, 35);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(58, 19);
            weightLabel.TabIndex = 0;
            weightLabel.Text = "Weight:";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(12, 88);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(90, 19);
            nurseNameLabel.TabIndex = 3;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(219, 88);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(67, 19);
            nurseIdLabel.TabIndex = 4;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // patientInfoLabel
            // 
            patientInfoLabel.AutoSize = true;
            patientInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            patientInfoLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientInfoLabel.Location = new Point(344, 88);
            patientInfoLabel.Name = "patientInfoLabel";
            patientInfoLabel.Size = new Size(56, 19);
            patientInfoLabel.TabIndex = 5;
            patientInfoLabel.Text = "Patient:";
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.FromArgb(255, 255, 242);
            goBackButton.FlatAppearance.BorderSize = 0;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            goBackButton.Location = new Point(312, 564);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(105, 45);
            goBackButton.TabIndex = 6;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // FinalVisitInformationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(761, 633);
            Controls.Add(goBackButton);
            Controls.Add(patientInfoLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(visitInforGroupBox);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "FinalVisitInformationPage";
            Text = "FinalVisitInformationPage";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            visitInforGroupBox.ResumeLayout(false);
            visitInforGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderedTestDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbolPictureBox;
        private Panel healthCareNamePanel;
        private Label healthCareNameLabel;
        private GroupBox visitInforGroupBox;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Label patientInfoLabel;
        private Label orderedTestsLabel;
        private Label finalDiagnosisLabel;
        private Label intialDIagnosisLabel;
        private Label symptomsLabel;
        private Label bloodPressureLabel;
        private Label pulseLabel;
        private Label temperatureLabel;
        private Label heightLabel;
        private Label weightLabel;
        private TextBox finalDiagnosisTextBox;
        private TextBox initialDiagnosisTextBox;
        private TextBox symptomsTextBox;
        private DataGridView orderedTestDataGridView;
        private Button goBackButton;
    }
}