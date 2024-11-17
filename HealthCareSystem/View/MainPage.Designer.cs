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
            button1 = new Button();
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
            healthCareNamePanel.Location = new Point(119, 0);
            healthCareNamePanel.Margin = new Padding(4, 5, 4, 5);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(1000, 127);
            healthCareNamePanel.TabIndex = 0;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(11, 32);
            healthCareNameLabel.Margin = new Padding(4, 0, 4, 0);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(444, 48);
            healthCareNameLabel.TabIndex = 2;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(0, 0);
            symbolPictureBox.Margin = new Padding(4, 5, 4, 5);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(124, 127);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 1;
            symbolPictureBox.TabStop = false;
            // 
            // welcomeNameLabel
            // 
            welcomeNameLabel.AutoSize = true;
            welcomeNameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            welcomeNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            welcomeNameLabel.Location = new Point(257, 145);
            welcomeNameLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeNameLabel.Name = "welcomeNameLabel";
            welcomeNameLabel.Size = new Size(135, 38);
            welcomeNameLabel.TabIndex = 2;
            welcomeNameLabel.Text = "Welcome";
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.FromArgb(93, 109, 126);
            buttonsPanel.Controls.Add(button1);
            buttonsPanel.Controls.Add(searchButton);
            buttonsPanel.Controls.Add(appointmentsButton);
            buttonsPanel.Controls.Add(editPatientButton);
            buttonsPanel.Controls.Add(logoutButton);
            buttonsPanel.Controls.Add(registerPatientButton);
            buttonsPanel.Controls.Add(genericNursePictureBox);
            buttonsPanel.Location = new Point(0, 127);
            buttonsPanel.Margin = new Padding(4, 5, 4, 5);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(249, 900);
            buttonsPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 244);
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 760);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(249, 70);
            button1.TabIndex = 9;
            button1.Text = "View Information";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(255, 255, 242);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(0, 508);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(249, 82);
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
            appointmentsButton.Location = new Point(0, 428);
            appointmentsButton.Margin = new Padding(4, 5, 4, 5);
            appointmentsButton.Name = "appointmentsButton";
            appointmentsButton.Size = new Size(249, 82);
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
            editPatientButton.Location = new Point(0, 348);
            editPatientButton.Margin = new Padding(4, 5, 4, 5);
            editPatientButton.Name = "editPatientButton";
            editPatientButton.Size = new Size(249, 82);
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
            logoutButton.Location = new Point(0, 582);
            logoutButton.Margin = new Padding(4, 5, 4, 5);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(249, 82);
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
            registerPatientButton.Location = new Point(0, 267);
            registerPatientButton.Margin = new Padding(4, 5, 4, 5);
            registerPatientButton.Name = "registerPatientButton";
            registerPatientButton.Size = new Size(249, 82);
            registerPatientButton.TabIndex = 5;
            registerPatientButton.Text = "Register Patient";
            registerPatientButton.UseVisualStyleBackColor = true;
            registerPatientButton.Click += registerPatientButton_Click;
            // 
            // genericNursePictureBox
            // 
            genericNursePictureBox.Image = Properties.Resources.nurseSymbol;
            genericNursePictureBox.Location = new Point(0, 0);
            genericNursePictureBox.Margin = new Padding(4, 5, 4, 5);
            genericNursePictureBox.Name = "genericNursePictureBox";
            genericNursePictureBox.Size = new Size(249, 267);
            genericNursePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            genericNursePictureBox.TabIndex = 4;
            genericNursePictureBox.TabStop = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            idLabel.ForeColor = Color.FromArgb(242, 243, 244);
            idLabel.Location = new Point(257, 210);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(52, 38);
            idLabel.TabIndex = 4;
            idLabel.Text = "ID:";
            // 
            // registeredPatiensDataGridView
            // 
            registeredPatiensDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registeredPatiensDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            registeredPatiensDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registeredPatiensDataGridView.Location = new Point(257, 398);
            registeredPatiensDataGridView.Margin = new Padding(4, 5, 4, 5);
            registeredPatiensDataGridView.Name = "registeredPatiensDataGridView";
            registeredPatiensDataGridView.RowHeadersWidth = 62;
            registeredPatiensDataGridView.Size = new Size(850, 557);
            registeredPatiensDataGridView.TabIndex = 5;
            // 
            // patientsLabel
            // 
            patientsLabel.AutoSize = true;
            patientsLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            patientsLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientsLabel.Location = new Point(257, 352);
            patientsLabel.Margin = new Padding(4, 0, 4, 0);
            patientsLabel.Name = "patientsLabel";
            patientsLabel.Size = new Size(259, 38);
            patientsLabel.TabIndex = 6;
            patientsLabel.Text = "Registered Patients";
            // 
            // errormessageLabel
            // 
            errormessageLabel.AutoSize = true;
            errormessageLabel.BackColor = Color.FromArgb(244, 244, 243);
            errormessageLabel.ForeColor = Color.Red;
            errormessageLabel.Location = new Point(556, 365);
            errormessageLabel.Margin = new Padding(4, 0, 4, 0);
            errormessageLabel.Name = "errormessageLabel";
            errormessageLabel.Size = new Size(54, 25);
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
            searchGroupBox.Location = new Point(257, 137);
            searchGroupBox.Margin = new Padding(4, 5, 4, 5);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Padding = new Padding(4, 5, 4, 5);
            searchGroupBox.Size = new Size(839, 202);
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
            patientSearchButton.Location = new Point(361, 153);
            patientSearchButton.Margin = new Padding(4, 5, 4, 5);
            patientSearchButton.Name = "patientSearchButton";
            patientSearchButton.Size = new Size(107, 38);
            patientSearchButton.TabIndex = 6;
            patientSearchButton.Text = "Search";
            patientSearchButton.UseVisualStyleBackColor = false;
            patientSearchButton.Click += patientSearchButton_Click;
            // 
            // lnameTextBox
            // 
            lnameTextBox.BackColor = Color.FromArgb(255, 255, 244);
            lnameTextBox.Location = new Point(33, 112);
            lnameTextBox.Margin = new Padding(4, 5, 4, 5);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.PlaceholderText = "Last Name";
            lnameTextBox.Size = new Size(215, 31);
            lnameTextBox.TabIndex = 5;
            // 
            // fnameSearchTextBox
            // 
            fnameSearchTextBox.BackColor = Color.FromArgb(255, 255, 244);
            fnameSearchTextBox.Location = new Point(33, 47);
            fnameSearchTextBox.Margin = new Padding(4, 5, 4, 5);
            fnameSearchTextBox.Name = "fnameSearchTextBox";
            fnameSearchTextBox.PlaceholderText = "First Name";
            fnameSearchTextBox.Size = new Size(215, 31);
            fnameSearchTextBox.TabIndex = 4;
            // 
            // searchDatePicker
            // 
            searchDatePicker.CustomFormat = "";
            searchDatePicker.ImeMode = ImeMode.Off;
            searchDatePicker.Location = new Point(319, 68);
            searchDatePicker.Margin = new Padding(4, 5, 4, 5);
            searchDatePicker.Name = "searchDatePicker";
            searchDatePicker.Size = new Size(273, 31);
            searchDatePicker.TabIndex = 3;
            // 
            // bothRadioButton
            // 
            bothRadioButton.AutoSize = true;
            bothRadioButton.Location = new Point(676, 133);
            bothRadioButton.Margin = new Padding(4, 5, 4, 5);
            bothRadioButton.Name = "bothRadioButton";
            bothRadioButton.Size = new Size(74, 29);
            bothRadioButton.TabIndex = 2;
            bothRadioButton.TabStop = true;
            bothRadioButton.Text = "Both";
            bothRadioButton.UseVisualStyleBackColor = true;
            bothRadioButton.CheckedChanged += bothRadioButton_CheckedChanged;
            // 
            // birthdateRadioButton
            // 
            birthdateRadioButton.AutoSize = true;
            birthdateRadioButton.Location = new Point(676, 87);
            birthdateRadioButton.Margin = new Padding(4, 5, 4, 5);
            birthdateRadioButton.Name = "birthdateRadioButton";
            birthdateRadioButton.Size = new Size(108, 29);
            birthdateRadioButton.TabIndex = 1;
            birthdateRadioButton.TabStop = true;
            birthdateRadioButton.Text = "Birthdate";
            birthdateRadioButton.UseVisualStyleBackColor = true;
            birthdateRadioButton.CheckedChanged += birthdateRadioButton_CheckedChanged;
            // 
            // nameRadioButton
            // 
            nameRadioButton.AutoSize = true;
            nameRadioButton.Location = new Point(676, 37);
            nameRadioButton.Margin = new Padding(4, 5, 4, 5);
            nameRadioButton.Name = "nameRadioButton";
            nameRadioButton.Size = new Size(84, 29);
            nameRadioButton.TabIndex = 0;
            nameRadioButton.TabStop = true;
            nameRadioButton.Text = "Name";
            nameRadioButton.UseVisualStyleBackColor = true;
            nameRadioButton.Click += nameRadioButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(1113, 977);
            Controls.Add(searchGroupBox);
            Controls.Add(errormessageLabel);
            Controls.Add(patientsLabel);
            Controls.Add(registeredPatiensDataGridView);
            Controls.Add(idLabel);
            Controls.Add(buttonsPanel);
            Controls.Add(welcomeNameLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button1;
    }
}