namespace HealthCareSystem.View
{
    partial class PatientInformation
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
            back_btn = new Button();
            healthCareNameLabel = new Label();
            patientNameLabel = new Label();
            lastNameLabel = new Label();
            birthdateLabel = new Label();
            addressLabel = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            zipcodeLabel = new Label();
            phoneNumberLabel = new Label();
            pt_fname_txtbx = new TextBox();
            pt_lname_txtbx = new TextBox();
            bdate_txtbx = new TextBox();
            genderGroupBox = new GroupBox();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            address_txtbx = new TextBox();
            mIntial_label = new Label();
            phone_num_txtbx = new TextBox();
            zip_txtbx = new TextBox();
            isActiveGroupBox = new GroupBox();
            noRadioButton = new RadioButton();
            yesRadioButton = new RadioButton();
            register_btn = new Button();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            update_btn = new Button();
            city_txtbx = new TextBox();
            minit_txtbx = new TextBox();
            feedback_label = new Label();
            state_label = new TextBox();
            patientID_txtbx = new TextBox();
            ptId_label = new Label();
            country_txtbx = new TextBox();
            label2 = new Label();
            states_combobox = new ComboBox();
            birthdate_datepicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            genderGroupBox.SuspendLayout();
            isActiveGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(0, 1);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            symbolPictureBox.TabIndex = 0;
            symbolPictureBox.TabStop = false;
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(back_btn);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(87, 1);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(754, 76);
            healthCareNamePanel.TabIndex = 1;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(660, 38);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 1;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(23, 29);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientNameLabel.Location = new Point(176, 136);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(64, 15);
            patientNameLabel.TabIndex = 2;
            patientNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            lastNameLabel.Location = new Point(558, 136);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            birthdateLabel.Location = new Point(84, 195);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new Size(55, 15);
            birthdateLabel.TabIndex = 4;
            birthdateLabel.Text = "Birthdate";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.ForeColor = Color.FromArgb(242, 243, 244);
            addressLabel.Location = new Point(239, 195);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.ForeColor = Color.FromArgb(242, 243, 244);
            cityLabel.Location = new Point(630, 195);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            stateLabel.Location = new Point(84, 254);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(33, 15);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.ForeColor = Color.FromArgb(242, 243, 244);
            zipcodeLabel.Location = new Point(242, 254);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(50, 15);
            zipcodeLabel.TabIndex = 9;
            zipcodeLabel.Text = "Zipcode";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.ForeColor = Color.FromArgb(242, 243, 244);
            phoneNumberLabel.Location = new Point(622, 254);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // pt_fname_txtbx
            // 
            pt_fname_txtbx.BackColor = Color.FromArgb(255, 255, 242);
            pt_fname_txtbx.Location = new Point(176, 154);
            pt_fname_txtbx.Multiline = true;
            pt_fname_txtbx.Name = "pt_fname_txtbx";
            pt_fname_txtbx.Size = new Size(278, 23);
            pt_fname_txtbx.TabIndex = 12;
            pt_fname_txtbx.TextChanged += pt_fname_txtbx_TextChanged;
            // 
            // pt_lname_txtbx
            // 
            pt_lname_txtbx.BackColor = Color.FromArgb(255, 255, 242);
            pt_lname_txtbx.Location = new Point(558, 154);
            pt_lname_txtbx.Name = "pt_lname_txtbx";
            pt_lname_txtbx.Size = new Size(230, 23);
            pt_lname_txtbx.TabIndex = 13;
            pt_lname_txtbx.TextChanged += pt_lname_txtbx_TextChanged;
            // 
            // bdate_txtbx
            // 
            bdate_txtbx.BackColor = Color.FromArgb(255, 255, 242);
            bdate_txtbx.Location = new Point(33, 406);
            bdate_txtbx.Name = "bdate_txtbx";
            bdate_txtbx.Size = new Size(121, 23);
            bdate_txtbx.TabIndex = 14;
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.ForeColor = Color.FromArgb(242, 243, 244);
            genderGroupBox.Location = new Point(187, 318);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Size = new Size(221, 75);
            genderGroupBox.TabIndex = 15;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(14, 47);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(63, 19);
            femaleRadioButton.TabIndex = 1;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Tag = "Female";
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(14, 22);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(51, 19);
            maleRadioButton.TabIndex = 0;
            maleRadioButton.TabStop = true;
            maleRadioButton.Tag = "Male";
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // address_txtbx
            // 
            address_txtbx.BackColor = Color.FromArgb(255, 255, 242);
            address_txtbx.Location = new Point(239, 213);
            address_txtbx.Name = "address_txtbx";
            address_txtbx.Size = new Size(348, 23);
            address_txtbx.TabIndex = 16;
            address_txtbx.TextChanged += address_txtbx_TextChanged;
            // 
            // mIntial_label
            // 
            mIntial_label.AutoSize = true;
            mIntial_label.ForeColor = Color.FromArgb(242, 243, 244);
            mIntial_label.Location = new Point(482, 136);
            mIntial_label.Name = "mIntial_label";
            mIntial_label.Size = new Size(21, 15);
            mIntial_label.TabIndex = 17;
            mIntial_label.Text = "MI";
            // 
            // phone_num_txtbx
            // 
            phone_num_txtbx.BackColor = Color.FromArgb(255, 255, 242);
            phone_num_txtbx.Location = new Point(622, 272);
            phone_num_txtbx.Name = "phone_num_txtbx";
            phone_num_txtbx.Size = new Size(166, 23);
            phone_num_txtbx.TabIndex = 18;
            phone_num_txtbx.TextChanged += phone_num_txtbx_TextChanged;
            // 
            // zip_txtbx
            // 
            zip_txtbx.BackColor = Color.FromArgb(255, 255, 242);
            zip_txtbx.Location = new Point(242, 272);
            zip_txtbx.Name = "zip_txtbx";
            zip_txtbx.Size = new Size(166, 23);
            zip_txtbx.TabIndex = 19;
            zip_txtbx.TextChanged += zip_txtbx_TextChanged;
            // 
            // isActiveGroupBox
            // 
            isActiveGroupBox.Controls.Add(noRadioButton);
            isActiveGroupBox.Controls.Add(yesRadioButton);
            isActiveGroupBox.ForeColor = Color.FromArgb(242, 243, 244);
            isActiveGroupBox.Location = new Point(482, 318);
            isActiveGroupBox.Name = "isActiveGroupBox";
            isActiveGroupBox.Size = new Size(166, 75);
            isActiveGroupBox.TabIndex = 23;
            isActiveGroupBox.TabStop = false;
            isActiveGroupBox.Text = "Is Active";
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(11, 45);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(41, 19);
            noRadioButton.TabIndex = 1;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(11, 20);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(42, 19);
            yesRadioButton.TabIndex = 0;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(255, 255, 242);
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            register_btn.ForeColor = Color.Black;
            register_btn.Location = new Point(516, 456);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(105, 45);
            register_btn.TabIndex = 6;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(53, 92);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(64, 25);
            nurseNameLabel.TabIndex = 24;
            nurseNameLabel.Text = "Name";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(307, 92);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(37, 25);
            nurseIdLabel.TabIndex = 25;
            nurseIdLabel.Text = "ID:";
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(255, 255, 242);
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.Black;
            update_btn.Location = new Point(239, 456);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(101, 45);
            update_btn.TabIndex = 26;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // city_txtbx
            // 
            city_txtbx.Location = new Point(630, 213);
            city_txtbx.Name = "city_txtbx";
            city_txtbx.Size = new Size(158, 23);
            city_txtbx.TabIndex = 27;
            city_txtbx.TextChanged += city_txtbx_TextChanged;
            // 
            // minit_txtbx
            // 
            minit_txtbx.Location = new Point(482, 154);
            minit_txtbx.Name = "minit_txtbx";
            minit_txtbx.Size = new Size(34, 23);
            minit_txtbx.TabIndex = 29;
            minit_txtbx.TextChanged += minit_txtbx_TextChanged;
            // 
            // feedback_label
            // 
            feedback_label.AutoSize = true;
            feedback_label.BackColor = Color.FromArgb(255, 255, 242);
            feedback_label.ForeColor = Color.Red;
            feedback_label.Location = new Point(251, 414);
            feedback_label.Name = "feedback_label";
            feedback_label.Size = new Size(60, 15);
            feedback_label.TabIndex = 30;
            feedback_label.Text = "Feedback:";
            // 
            // state_label
            // 
            state_label.BackColor = Color.FromArgb(255, 255, 242);
            state_label.Location = new Point(85, 272);
            state_label.Name = "state_label";
            state_label.Size = new Size(92, 23);
            state_label.TabIndex = 31;
            // 
            // patientID_txtbx
            // 
            patientID_txtbx.Location = new Point(84, 154);
            patientID_txtbx.Name = "patientID_txtbx";
            patientID_txtbx.ReadOnly = true;
            patientID_txtbx.Size = new Size(50, 23);
            patientID_txtbx.TabIndex = 32;
            // 
            // ptId_label
            // 
            ptId_label.AutoSize = true;
            ptId_label.ForeColor = Color.FromArgb(244, 243, 242);
            ptId_label.Location = new Point(81, 136);
            ptId_label.Name = "ptId_label";
            ptId_label.Size = new Size(58, 15);
            ptId_label.TabIndex = 33;
            ptId_label.Text = "Patient ID";
            // 
            // country_txtbx
            // 
            country_txtbx.Location = new Point(450, 272);
            country_txtbx.Name = "country_txtbx";
            country_txtbx.Size = new Size(119, 23);
            country_txtbx.TabIndex = 34;
            country_txtbx.TextChanged += country_txtbx_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(244, 243, 242);
            label2.Location = new Point(460, 254);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 35;
            label2.Text = "Country";
            // 
            // states_combobox
            // 
            states_combobox.FormattingEnabled = true;
            states_combobox.Location = new Point(84, 301);
            states_combobox.Name = "states_combobox";
            states_combobox.Size = new Size(93, 23);
            states_combobox.TabIndex = 36;
            states_combobox.SelectedIndexChanged += states_combobox_SelectedIndexChanged;
            // 
            // birthdate_datepicker
            // 
            birthdate_datepicker.Location = new Point(23, 213);
            birthdate_datepicker.Name = "birthdate_datepicker";
            birthdate_datepicker.Size = new Size(200, 23);
            birthdate_datepicker.TabIndex = 37;
            birthdate_datepicker.ValueChanged += birthdate_datepicker_ValueChanged;
            // 
            // PatientInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(834, 515);
            Controls.Add(birthdate_datepicker);
            Controls.Add(states_combobox);
            Controls.Add(label2);
            Controls.Add(country_txtbx);
            Controls.Add(ptId_label);
            Controls.Add(patientID_txtbx);
            Controls.Add(state_label);
            Controls.Add(feedback_label);
            Controls.Add(minit_txtbx);
            Controls.Add(city_txtbx);
            Controls.Add(update_btn);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(register_btn);
            Controls.Add(isActiveGroupBox);
            Controls.Add(zip_txtbx);
            Controls.Add(phone_num_txtbx);
            Controls.Add(mIntial_label);
            Controls.Add(address_txtbx);
            Controls.Add(genderGroupBox);
            Controls.Add(bdate_txtbx);
            Controls.Add(pt_lname_txtbx);
            Controls.Add(pt_fname_txtbx);
            Controls.Add(phoneNumberLabel);
            Controls.Add(zipcodeLabel);
            Controls.Add(stateLabel);
            Controls.Add(cityLabel);
            Controls.Add(addressLabel);
            Controls.Add(birthdateLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(patientNameLabel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "PatientInformation";
            Text = "Patient Information";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            genderGroupBox.ResumeLayout(false);
            genderGroupBox.PerformLayout();
            isActiveGroupBox.ResumeLayout(false);
            isActiveGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbolPictureBox;
        private Panel healthCareNamePanel;
        private Label healthCareNameLabel;
        private Label patientNameLabel;
        private Label lastNameLabel;
        private Label birthdateLabel;
        private Label addressLabel;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipcodeLabel;
        private Label phoneNumberLabel;
        private TextBox pt_fname_txtbx;
        private TextBox pt_lname_txtbx;
        private TextBox bdate_txtbx;
        private GroupBox genderGroupBox;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private TextBox address_txtbx;
        private Label mIntial_label;
        private TextBox phone_num_txtbx;
        private TextBox zip_txtbx;
        private GroupBox isActiveGroupBox;
        private RadioButton noRadioButton;
        private RadioButton yesRadioButton;
        private Button register_btn;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Button update_btn;
        private TextBox city_txtbx;
        private TextBox minit_txtbx;
        private Label feedback_label;
        private TextBox state_label;
        private TextBox patientID_txtbx;
        private Label ptId_label;
        private TextBox country_txtbx;
        private Label label2;
        private Button back_btn;
        private ComboBox states_combobox;
        private DateTimePicker birthdate_datepicker;
    }
}