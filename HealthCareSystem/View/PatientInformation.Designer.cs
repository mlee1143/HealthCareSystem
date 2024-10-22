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
            healthCareNameLabel = new Label();
            patientNameLabel = new Label();
            lastNameLabel = new Label();
            birthdateLabel = new Label();
            addressLabel = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            zipcodeLabel = new Label();
            phoneNumberLabel = new Label();
            pt_fnamelabel = new TextBox();
            pt_lnamelabel = new TextBox();
            bdate_label = new TextBox();
            genderGroupBox = new GroupBox();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            address_label = new TextBox();
            mIntialDropBox = new Label();
            phone_num_label = new TextBox();
            zip_label = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            states_combobx = new ComboBox();
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
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(87, 1);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(714, 76);
            healthCareNamePanel.TabIndex = 1;
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
            patientNameLabel.Location = new Point(85, 136);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(39, 15);
            patientNameLabel.TabIndex = 2;
            patientNameLabel.Text = "Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            lastNameLabel.Location = new Point(90, 239);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            birthdateLabel.Location = new Point(90, 300);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new Size(55, 15);
            birthdateLabel.TabIndex = 4;
            birthdateLabel.Text = "Birthdate";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.ForeColor = Color.FromArgb(242, 243, 244);
            addressLabel.Location = new Point(358, 136);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.ForeColor = Color.FromArgb(242, 243, 244);
            cityLabel.Location = new Point(358, 185);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            stateLabel.Location = new Point(547, 185);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(33, 15);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.ForeColor = Color.FromArgb(242, 243, 244);
            zipcodeLabel.Location = new Point(358, 239);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(50, 15);
            zipcodeLabel.TabIndex = 9;
            zipcodeLabel.Text = "Zipcode";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.ForeColor = Color.FromArgb(242, 243, 244);
            phoneNumberLabel.Location = new Point(358, 300);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // pt_fnamelabel
            // 
            pt_fnamelabel.BackColor = Color.FromArgb(255, 255, 242);
            pt_fnamelabel.Location = new Point(90, 154);
            pt_fnamelabel.Multiline = true;
            pt_fnamelabel.Name = "pt_fnamelabel";
            pt_fnamelabel.Size = new Size(221, 23);
            pt_fnamelabel.TabIndex = 12;
            // 
            // pt_lnamelabel
            // 
            pt_lnamelabel.BackColor = Color.FromArgb(255, 255, 242);
            pt_lnamelabel.Location = new Point(90, 257);
            pt_lnamelabel.Name = "pt_lnamelabel";
            pt_lnamelabel.Size = new Size(221, 23);
            pt_lnamelabel.TabIndex = 13;
            // 
            // bdate_label
            // 
            bdate_label.BackColor = Color.FromArgb(255, 255, 242);
            bdate_label.Location = new Point(90, 318);
            bdate_label.Name = "bdate_label";
            bdate_label.Size = new Size(221, 23);
            bdate_label.TabIndex = 14;
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.ForeColor = Color.FromArgb(242, 243, 244);
            genderGroupBox.Location = new Point(90, 364);
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
            // address_label
            // 
            address_label.BackColor = Color.FromArgb(255, 255, 242);
            address_label.Location = new Point(358, 154);
            address_label.Name = "address_label";
            address_label.Size = new Size(348, 23);
            address_label.TabIndex = 16;
            // 
            // mIntialDropBox
            // 
            mIntialDropBox.AutoSize = true;
            mIntialDropBox.ForeColor = Color.FromArgb(242, 243, 244);
            mIntialDropBox.Location = new Point(90, 185);
            mIntialDropBox.Name = "mIntialDropBox";
            mIntialDropBox.Size = new Size(111, 15);
            mIntialDropBox.TabIndex = 17;
            mIntialDropBox.Text = "Middle Name Initial";
            // 
            // phone_num_label
            // 
            phone_num_label.BackColor = Color.FromArgb(255, 255, 242);
            phone_num_label.Location = new Point(358, 318);
            phone_num_label.Name = "phone_num_label";
            phone_num_label.Size = new Size(166, 23);
            phone_num_label.TabIndex = 18;
            phone_num_label.TextChanged += phone_num_label_TextChanged;
            // 
            // zip_label
            // 
            zip_label.BackColor = Color.FromArgb(255, 255, 242);
            zip_label.Location = new Point(358, 257);
            zip_label.Name = "zip_label";
            zip_label.Size = new Size(166, 23);
            zip_label.TabIndex = 19;
            zip_label.TextChanged += zip_label_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 242);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 20;
            comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(255, 255, 242);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(358, 203);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(166, 23);
            comboBox2.TabIndex = 21;
            comboBox2.Visible = false;
            // 
            // states_combobx
            // 
            states_combobx.BackColor = Color.FromArgb(255, 255, 242);
            states_combobx.DropDownStyle = ComboBoxStyle.DropDownList;
            states_combobx.FormattingEnabled = true;
            states_combobx.Location = new Point(547, 203);
            states_combobx.Name = "states_combobx";
            states_combobx.Size = new Size(159, 23);
            states_combobx.TabIndex = 22;
            states_combobx.Visible = false;
            // 
            // isActiveGroupBox
            // 
            isActiveGroupBox.Controls.Add(noRadioButton);
            isActiveGroupBox.Controls.Add(yesRadioButton);
            isActiveGroupBox.ForeColor = Color.FromArgb(242, 243, 244);
            isActiveGroupBox.Location = new Point(358, 364);
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
            register_btn.Location = new Point(369, 456);
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
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(87, 91);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(39, 15);
            nurseNameLabel.TabIndex = 24;
            nurseNameLabel.Text = "Name";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(358, 91);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(21, 15);
            nurseIdLabel.TabIndex = 25;
            nurseIdLabel.Text = "ID:";
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(255, 255, 242);
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.Black;
            update_btn.Location = new Point(210, 456);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(101, 45);
            update_btn.TabIndex = 26;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // city_txtbx
            // 
            city_txtbx.Location = new Point(358, 203);
            city_txtbx.Name = "city_txtbx";
            city_txtbx.Size = new Size(166, 23);
            city_txtbx.TabIndex = 27;
            // 
            // minit_txtbx
            // 
            minit_txtbx.Location = new Point(90, 203);
            minit_txtbx.Name = "minit_txtbx";
            minit_txtbx.Size = new Size(142, 23);
            minit_txtbx.TabIndex = 29;
            // 
            // feedback_label
            // 
            feedback_label.AutoSize = true;
            feedback_label.BackColor = Color.FromArgb(255, 255, 242);
            feedback_label.ForeColor = Color.Black;
            feedback_label.Location = new Point(547, 364);
            feedback_label.Name = "feedback_label";
            feedback_label.Size = new Size(60, 15);
            feedback_label.TabIndex = 30;
            feedback_label.Text = "Feedback:";
            // 
            // state_label
            // 
            state_label.BackColor = Color.FromArgb(255, 255, 242);
            state_label.Location = new Point(547, 203);
            state_label.Name = "state_label";
            state_label.Size = new Size(159, 23);
            state_label.TabIndex = 31;
            // 
            // PatientInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(800, 515);
            Controls.Add(state_label);
            Controls.Add(feedback_label);
            Controls.Add(minit_txtbx);
            Controls.Add(city_txtbx);
            Controls.Add(update_btn);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(register_btn);
            Controls.Add(isActiveGroupBox);
            Controls.Add(states_combobx);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(zip_label);
            Controls.Add(phone_num_label);
            Controls.Add(mIntialDropBox);
            Controls.Add(address_label);
            Controls.Add(genderGroupBox);
            Controls.Add(bdate_label);
            Controls.Add(pt_lnamelabel);
            Controls.Add(pt_fnamelabel);
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
        private TextBox pt_fnamelabel;
        private TextBox pt_lnamelabel;
        private TextBox bdate_label;
        private GroupBox genderGroupBox;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private TextBox address_label;
        private Label mIntialDropBox;
        private TextBox phone_num_label;
        private TextBox zip_label;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox states_combobx;
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
    }
}