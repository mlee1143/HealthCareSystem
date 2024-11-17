namespace HealthCareSystem.View
{
    partial class TestResultsPage
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
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            doctorNameLabel = new Label();
            doctorIdLabel = new Label();
            patientInfoLabel = new Label();
            labTestDataGrid = new DataGridView();
            lowLabel = new Label();
            highLabel = new Label();
            testDateLabel = new Label();
            testResultLabel = new Label();
            lowTextBox = new TextBox();
            highTextBox = new TextBox();
            testResultTextBox = new TextBox();
            testDateTimePicker = new DateTimePicker();
            saveResultButton = new Button();
            goBackButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            noLowValueCheckBox = new CheckBox();
            noHighValueCheckBox = new CheckBox();
            normalityGroupBox = new GroupBox();
            abnormalRadioButton = new RadioButton();
            normalRadioButton = new RadioButton();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)labTestDataGrid).BeginInit();
            normalityGroupBox.SuspendLayout();
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
            healthCareNamePanel.Size = new Size(894, 76);
            healthCareNamePanel.TabIndex = 1;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(6, 19);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(12, 93);
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
            nurseIdLabel.Location = new Point(289, 93);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(67, 19);
            nurseIdLabel.TabIndex = 3;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            doctorNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            doctorNameLabel.Location = new Point(447, 93);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(96, 19);
            doctorNameLabel.TabIndex = 4;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            doctorIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            doctorIdLabel.Location = new Point(704, 93);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(73, 19);
            doctorIdLabel.TabIndex = 5;
            doctorIdLabel.Text = "Doctor ID:";
            // 
            // patientInfoLabel
            // 
            patientInfoLabel.AutoSize = true;
            patientInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            patientInfoLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientInfoLabel.Location = new Point(12, 148);
            patientInfoLabel.Name = "patientInfoLabel";
            patientInfoLabel.Size = new Size(126, 19);
            patientInfoLabel.TabIndex = 6;
            patientInfoLabel.Text = "Patient's Test Lists:";
            // 
            // labTestDataGrid
            // 
            labTestDataGrid.BackgroundColor = Color.FromArgb(93, 173, 226);
            labTestDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            labTestDataGrid.Location = new Point(12, 180);
            labTestDataGrid.Name = "labTestDataGrid";
            labTestDataGrid.Size = new Size(710, 293);
            labTestDataGrid.TabIndex = 7;
            // 
            // lowLabel
            // 
            lowLabel.AutoSize = true;
            lowLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lowLabel.ForeColor = Color.FromArgb(242, 243, 244);
            lowLabel.Location = new Point(732, 186);
            lowLabel.Name = "lowLabel";
            lowLabel.Size = new Size(29, 15);
            lowLabel.TabIndex = 8;
            lowLabel.Text = "Low";
            // 
            // highLabel
            // 
            highLabel.AutoSize = true;
            highLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            highLabel.ForeColor = Color.FromArgb(242, 243, 244);
            highLabel.Location = new Point(728, 242);
            highLabel.Name = "highLabel";
            highLabel.Size = new Size(33, 15);
            highLabel.TabIndex = 9;
            highLabel.Text = "High";
            // 
            // testDateLabel
            // 
            testDateLabel.AutoSize = true;
            testDateLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            testDateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            testDateLabel.Location = new Point(728, 301);
            testDateLabel.Name = "testDateLabel";
            testDateLabel.Size = new Size(56, 15);
            testDateLabel.TabIndex = 10;
            testDateLabel.Text = "Test Date";
            // 
            // testResultLabel
            // 
            testResultLabel.AutoSize = true;
            testResultLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            testResultLabel.ForeColor = Color.FromArgb(242, 243, 244);
            testResultLabel.Location = new Point(728, 444);
            testResultLabel.Name = "testResultLabel";
            testResultLabel.Size = new Size(63, 15);
            testResultLabel.TabIndex = 12;
            testResultLabel.Text = "Test Result";
            // 
            // lowTextBox
            // 
            lowTextBox.Location = new Point(797, 178);
            lowTextBox.Name = "lowTextBox";
            lowTextBox.Size = new Size(147, 23);
            lowTextBox.TabIndex = 13;
            // 
            // highTextBox
            // 
            highTextBox.Location = new Point(797, 239);
            highTextBox.Name = "highTextBox";
            highTextBox.Size = new Size(147, 23);
            highTextBox.TabIndex = 14;
            // 
            // testResultTextBox
            // 
            testResultTextBox.Location = new Point(797, 436);
            testResultTextBox.Name = "testResultTextBox";
            testResultTextBox.Size = new Size(147, 23);
            testResultTextBox.TabIndex = 16;
            // 
            // testDateTimePicker
            // 
            testDateTimePicker.CalendarMonthBackground = Color.FromArgb(242, 243, 244);
            testDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            testDateTimePicker.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            testDateTimePicker.Format = DateTimePickerFormat.Custom;
            testDateTimePicker.Location = new Point(797, 293);
            testDateTimePicker.Name = "testDateTimePicker";
            testDateTimePicker.ShowUpDown = true;
            testDateTimePicker.Size = new Size(147, 23);
            testDateTimePicker.TabIndex = 17;
            // 
            // saveResultButton
            // 
            saveResultButton.BackColor = Color.FromArgb(255, 255, 242);
            saveResultButton.FlatAppearance.BorderSize = 0;
            saveResultButton.FlatStyle = FlatStyle.Flat;
            saveResultButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            saveResultButton.Location = new Point(832, 474);
            saveResultButton.Name = "saveResultButton";
            saveResultButton.Size = new Size(80, 26);
            saveResultButton.TabIndex = 18;
            saveResultButton.Text = "Save";
            saveResultButton.UseVisualStyleBackColor = true;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.FromArgb(255, 255, 242);
            goBackButton.FlatAppearance.BorderSize = 0;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            goBackButton.Location = new Point(415, 493);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(90, 30);
            goBackButton.TabIndex = 19;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // noLowValueCheckBox
            // 
            noLowValueCheckBox.AutoSize = true;
            noLowValueCheckBox.ForeColor = Color.FromArgb(242, 243, 244);
            noLowValueCheckBox.Location = new Point(797, 207);
            noLowValueCheckBox.Name = "noLowValueCheckBox";
            noLowValueCheckBox.Size = new Size(98, 19);
            noLowValueCheckBox.TabIndex = 20;
            noLowValueCheckBox.Text = "No Low Value";
            noLowValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // noHighValueCheckBox
            // 
            noHighValueCheckBox.AutoSize = true;
            noHighValueCheckBox.ForeColor = Color.FromArgb(242, 243, 244);
            noHighValueCheckBox.Location = new Point(797, 268);
            noHighValueCheckBox.Name = "noHighValueCheckBox";
            noHighValueCheckBox.Size = new Size(102, 19);
            noHighValueCheckBox.TabIndex = 21;
            noHighValueCheckBox.Text = "No High Value";
            noHighValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // normalityGroupBox
            // 
            normalityGroupBox.Controls.Add(normalRadioButton);
            normalityGroupBox.Controls.Add(abnormalRadioButton);
            normalityGroupBox.ForeColor = Color.FromArgb(242, 243, 244);
            normalityGroupBox.Location = new Point(797, 332);
            normalityGroupBox.Name = "normalityGroupBox";
            normalityGroupBox.Size = new Size(147, 88);
            normalityGroupBox.TabIndex = 22;
            normalityGroupBox.TabStop = false;
            normalityGroupBox.Text = "Normality";
            // 
            // abnormalRadioButton
            // 
            abnormalRadioButton.AutoSize = true;
            abnormalRadioButton.Location = new Point(6, 22);
            abnormalRadioButton.Name = "abnormalRadioButton";
            abnormalRadioButton.Size = new Size(78, 19);
            abnormalRadioButton.TabIndex = 0;
            abnormalRadioButton.TabStop = true;
            abnormalRadioButton.Text = "Abnormal";
            abnormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            normalRadioButton.AutoSize = true;
            normalRadioButton.Location = new Point(6, 56);
            normalRadioButton.Name = "normalRadioButton";
            normalRadioButton.Size = new Size(65, 19);
            normalRadioButton.TabIndex = 1;
            normalRadioButton.TabStop = true;
            normalRadioButton.Text = "Normal";
            normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            errorLabel.Location = new Point(732, 148);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(76, 19);
            errorLabel.TabIndex = 23;
            errorLabel.Text = "Error Label";
            // 
            // TestResultsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(980, 535);
            Controls.Add(errorLabel);
            Controls.Add(normalityGroupBox);
            Controls.Add(noHighValueCheckBox);
            Controls.Add(noLowValueCheckBox);
            Controls.Add(goBackButton);
            Controls.Add(saveResultButton);
            Controls.Add(testDateTimePicker);
            Controls.Add(testResultTextBox);
            Controls.Add(highTextBox);
            Controls.Add(lowTextBox);
            Controls.Add(testResultLabel);
            Controls.Add(testDateLabel);
            Controls.Add(highLabel);
            Controls.Add(lowLabel);
            Controls.Add(labTestDataGrid);
            Controls.Add(patientInfoLabel);
            Controls.Add(doctorIdLabel);
            Controls.Add(doctorNameLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "TestResultsPage";
            Text = "Test Results";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)labTestDataGrid).EndInit();
            normalityGroupBox.ResumeLayout(false);
            normalityGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbolPictureBox;
        private Panel healthCareNamePanel;
        private Label healthCareNameLabel;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Label doctorNameLabel;
        private Label doctorIdLabel;
        private Label patientInfoLabel;
        private DataGridView labTestDataGrid;
        private Label lowLabel;
        private Label highLabel;
        private Label testDateLabel;
        private Label testResultLabel;
        private TextBox lowTextBox;
        private TextBox highTextBox;
        private TextBox testResultTextBox;
        private DateTimePicker testDateTimePicker;
        private Button saveResultButton;
        private Button goBackButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox noLowValueCheckBox;
        private CheckBox noHighValueCheckBox;
        private GroupBox normalityGroupBox;
        private RadioButton normalRadioButton;
        private RadioButton abnormalRadioButton;
        private Label errorLabel;
    }
}