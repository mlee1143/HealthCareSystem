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
            visitsButton = new Button();
            searchButton = new Button();
            appointmentsButton = new Button();
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
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genericNursePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registeredPatiensDataGridView).BeginInit();
            searchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(83, 0);
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
            symbolPictureBox.Location = new Point(0, 0);
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
            buttonsPanel.Controls.Add(visitsButton);
            buttonsPanel.Controls.Add(searchButton);
            buttonsPanel.Controls.Add(appointmentsButton);
            buttonsPanel.Controls.Add(editPatientButton);
            buttonsPanel.Controls.Add(logoutButton);
            buttonsPanel.Controls.Add(registerPatientButton);
            buttonsPanel.Controls.Add(genericNursePictureBox);
            buttonsPanel.Location = new Point(0, 76);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(174, 511);
            buttonsPanel.TabIndex = 3;
            // 
            // visitsButton
            // 
            visitsButton.BackColor = Color.FromArgb(255, 255, 242);
            visitsButton.FlatAppearance.BorderSize = 0;
            visitsButton.FlatStyle = FlatStyle.Flat;
            visitsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            visitsButton.Location = new Point(0, 354);
            visitsButton.Name = "visitsButton";
            visitsButton.Size = new Size(174, 49);
            visitsButton.TabIndex = 9;
            visitsButton.Text = "Visits with Check-up Completed";
            visitsButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(255, 255, 242);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(0, 305);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(174, 49);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search for Patient";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // appointmentsButton
            // 
            appointmentsButton.BackColor = Color.FromArgb(255, 255, 242);
            appointmentsButton.FlatAppearance.BorderSize = 0;
            appointmentsButton.FlatStyle = FlatStyle.Flat;
            appointmentsButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            appointmentsButton.ForeColor = Color.Black;
            appointmentsButton.Location = new Point(0, 257);
            appointmentsButton.Name = "appointmentsButton";
            appointmentsButton.Size = new Size(174, 49);
            appointmentsButton.TabIndex = 8;
            appointmentsButton.Text = "Appointments";
            appointmentsButton.UseVisualStyleBackColor = true;
            appointmentsButton.Click += appointmentsButton_Click;
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
            logoutButton.Location = new Point(0, 403);
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
            registeredPatiensDataGridView.RowHeadersWidth = 62;
            registeredPatiensDataGridView.Size = new Size(595, 334);
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
            searchGroupBox.Location = new Point(180, 82);
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
            patientSearchButton.Enabled = false;
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
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(779, 586);
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
        private Button appointmentsButton;
        private Button visitsButton;
    }
}