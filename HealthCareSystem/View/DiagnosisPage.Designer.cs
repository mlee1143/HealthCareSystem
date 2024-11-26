namespace HealthCareSystem.View
{
    partial class DiagnosisPage
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
            healthCareNameLabel = new Label();
            symbolPictureBox = new PictureBox();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            patientInfoLabel = new Label();
            initialDiagnosisLabel = new Label();
            finalDiagnosisLabel = new Label();
            initialDiagnosisTextBox = new TextBox();
            finalDiagnosisTextBox = new TextBox();
            submitButton = new Button();
            cancelButton = new Button();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(87, 0);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(314, 76);
            healthCareNamePanel.TabIndex = 0;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(6, 20);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(0, 0);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 1;
            symbolPictureBox.TabStop = false;
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(22, 92);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(90, 19);
            nurseNameLabel.TabIndex = 2;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(166, 92);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(67, 19);
            nurseIdLabel.TabIndex = 3;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // patientInfoLabel
            // 
            patientInfoLabel.AutoSize = true;
            patientInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            patientInfoLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientInfoLabel.Location = new Point(22, 126);
            patientInfoLabel.Name = "patientInfoLabel";
            patientInfoLabel.Size = new Size(56, 19);
            patientInfoLabel.TabIndex = 4;
            patientInfoLabel.Text = "Patient:";
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            initialDiagnosisLabel.ForeColor = Color.FromArgb(242, 243, 244);
            initialDiagnosisLabel.Location = new Point(22, 163);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new Size(106, 19);
            initialDiagnosisLabel.TabIndex = 5;
            initialDiagnosisLabel.Text = "Intial Diagnosis";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            finalDiagnosisLabel.ForeColor = Color.FromArgb(242, 243, 244);
            finalDiagnosisLabel.Location = new Point(22, 307);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new Size(104, 19);
            finalDiagnosisLabel.TabIndex = 6;
            finalDiagnosisLabel.Text = "Final Diagnosis";
            // 
            // initialDiagnosisTextBox
            // 
            initialDiagnosisTextBox.BackColor = Color.FromArgb(242, 243, 244);
            initialDiagnosisTextBox.Location = new Point(22, 185);
            initialDiagnosisTextBox.Multiline = true;
            initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            initialDiagnosisTextBox.Size = new Size(350, 110);
            initialDiagnosisTextBox.TabIndex = 7;
            // 
            // finalDiagnosisTextBox
            // 
            finalDiagnosisTextBox.BackColor = Color.FromArgb(242, 243, 244);
            finalDiagnosisTextBox.Location = new Point(22, 329);
            finalDiagnosisTextBox.Multiline = true;
            finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            finalDiagnosisTextBox.Size = new Size(350, 110);
            finalDiagnosisTextBox.TabIndex = 8;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 255, 242);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            submitButton.Location = new Point(93, 463);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(90, 32);
            submitButton.TabIndex = 9;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 255, 242);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cancelButton.Location = new Point(206, 463);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 32);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // DiagnosisPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(400, 527);
            Controls.Add(cancelButton);
            Controls.Add(submitButton);
            Controls.Add(finalDiagnosisTextBox);
            Controls.Add(initialDiagnosisTextBox);
            Controls.Add(finalDiagnosisLabel);
            Controls.Add(initialDiagnosisLabel);
            Controls.Add(patientInfoLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Name = "DiagnosisPage";
            Text = "Diagnosis";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private PictureBox symbolPictureBox;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Label patientInfoLabel;
        private Label initialDiagnosisLabel;
        private Label finalDiagnosisLabel;
        private TextBox initialDiagnosisTextBox;
        private TextBox finalDiagnosisTextBox;
        private Label healthCareNameLabel;
        private Button submitButton;
        private Button cancelButton;
    }
}