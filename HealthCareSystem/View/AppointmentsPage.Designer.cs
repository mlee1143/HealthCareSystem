namespace HealthCareSystem.View
{
    partial class AppointmentsPage
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
            appointmentsButtonPanel = new Panel();
            searchButton = new Button();
            checkUpInformationButton = new Button();
            backToMainButton = new Button();
            editAppointment = new Button();
            newAppointmentButton = new Button();
            appointmentsDataGridView = new DataGridView();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            appointmentsLabel = new Label();
            errorLabel = new Label();
            searchGroupBox = new GroupBox();
            appointmentSearchButton = new Button();
            lnameTextBox = new TextBox();
            fnameSearchTextBox = new TextBox();
            searchDatePicker = new DateTimePicker();
            bothRadioButton = new RadioButton();
            birthdateDateRadioButton = new RadioButton();
            nameRadioButton = new RadioButton();
            clearButton = new Button();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            appointmentsButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            searchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(87, 0);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(772, 79);
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
            // appointmentsButtonPanel
            // 
            appointmentsButtonPanel.BackColor = Color.FromArgb(93, 109, 126);
            appointmentsButtonPanel.Controls.Add(searchButton);
            appointmentsButtonPanel.Controls.Add(checkUpInformationButton);
            appointmentsButtonPanel.Controls.Add(backToMainButton);
            appointmentsButtonPanel.Controls.Add(editAppointment);
            appointmentsButtonPanel.Controls.Add(newAppointmentButton);
            appointmentsButtonPanel.Location = new Point(0, 82);
            appointmentsButtonPanel.Name = "appointmentsButtonPanel";
            appointmentsButtonPanel.Size = new Size(160, 451);
            appointmentsButtonPanel.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(255, 255, 244);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(0, 147);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(160, 49);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search for Appt.";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // checkUpInformationButton
            // 
            checkUpInformationButton.BackColor = Color.FromArgb(255, 255, 244);
            checkUpInformationButton.FlatAppearance.BorderSize = 0;
            checkUpInformationButton.FlatStyle = FlatStyle.Flat;
            checkUpInformationButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            checkUpInformationButton.ForeColor = Color.Black;
            checkUpInformationButton.Location = new Point(0, 98);
            checkUpInformationButton.Name = "checkUpInformationButton";
            checkUpInformationButton.Size = new Size(160, 49);
            checkUpInformationButton.TabIndex = 10;
            checkUpInformationButton.Text = "Check-Up Info.";
            checkUpInformationButton.UseVisualStyleBackColor = false;
            checkUpInformationButton.Click += visitInformationButton_Click;
            // 
            // backToMainButton
            // 
            backToMainButton.BackColor = Color.FromArgb(255, 255, 242);
            backToMainButton.FlatAppearance.BorderSize = 0;
            backToMainButton.FlatStyle = FlatStyle.Flat;
            backToMainButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            backToMainButton.ForeColor = Color.Black;
            backToMainButton.Location = new Point(0, 196);
            backToMainButton.Name = "backToMainButton";
            backToMainButton.Size = new Size(160, 49);
            backToMainButton.TabIndex = 2;
            backToMainButton.Text = "Back To Main";
            backToMainButton.UseVisualStyleBackColor = true;
            backToMainButton.Click += backToMainButton_Click;
            // 
            // editAppointment
            // 
            editAppointment.BackColor = Color.FromArgb(255, 255, 242);
            editAppointment.FlatAppearance.BorderSize = 0;
            editAppointment.FlatStyle = FlatStyle.Flat;
            editAppointment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            editAppointment.ForeColor = Color.Black;
            editAppointment.Location = new Point(0, 49);
            editAppointment.Name = "editAppointment";
            editAppointment.Size = new Size(160, 49);
            editAppointment.TabIndex = 1;
            editAppointment.Text = "Edit Appointment";
            editAppointment.UseVisualStyleBackColor = true;
            editAppointment.Click += editAppointment_Click;
            // 
            // newAppointmentButton
            // 
            newAppointmentButton.BackColor = Color.FromArgb(255, 255, 242);
            newAppointmentButton.FlatAppearance.BorderSize = 0;
            newAppointmentButton.FlatStyle = FlatStyle.Flat;
            newAppointmentButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            newAppointmentButton.ForeColor = Color.Black;
            newAppointmentButton.Location = new Point(0, 0);
            newAppointmentButton.Name = "newAppointmentButton";
            newAppointmentButton.Size = new Size(160, 49);
            newAppointmentButton.TabIndex = 0;
            newAppointmentButton.Text = "New Appointment";
            newAppointmentButton.UseVisualStyleBackColor = true;
            newAppointmentButton.Click += newAppointmentButton_Click;
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentsDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDataGridView.Location = new Point(166, 238);
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.ReadOnly = true;
            appointmentsDataGridView.Size = new Size(681, 276);
            appointmentsDataGridView.TabIndex = 3;
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(166, 79);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(104, 21);
            nurseNameLabel.TabIndex = 4;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(349, 79);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(77, 21);
            nurseIdLabel.TabIndex = 5;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.AutoSize = true;
            appointmentsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            appointmentsLabel.ForeColor = Color.FromArgb(242, 243, 244);
            appointmentsLabel.Location = new Point(166, 214);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(115, 21);
            appointmentsLabel.TabIndex = 6;
            appointmentsLabel.Text = "Appointments";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(349, 214);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(52, 21);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "Error: ";
            errorLabel.Visible = false;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(clearButton);
            searchGroupBox.Controls.Add(appointmentSearchButton);
            searchGroupBox.Controls.Add(lnameTextBox);
            searchGroupBox.Controls.Add(fnameSearchTextBox);
            searchGroupBox.Controls.Add(searchDatePicker);
            searchGroupBox.Controls.Add(bothRadioButton);
            searchGroupBox.Controls.Add(birthdateDateRadioButton);
            searchGroupBox.Controls.Add(nameRadioButton);
            searchGroupBox.ForeColor = Color.FromArgb(255, 255, 244);
            searchGroupBox.Location = new Point(166, 82);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(538, 133);
            searchGroupBox.TabIndex = 9;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search for appointment:";
            searchGroupBox.Visible = false;
            // 
            // appointmentSearchButton
            // 
            appointmentSearchButton.BackColor = Color.FromArgb(255, 255, 244);
            appointmentSearchButton.Enabled = false;
            appointmentSearchButton.FlatAppearance.BorderSize = 0;
            appointmentSearchButton.FlatStyle = FlatStyle.Flat;
            appointmentSearchButton.ForeColor = Color.Black;
            appointmentSearchButton.Location = new Point(185, 98);
            appointmentSearchButton.Name = "appointmentSearchButton";
            appointmentSearchButton.Size = new Size(75, 23);
            appointmentSearchButton.TabIndex = 6;
            appointmentSearchButton.Text = "Search";
            appointmentSearchButton.UseVisualStyleBackColor = false;
            appointmentSearchButton.Click += appointmentSearchButton_Click;
            // 
            // lnameTextBox
            // 
            lnameTextBox.BackColor = Color.FromArgb(255, 255, 244);
            lnameTextBox.Location = new Point(23, 67);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.PlaceholderText = "Last Name";
            lnameTextBox.Size = new Size(152, 23);
            lnameTextBox.TabIndex = 5;
            // 
            // fnameSearchTextBox
            // 
            fnameSearchTextBox.BackColor = Color.FromArgb(255, 255, 244);
            fnameSearchTextBox.Location = new Point(23, 28);
            fnameSearchTextBox.Name = "fnameSearchTextBox";
            fnameSearchTextBox.PlaceholderText = "First Name";
            fnameSearchTextBox.Size = new Size(152, 23);
            fnameSearchTextBox.TabIndex = 4;
            // 
            // searchDatePicker
            // 
            searchDatePicker.CustomFormat = "";
            searchDatePicker.ImeMode = ImeMode.Off;
            searchDatePicker.Location = new Point(223, 41);
            searchDatePicker.Name = "searchDatePicker";
            searchDatePicker.Size = new Size(192, 23);
            searchDatePicker.TabIndex = 3;
            // 
            // bothRadioButton
            // 
            bothRadioButton.AutoSize = true;
            bothRadioButton.Location = new Point(450, 72);
            bothRadioButton.Name = "bothRadioButton";
            bothRadioButton.Size = new Size(50, 19);
            bothRadioButton.TabIndex = 2;
            bothRadioButton.TabStop = true;
            bothRadioButton.Text = "Both";
            bothRadioButton.UseVisualStyleBackColor = true;
            bothRadioButton.CheckedChanged += bothRadioButton_CheckedChanged;
            // 
            // birthdateDateRadioButton
            // 
            birthdateDateRadioButton.AutoSize = true;
            birthdateDateRadioButton.Location = new Point(450, 47);
            birthdateDateRadioButton.Name = "birthdateDateRadioButton";
            birthdateDateRadioButton.Size = new Size(73, 19);
            birthdateDateRadioButton.TabIndex = 1;
            birthdateDateRadioButton.TabStop = true;
            birthdateDateRadioButton.Text = "Birthdate";
            birthdateDateRadioButton.UseVisualStyleBackColor = true;
            birthdateDateRadioButton.CheckedChanged += birthdateDateRadioButton_CheckedChanged;
            // 
            // nameRadioButton
            // 
            nameRadioButton.AutoSize = true;
            nameRadioButton.Location = new Point(450, 22);
            nameRadioButton.Name = "nameRadioButton";
            nameRadioButton.Size = new Size(57, 19);
            nameRadioButton.TabIndex = 0;
            nameRadioButton.TabStop = true;
            nameRadioButton.Text = "Name";
            nameRadioButton.UseVisualStyleBackColor = true;
            nameRadioButton.CheckedChanged += nameRadioButton_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(255, 255, 244);
            clearButton.Enabled = false;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.Black;
            clearButton.Location = new Point(320, 98);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // AppointmentsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(859, 526);
            Controls.Add(searchGroupBox);
            Controls.Add(errorLabel);
            Controls.Add(appointmentsLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(appointmentsDataGridView);
            Controls.Add(appointmentsButtonPanel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Name = "AppointmentsPage";
            Text = "Appointments";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            appointmentsButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private PictureBox symbolPictureBox;
        private Panel appointmentsButtonPanel;
        private DataGridView appointmentsDataGridView;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Label appointmentsLabel;
        private Label healthCareNameLabel;
        private Button backToMainButton;
        private Button editAppointment;
        private Button newAppointmentButton;
        private Label errorLabel;
        private Button checkUpInformationButton;
        private GroupBox searchGroupBox;
        private Button appointmentSearchButton;
        private TextBox lnameTextBox;
        private TextBox fnameSearchTextBox;
        private DateTimePicker searchDatePicker;
        private RadioButton bothRadioButton;
        private RadioButton birthdateDateRadioButton;
        private RadioButton nameRadioButton;
        private Button searchButton;
        private Button clearButton;
    }
}