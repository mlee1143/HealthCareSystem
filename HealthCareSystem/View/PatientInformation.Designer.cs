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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            genderGroupBox = new GroupBox();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            textBox4 = new TextBox();
            mIntialDropBox = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            isActiveGroupBox = new GroupBox();
            noRadioButton = new RadioButton();
            yesRadioButton = new RadioButton();
            button1 = new Button();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 242);
            textBox1.Location = new Point(90, 154);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 255, 242);
            textBox2.Location = new Point(90, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 255, 242);
            textBox3.Location = new Point(90, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 14;
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
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(255, 255, 242);
            textBox4.Location = new Point(358, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(348, 23);
            textBox4.TabIndex = 16;
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
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(255, 255, 242);
            textBox5.Location = new Point(358, 318);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(255, 255, 242);
            textBox6.Location = new Point(358, 257);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(166, 23);
            textBox6.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 242);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 23);
            comboBox1.TabIndex = 20;
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
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(255, 255, 242);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(547, 203);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(159, 23);
            comboBox3.TabIndex = 22;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 242);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(341, 456);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
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
            // PatientInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(800, 515);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(button1);
            Controls.Add(isActiveGroupBox);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(mIntialDropBox);
            Controls.Add(textBox4);
            Controls.Add(genderGroupBox);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox genderGroupBox;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private TextBox textBox4;
        private Label mIntialDropBox;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private GroupBox isActiveGroupBox;
        private RadioButton noRadioButton;
        private RadioButton yesRadioButton;
        private Button button1;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
    }
}