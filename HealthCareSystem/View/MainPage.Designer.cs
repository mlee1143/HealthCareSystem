namespace HealthCareSystem.View
{
    partial class MainPage
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
            welcomeNameLabel = new Label();
            buttonsPanel = new Panel();
            visitInformationButton = new Button();
            searchButton = new Button();
            editPatientButton = new Button();
            logoutButton = new Button();
            registerPatientButton = new Button();
            genericNursePictureBox = new PictureBox();
            idLabel = new Label();
            registeredPatiensDataGridView = new DataGridView();
            patientsLabel = new Label();
            errormessageLabel = new Label();
            searchGroupBox = new GroupBox();
            patientSearchButton = new Button();
            lnameTextBox = new TextBox();
            fnameSearchTextBox = new TextBox();
            searchDatePicker = new DateTimePicker();
            bothRadioButton = new RadioButton();
            birthdateRadioButton = new RadioButton();
            nameRadioButton = new RadioButton();
            routineGroupBox = new GroupBox();
            symptomsLabel = new Label();
            routinePtNameLabel = new Label();
            routinePtIDLabel = new Label();
            symptomsTextBox = new RichTextBox();
            temperatureTextBox = new TextBox();
            temperatureLabel = new Label();
            pulseTextBox = new TextBox();
            pulseLabel = new Label();
            bloodpressureTextBox = new TextBox();
            bloodpressureLabel = new Label();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genericNursePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registeredPatiensDataGridView).BeginInit();
            searchGroupBox.SuspendLayout();
            routineGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(83, -1);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(700, 76);
            healthCareNamePanel.TabIndex = 0;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(8, 19);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 2;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(-2, -1);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 1;
            symbolPictureBox.TabStop = false;
            // 
            // welcomeNameLabel
            // 
            welcomeNameLabel.AutoSize = true;
            welcomeNameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            welcomeNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            welcomeNameLabel.Location = new Point(180, 87);
            welcomeNameLabel.Name = "welcomeNameLabel";
            welcomeNameLabel.Size = new Size(92, 25);
            welcomeNameLabel.TabIndex = 2;
            welcomeNameLabel.Text = "Welcome";
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.FromArgb(93, 109, 126);
            buttonsPanel.Controls.Add(visitInformationButton);
            buttonsPanel.Controls.Add(searchButton);
            buttonsPanel.Controls.Add(editPatientButton);
            buttonsPanel.Controls.Add(logoutButton);
            buttonsPanel.Controls.Add(registerPatientButton);
            buttonsPanel.Controls.Add(genericNursePictureBox);
            buttonsPanel.Location = new Point(0, 76);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(174, 541);
            buttonsPanel.TabIndex = 3;
            // 
            // visitInformationButton
            // 
            visitInformationButton.BackColor = Color.FromArgb(255, 255, 244);
            visitInformationButton.FlatAppearance.BorderSize = 0;
            visitInformationButton.FlatStyle = FlatStyle.Flat;
            visitInformationButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            visitInformationButton.Location = new Point(0, 305);
            visitInformationButton.Name = "visitInformationButton";
            visitInformationButton.Size = new Size(176, 49);
            visitInformationButton.TabIndex = 9;
            visitInformationButton.Text = "Visit Information";
            visitInformationButton.UseVisualStyleBackColor = false;
            visitInformationButton.Click += visitInformationButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(255, 255, 242);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(0, 255);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(174, 61);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search for Patient";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // editPatientButton
            // 
            editPatientButton.BackColor = Color.FromArgb(255, 255, 242);
            editPatientButton.FlatAppearance.BorderSize = 0;
            editPatientButton.FlatStyle = FlatStyle.Flat;
            editPatientButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPatientButton.ForeColor = Color.Black;
            editPatientButton.Location = new Point(0, 209);
            editPatientButton.Name = "editPatientButton";
            editPatientButton.Size = new Size(174, 49);
            editPatientButton.TabIndex = 7;
            editPatientButton.Text = "Edit Patient";
            editPatientButton.UseVisualStyleBackColor = true;
            editPatientButton.Click += editPatientButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(255, 255, 242);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            logoutButton.ForeColor = Color.Black;
            logoutButton.Location = new Point(0, 349);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(174, 49);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // registerPatientButton
            // 
            registerPatientButton.BackColor = Color.FromArgb(255, 255, 242);
            registerPatientButton.FlatAppearance.BorderSize = 0;
            registerPatientButton.FlatStyle = FlatStyle.Flat;
            registerPatientButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            registerPatientButton.ForeColor = Color.Black;
            registerPatientButton.Location = new Point(0, 160);
            registerPatientButton.Name = "registerPatientButton";
            registerPatientButton.Size = new Size(174, 49);
            registerPatientButton.TabIndex = 5;
            registerPatientButton.Text = "Register Patient";
            registerPatientButton.UseVisualStyleBackColor = true;
            registerPatientButton.Click += registerPatientButton_Click;
            // 
            // genericNursePictureBox
            // 
            genericNursePictureBox.Image = Properties.Resources.nurseSymbol;
            genericNursePictureBox.Location = new Point(0, 0);
            genericNursePictureBox.Name = "genericNursePictureBox";
            genericNursePictureBox.Size = new Size(174, 160);
            genericNursePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            genericNursePictureBox.TabIndex = 4;
            genericNursePictureBox.TabStop = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            idLabel.ForeColor = Color.FromArgb(242, 243, 244);
            idLabel.Location = new Point(180, 126);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(37, 25);
            idLabel.TabIndex = 4;
            idLabel.Text = "ID:";
            // 
            // registeredPatiensDataGridView
            // 
            registeredPatiensDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registeredPatiensDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            registeredPatiensDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registeredPatiensDataGridView.Location = new Point(180, 239);
            registeredPatiensDataGridView.Name = "registeredPatiensDataGridView";
            registeredPatiensDataGridView.Size = new Size(595, 364);
            registeredPatiensDataGridView.TabIndex = 5;
            // 
            // patientsLabel
            // 
            patientsLabel.AutoSize = true;
            patientsLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            patientsLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientsLabel.Location = new Point(180, 211);
            patientsLabel.Name = "patientsLabel";
            patientsLabel.Size = new Size(175, 25);
            patientsLabel.TabIndex = 6;
            patientsLabel.Text = "Registered Patients";
            // 
            // errormessageLabel
            // 
            errormessageLabel.AutoSize = true;
            errormessageLabel.BackColor = Color.FromArgb(244, 244, 243);
            errormessageLabel.ForeColor = Color.Red;
            errormessageLabel.Location = new Point(389, 219);
            errormessageLabel.Name = "errormessageLabel";
            errormessageLabel.Size = new Size(35, 15);
            errormessageLabel.TabIndex = 7;
            errormessageLabel.Text = "Error:";
            errormessageLabel.Visible = false;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(patientSearchButton);
            searchGroupBox.Controls.Add(lnameTextBox);
            searchGroupBox.Controls.Add(fnameSearchTextBox);
            searchGroupBox.Controls.Add(searchDatePicker);
            searchGroupBox.Controls.Add(bothRadioButton);
            searchGroupBox.Controls.Add(birthdateRadioButton);
            searchGroupBox.Controls.Add(nameRadioButton);
            searchGroupBox.ForeColor = Color.FromArgb(255, 255, 244);
            searchGroupBox.Location = new Point(180, 87);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(587, 121);
            searchGroupBox.TabIndex = 8;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search for patient:";
            searchGroupBox.Visible = false;
            // 
            // patientSearchButton
            // 
            patientSearchButton.BackColor = Color.FromArgb(255, 255, 244);
            patientSearchButton.FlatAppearance.BorderSize = 0;
            patientSearchButton.FlatStyle = FlatStyle.Flat;
            patientSearchButton.ForeColor = Color.Black;
            patientSearchButton.Location = new Point(253, 92);
            patientSearchButton.Name = "patientSearchButton";
            patientSearchButton.Size = new Size(75, 23);
            patientSearchButton.TabIndex = 6;
            patientSearchButton.Text = "Search";
            patientSearchButton.UseVisualStyleBackColor = false;
            patientSearchButton.Click += patientSearchButton_Click;
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
            bothRadioButton.Location = new Point(473, 80);
            bothRadioButton.Name = "bothRadioButton";
            bothRadioButton.Size = new Size(50, 19);
            bothRadioButton.TabIndex = 2;
            bothRadioButton.TabStop = true;
            bothRadioButton.Text = "Both";
            bothRadioButton.UseVisualStyleBackColor = true;
            bothRadioButton.CheckedChanged += bothRadioButton_CheckedChanged;
            // 
            // birthdateRadioButton
            // 
            birthdateRadioButton.AutoSize = true;
            birthdateRadioButton.Location = new Point(473, 52);
            birthdateRadioButton.Name = "birthdateRadioButton";
            birthdateRadioButton.Size = new Size(73, 19);
            birthdateRadioButton.TabIndex = 1;
            birthdateRadioButton.TabStop = true;
            birthdateRadioButton.Text = "Birthdate";
            birthdateRadioButton.UseVisualStyleBackColor = true;
            birthdateRadioButton.CheckedChanged += birthdateRadioButton_CheckedChanged;
            // 
            // nameRadioButton
            // 
            nameRadioButton.AutoSize = true;
            nameRadioButton.Location = new Point(473, 22);
            nameRadioButton.Name = "nameRadioButton";
            nameRadioButton.Size = new Size(57, 19);
            nameRadioButton.TabIndex = 0;
            nameRadioButton.TabStop = true;
            nameRadioButton.Text = "Name";
            nameRadioButton.UseVisualStyleBackColor = true;
            nameRadioButton.Click += nameRadioButton_Click;
            // 
            // routineGroupBox
            // 
            routineGroupBox.Controls.Add(symptomsLabel);
            routineGroupBox.Controls.Add(routinePtNameLabel);
            routineGroupBox.Controls.Add(routinePtIDLabel);
            routineGroupBox.Controls.Add(symptomsTextBox);
            routineGroupBox.Controls.Add(temperatureTextBox);
            routineGroupBox.Controls.Add(temperatureLabel);
            routineGroupBox.Controls.Add(pulseTextBox);
            routineGroupBox.Controls.Add(pulseLabel);
            routineGroupBox.Controls.Add(bloodpressureTextBox);
            routineGroupBox.Controls.Add(bloodpressureLabel);
            routineGroupBox.Enabled = false;
            routineGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routineGroupBox.ForeColor = Color.FromArgb(255, 255, 244);
            routineGroupBox.Location = new Point(182, 285);
            routineGroupBox.Name = "routineGroupBox";
            routineGroupBox.Size = new Size(593, 257);
            routineGroupBox.TabIndex = 9;
            routineGroupBox.TabStop = false;
            routineGroupBox.Text = "Routine Check-Up";
            routineGroupBox.Visible = false;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new Point(41, 133);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(69, 17);
            symptomsLabel.TabIndex = 9;
            symptomsLabel.Text = "Symptoms";
            // 
            // routinePtNameLabel
            // 
            routinePtNameLabel.AutoSize = true;
            routinePtNameLabel.Location = new Point(112, 37);
            routinePtNameLabel.Name = "routinePtNameLabel";
            routinePtNameLabel.Size = new Size(61, 17);
            routinePtNameLabel.TabIndex = 8;
            routinePtNameLabel.Text = "Pt Name:";
            // 
            // routinePtIDLabel
            // 
            routinePtIDLabel.AutoSize = true;
            routinePtIDLabel.Location = new Point(21, 37);
            routinePtIDLabel.Name = "routinePtIDLabel";
            routinePtIDLabel.Size = new Size(38, 17);
            routinePtIDLabel.TabIndex = 7;
            routinePtIDLabel.Text = "Pt ID:";
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BackColor = Color.FromArgb(255, 255, 242);
            symptomsTextBox.ForeColor = Color.Black;
            symptomsTextBox.Location = new Point(38, 153);
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(506, 81);
            symptomsTextBox.TabIndex = 6;
            symptomsTextBox.Text = "";
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.BackColor = Color.FromArgb(255, 255, 242);
            temperatureTextBox.Location = new Point(439, 96);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(52, 25);
            temperatureTextBox.TabIndex = 5;
            temperatureTextBox.TextChanged += temperatureTextBox_TextChanged;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(439, 76);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(82, 17);
            temperatureLabel.TabIndex = 4;
            temperatureLabel.Text = "Temperature";
            // 
            // pulseTextBox
            // 
            pulseTextBox.BackColor = Color.FromArgb(255, 255, 242);
            pulseTextBox.Location = new Point(260, 96);
            pulseTextBox.Name = "pulseTextBox";
            pulseTextBox.Size = new Size(66, 25);
            pulseTextBox.TabIndex = 3;
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new Point(260, 76);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(38, 17);
            pulseLabel.TabIndex = 2;
            pulseLabel.Text = "Pulse";
            // 
            // bloodpressureTextBox
            // 
            bloodpressureTextBox.BackColor = Color.FromArgb(255, 255, 242);
            bloodpressureTextBox.Location = new Point(76, 96);
            bloodpressureTextBox.Name = "bloodpressureTextBox";
            bloodpressureTextBox.Size = new Size(69, 25);
            bloodpressureTextBox.TabIndex = 1;
            // 
            // bloodpressureLabel
            // 
            bloodpressureLabel.AutoSize = true;
            bloodpressureLabel.Location = new Point(76, 76);
            bloodpressureLabel.Name = "bloodpressureLabel";
            bloodpressureLabel.Size = new Size(96, 17);
            bloodpressureLabel.TabIndex = 0;
            bloodpressureLabel.Text = "Blood Pressure";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(779, 615);
            Controls.Add(routineGroupBox);
            Controls.Add(searchGroupBox);
            Controls.Add(errormessageLabel);
            Controls.Add(patientsLabel);
            Controls.Add(registeredPatiensDataGridView);
            Controls.Add(idLabel);
            Controls.Add(buttonsPanel);
            Controls.Add(welcomeNameLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Name = "MainPage";
            Text = "MainPage";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)genericNursePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)registeredPatiensDataGridView).EndInit();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            routineGroupBox.ResumeLayout(false);
            routineGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private PictureBox symbolPictureBox;
        private Label healthCareNameLabel;
        private Label welcomeNameLabel;
        private Panel buttonsPanel;
        private PictureBox genericNursePictureBox;
        private Label idLabel;
        private DataGridView registeredPatiensDataGridView;
        private Label patientsLabel;
        private Button logoutButton;
        private Button registerPatientButton;
        private Button editPatientButton;
        private Label errormessageLabel;
        private Button searchButton;
        private GroupBox searchGroupBox;
        private RadioButton nameRadioButton;
        private RadioButton birthdateRadioButton;
        private DateTimePicker searchDatePicker;
        private RadioButton bothRadioButton;
        private Button patientSearchButton;
        private TextBox lnameTextBox;
        private TextBox fnameSearchTextBox;
        private Button visitInformationButton;
        private GroupBox routineGroupBox;
        private TextBox bloodpressureTextBox;
        private Label bloodpressureLabel;
        private TextBox pulseTextBox;
        private Label pulseLabel;
        private Label temperatureLabel;
        private RichTextBox symptomsTextBox;
        private TextBox temperatureTextBox;
        private Label routinePtNameLabel;
        private Label routinePtIDLabel;
        private Label symptomsLabel;
    }
}