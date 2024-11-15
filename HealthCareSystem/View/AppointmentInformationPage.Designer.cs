namespace HealthCareSystem.View
{
    partial class AppointmentInformationPage
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
            patientLabel = new Label();
            doctorLabel = new Label();
            DateLabel = new Label();
            reasonLabel = new Label();
            patientComboBox = new ComboBox();
            doctorComboBox = new ComboBox();
            apptDateTimePicker = new DateTimePicker();
            reasonTextBox = new TextBox();
            cancelButton = new Button();
            saveButton = new Button();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
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
            healthCareNamePanel.Size = new Size(495, 76);
            healthCareNamePanel.TabIndex = 0;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(7, 23);
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
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            patientLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientLabel.Location = new Point(14, 128);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(65, 21);
            patientLabel.TabIndex = 2;
            patientLabel.Text = "Patient:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            doctorLabel.ForeColor = Color.FromArgb(242, 243, 244);
            doctorLabel.Location = new Point(292, 129);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(66, 21);
            doctorLabel.TabIndex = 3;
            doctorLabel.Text = "Doctor:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            DateLabel.Location = new Point(14, 188);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(93, 21);
            DateLabel.TabIndex = 4;
            DateLabel.Text = "Appt. Date:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            reasonLabel.ForeColor = Color.FromArgb(242, 243, 244);
            reasonLabel.Location = new Point(14, 231);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(67, 21);
            reasonLabel.TabIndex = 5;
            reasonLabel.Text = "Reason:";
            // 
            // patientComboBox
            // 
            patientComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patientComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            patientComboBox.BackColor = Color.FromArgb(242, 243, 244);
            patientComboBox.FormattingEnabled = true;
            patientComboBox.Location = new Point(85, 126);
            patientComboBox.Name = "patientComboBox";
            patientComboBox.Size = new Size(193, 23);
            patientComboBox.TabIndex = 6;
            patientComboBox.TextChanged += patientComboBox_TextChanged;
            // 
            // doctorComboBox
            //
            doctorComboBox.BackColor = Color.FromArgb(242, 243, 244);
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(364, 129);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(193, 23);
            doctorComboBox.TabIndex = 7;
            doctorComboBox.TextChanged += doctorComboBox_TextChanged;
            // 
            // apptDateTimePicker
            // 
            apptDateTimePicker.CalendarMonthBackground = Color.FromArgb(242, 243, 244);
            apptDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            apptDateTimePicker.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            apptDateTimePicker.Format = DateTimePickerFormat.Custom;
            apptDateTimePicker.Location = new Point(113, 188);
            apptDateTimePicker.Name = "apptDateTimePicker";
            apptDateTimePicker.ShowUpDown = true;
            apptDateTimePicker.Size = new Size(148, 23);
            apptDateTimePicker.TabIndex = 8;
            // 
            // reasonTextBox
            // 
            reasonTextBox.BackColor = Color.FromArgb(242, 243, 244);
            reasonTextBox.Font = new Font("Segoe UI", 12F);
            reasonTextBox.Location = new Point(85, 255);
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(472, 137);
            reasonTextBox.TabIndex = 9;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 255, 242);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(193, 405);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(85, 28);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(255, 255, 242);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(316, 405);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(85, 28);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(14, 86);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(90, 19);
            nurseNameLabel.TabIndex = 12;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(237, 86);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(67, 19);
            nurseIdLabel.TabIndex = 13;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // AppointmentInformationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(582, 450);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(reasonTextBox);
            Controls.Add(apptDateTimePicker);
            Controls.Add(doctorComboBox);
            Controls.Add(patientComboBox);
            Controls.Add(reasonLabel);
            Controls.Add(DateLabel);
            Controls.Add(doctorLabel);
            Controls.Add(patientLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Name = "AppointmentInformationPage";
            Text = "Appointment Information";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private PictureBox symbolPictureBox;
        private Label healthCareNameLabel;
        private Label patientLabel;
        private Label doctorLabel;
        private Label DateLabel;
        private Label reasonLabel;
        private ComboBox patientComboBox;
        private ComboBox doctorComboBox;
        private DateTimePicker apptDateTimePicker;
        private TextBox reasonTextBox;
        private Button cancelButton;
        private Button saveButton;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
    }
}