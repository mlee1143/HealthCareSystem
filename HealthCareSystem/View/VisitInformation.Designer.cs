namespace HealthCareSystem.View
{
    partial class VisitInformation
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
            back_btn = new Button();
            symbolPictureBox = new PictureBox();
            patientIDLabel = new Label();
            patientnameLabel = new Label();
            systolicTextBox = new TextBox();
            bpLabel = new Label();
            temperatureTextbox = new TextBox();
            temperatureLabel = new Label();
            pulseLabel = new Label();
            pulseTextbox = new TextBox();
            symptomsLabel = new Label();
            symptomsTextbox = new RichTextBox();
            diagnosisTextbox = new RichTextBox();
            heightTextbox = new TextBox();
            heightLabel = new Label();
            weightTextbox = new TextBox();
            weightLabel = new Label();
            doctorIDLabel = new Label();
            diagnosisLabel = new Label();
            submitButton = new Button();
            errorLabel = new Label();
            doctorNameLabel = new Label();
            patientDobLabel = new Label();
            routineGroupBox = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            distolicTextbox = new TextBox();
            diagnosisGroupbox = new GroupBox();
            confirmBtn = new Button();
            label1 = new Label();
            finalDiagnosisTextbox = new RichTextBox();
            appointmentsButtonPanel = new Panel();
            completedButton = new Button();
            orderTestButton = new Button();
            diagnosisButton = new Button();
            checkupButton = new Button();
            checkupCheckbox = new CheckBox();
            diagnosisCheckbox = new CheckBox();
            completedCheckbox = new CheckBox();
            completeInformationGroupbox = new GroupBox();
            orderedTestsGridview = new DataGridView();
            label4 = new Label();
            finalDiagnosisLabelSummary = new Label();
            initialDiagnosisLabelSummary = new Label();
            symptomsLabelSummary = new Label();
            pulseLabelSummary = new Label();
            temperatureLabelSummary = new Label();
            bloodpressureLabelSummary = new Label();
            heightLabelSummary = new Label();
            weightLabelSummary = new Label();
            nurseNameLabel = new Label();
            label6 = new Label();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            routineGroupBox.SuspendLayout();
            diagnosisGroupbox.SuspendLayout();
            appointmentsButtonPanel.SuspendLayout();
            completeInformationGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderedTestsGridview).BeginInit();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(83, 0);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(769, 79);
            healthCareNamePanel.TabIndex = 2;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(11, 21);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.FromArgb(255, 255, 242);
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            back_btn.ForeColor = Color.Black;
            back_btn.Location = new Point(0, 196);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(143, 49);
            back_btn.TabIndex = 1;
            back_btn.Text = "Back To Main";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(1, 0);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 3;
            symbolPictureBox.TabStop = false;
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientIDLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientIDLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            patientIDLabel.Location = new Point(181, 93);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new Size(75, 17);
            patientIDLabel.TabIndex = 4;
            patientIDLabel.Text = "Patient ID: ";
            // 
            // patientnameLabel
            // 
            patientnameLabel.AutoSize = true;
            patientnameLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientnameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientnameLabel.Location = new Point(313, 93);
            patientnameLabel.Name = "patientnameLabel";
            patientnameLabel.Size = new Size(94, 17);
            patientnameLabel.TabIndex = 5;
            patientnameLabel.Text = "Patient Name:";
            patientnameLabel.Click += patientnameLabel_Click;
            // 
            // systolicTextBox
            // 
            systolicTextBox.BackColor = Color.FromArgb(255, 255, 242);
            systolicTextBox.Location = new Point(21, 145);
            systolicTextBox.Name = "systolicTextBox";
            systolicTextBox.Size = new Size(43, 23);
            systolicTextBox.TabIndex = 6;
            systolicTextBox.TextChanged += bloodpressureTextBox_TextChanged;
            // 
            // bpLabel
            // 
            bpLabel.AutoSize = true;
            bpLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bpLabel.ForeColor = Color.FromArgb(242, 243, 244);
            bpLabel.Location = new Point(17, 103);
            bpLabel.Name = "bpLabel";
            bpLabel.Size = new Size(138, 17);
            bpLabel.TabIndex = 7;
            bpLabel.Text = "Blood Pressure (mmg)";
            // 
            // temperatureTextbox
            // 
            temperatureTextbox.BackColor = Color.FromArgb(255, 255, 242);
            temperatureTextbox.ForeColor = Color.Black;
            temperatureTextbox.Location = new Point(303, 55);
            temperatureTextbox.Name = "temperatureTextbox";
            temperatureTextbox.Size = new Size(100, 23);
            temperatureTextbox.TabIndex = 8;
            temperatureTextbox.TextChanged += temperatureTextbox_TextChanged;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temperatureLabel.ForeColor = Color.FromArgb(242, 243, 244);
            temperatureLabel.Location = new Point(303, 33);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(100, 17);
            temperatureLabel.TabIndex = 9;
            temperatureLabel.Text = "Temperature (F)";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseLabel.ForeColor = Color.FromArgb(255, 255, 242);
            pulseLabel.Location = new Point(454, 33);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(77, 17);
            pulseLabel.TabIndex = 10;
            pulseLabel.Text = "Pulse (bpm)";
            // 
            // pulseTextbox
            // 
            pulseTextbox.BackColor = Color.FromArgb(255, 255, 242);
            pulseTextbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseTextbox.Location = new Point(454, 53);
            pulseTextbox.Name = "pulseTextbox";
            pulseTextbox.Size = new Size(63, 23);
            pulseTextbox.TabIndex = 11;
            pulseTextbox.TextChanged += pulseTextbox_TextChanged;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsLabel.ForeColor = Color.FromArgb(255, 255, 242);
            symptomsLabel.Location = new Point(17, 186);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(69, 17);
            symptomsLabel.TabIndex = 12;
            symptomsLabel.Text = "Symptoms";
            // 
            // symptomsTextbox
            // 
            symptomsTextbox.BackColor = Color.FromArgb(255, 255, 242);
            symptomsTextbox.ForeColor = Color.Black;
            symptomsTextbox.Location = new Point(17, 206);
            symptomsTextbox.Name = "symptomsTextbox";
            symptomsTextbox.Size = new Size(548, 132);
            symptomsTextbox.TabIndex = 13;
            symptomsTextbox.Text = "";
            // 
            // diagnosisTextbox
            // 
            diagnosisTextbox.BackColor = Color.FromArgb(255, 255, 242);
            diagnosisTextbox.ForeColor = Color.Black;
            diagnosisTextbox.Location = new Point(47, 68);
            diagnosisTextbox.Name = "diagnosisTextbox";
            diagnosisTextbox.Size = new Size(439, 63);
            diagnosisTextbox.TabIndex = 14;
            diagnosisTextbox.Text = "";
            diagnosisTextbox.TextChanged += diagnosisTextbox_TextChanged;
            // 
            // heightTextbox
            // 
            heightTextbox.BackColor = Color.FromArgb(255, 255, 242);
            heightTextbox.Location = new Point(17, 55);
            heightTextbox.Name = "heightTextbox";
            heightTextbox.Size = new Size(94, 23);
            heightTextbox.TabIndex = 15;
            heightTextbox.TextChanged += heightTextbox_TextChanged;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.ForeColor = Color.FromArgb(242, 243, 244);
            heightLabel.Location = new Point(17, 38);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(67, 15);
            heightLabel.TabIndex = 16;
            heightLabel.Text = "Height (in.)";
            // 
            // weightTextbox
            // 
            weightTextbox.BackColor = Color.FromArgb(255, 255, 242);
            weightTextbox.Location = new Point(152, 55);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Size = new Size(103, 23);
            weightTextbox.TabIndex = 17;
            weightTextbox.TextChanged += weightTextbox_TextChanged;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.ForeColor = Color.FromArgb(244, 243, 242);
            weightLabel.Location = new Point(152, 35);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(74, 15);
            weightLabel.TabIndex = 18;
            weightLabel.Text = "Weight (lbs.)";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorIDLabel.ForeColor = Color.FromArgb(244, 243, 242);
            doctorIDLabel.Location = new Point(503, 93);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new Size(69, 17);
            doctorIDLabel.TabIndex = 19;
            doctorIDLabel.Text = "Doctor ID:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diagnosisLabel.ForeColor = Color.FromArgb(244, 243, 242);
            diagnosisLabel.Location = new Point(47, 48);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(99, 17);
            diagnosisLabel.TabIndex = 20;
            diagnosisLabel.Text = "Initial Diagnosis";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 255, 244);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.ForeColor = Color.Black;
            submitButton.Location = new Point(259, 344);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(90, 32);
            submitButton.TabIndex = 21;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.FromArgb(244, 243, 242);
            errorLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(24, 104);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 17);
            errorLabel.TabIndex = 22;
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorNameLabel.ForeColor = Color.FromArgb(244, 243, 242);
            doctorNameLabel.Location = new Point(600, 93);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(92, 17);
            doctorNameLabel.TabIndex = 23;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // patientDobLabel
            // 
            patientDobLabel.AutoSize = true;
            patientDobLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientDobLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientDobLabel.Location = new Point(181, 110);
            patientDobLabel.Name = "patientDobLabel";
            patientDobLabel.Size = new Size(85, 17);
            patientDobLabel.TabIndex = 24;
            patientDobLabel.Text = "Patient DOB:";
            // 
            // routineGroupBox
            // 
            routineGroupBox.Controls.Add(label5);
            routineGroupBox.Controls.Add(label3);
            routineGroupBox.Controls.Add(label2);
            routineGroupBox.Controls.Add(distolicTextbox);
            routineGroupBox.Controls.Add(temperatureTextbox);
            routineGroupBox.Controls.Add(temperatureLabel);
            routineGroupBox.Controls.Add(weightTextbox);
            routineGroupBox.Controls.Add(errorLabel);
            routineGroupBox.Controls.Add(weightLabel);
            routineGroupBox.Controls.Add(submitButton);
            routineGroupBox.Controls.Add(heightTextbox);
            routineGroupBox.Controls.Add(heightLabel);
            routineGroupBox.Controls.Add(systolicTextBox);
            routineGroupBox.Controls.Add(bpLabel);
            routineGroupBox.Controls.Add(symptomsLabel);
            routineGroupBox.Controls.Add(symptomsTextbox);
            routineGroupBox.Controls.Add(pulseTextbox);
            routineGroupBox.Controls.Add(pulseLabel);
            routineGroupBox.ForeColor = Color.FromArgb(244, 243, 242);
            routineGroupBox.Location = new Point(181, 142);
            routineGroupBox.Margin = new Padding(2);
            routineGroupBox.Name = "routineGroupBox";
            routineGroupBox.Padding = new Padding(2);
            routineGroupBox.Size = new Size(580, 395);
            routineGroupBox.TabIndex = 25;
            routineGroupBox.TabStop = false;
            routineGroupBox.Text = "Routine Check Up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 146);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 25;
            label5.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 24;
            label3.Text = "Di";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 23;
            label2.Text = "Sy";
            // 
            // distolicTextbox
            // 
            distolicTextbox.Location = new Point(90, 146);
            distolicTextbox.Margin = new Padding(2);
            distolicTextbox.Name = "distolicTextbox";
            distolicTextbox.Size = new Size(38, 23);
            distolicTextbox.TabIndex = 22;
            // 
            // diagnosisGroupbox
            // 
            diagnosisGroupbox.Controls.Add(confirmBtn);
            diagnosisGroupbox.Controls.Add(label1);
            diagnosisGroupbox.Controls.Add(finalDiagnosisTextbox);
            diagnosisGroupbox.Controls.Add(diagnosisTextbox);
            diagnosisGroupbox.Controls.Add(diagnosisLabel);
            diagnosisGroupbox.ForeColor = Color.FromArgb(244, 243, 242);
            diagnosisGroupbox.Location = new Point(251, 214);
            diagnosisGroupbox.Margin = new Padding(2);
            diagnosisGroupbox.Name = "diagnosisGroupbox";
            diagnosisGroupbox.Padding = new Padding(2);
            diagnosisGroupbox.Size = new Size(545, 357);
            diagnosisGroupbox.TabIndex = 26;
            diagnosisGroupbox.TabStop = false;
            diagnosisGroupbox.Text = "Diagnosis";
            diagnosisGroupbox.Visible = false;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.FromArgb(255, 255, 244);
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = Color.Black;
            confirmBtn.Location = new Point(225, 301);
            confirmBtn.Margin = new Padding(2);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(78, 41);
            confirmBtn.TabIndex = 23;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 181);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 22;
            label1.Text = "Final Diagnosis";
            // 
            // finalDiagnosisTextbox
            // 
            finalDiagnosisTextbox.Location = new Point(47, 198);
            finalDiagnosisTextbox.Margin = new Padding(2);
            finalDiagnosisTextbox.Name = "finalDiagnosisTextbox";
            finalDiagnosisTextbox.Size = new Size(439, 88);
            finalDiagnosisTextbox.TabIndex = 21;
            finalDiagnosisTextbox.Text = "";
            // 
            // appointmentsButtonPanel
            // 
            appointmentsButtonPanel.BackColor = Color.FromArgb(93, 109, 126);
            appointmentsButtonPanel.Controls.Add(completedButton);
            appointmentsButtonPanel.Controls.Add(back_btn);
            appointmentsButtonPanel.Controls.Add(orderTestButton);
            appointmentsButtonPanel.Controls.Add(diagnosisButton);
            appointmentsButtonPanel.Controls.Add(checkupButton);
            appointmentsButtonPanel.Location = new Point(0, 82);
            appointmentsButtonPanel.Name = "appointmentsButtonPanel";
            appointmentsButtonPanel.Size = new Size(143, 504);
            appointmentsButtonPanel.TabIndex = 27;
            // 
            // completedButton
            // 
            completedButton.BackColor = Color.FromArgb(255, 255, 244);
            completedButton.Enabled = false;
            completedButton.FlatAppearance.BorderSize = 0;
            completedButton.FlatStyle = FlatStyle.Flat;
            completedButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            completedButton.ForeColor = Color.Black;
            completedButton.Location = new Point(0, 147);
            completedButton.Name = "completedButton";
            completedButton.Size = new Size(143, 49);
            completedButton.TabIndex = 30;
            completedButton.Text = "Completed Information";
            completedButton.UseVisualStyleBackColor = false;
            completedButton.Visible = false;
            // 
            // orderTestButton
            // 
            orderTestButton.BackColor = Color.FromArgb(255, 255, 244);
            orderTestButton.Enabled = false;
            orderTestButton.FlatAppearance.BorderSize = 0;
            orderTestButton.FlatStyle = FlatStyle.Flat;
            orderTestButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            orderTestButton.Location = new Point(0, 98);
            orderTestButton.Name = "orderTestButton";
            orderTestButton.Size = new Size(143, 49);
            orderTestButton.TabIndex = 13;
            orderTestButton.Text = "Order Tests";
            orderTestButton.UseVisualStyleBackColor = false;
            orderTestButton.Click += orderTestButton_Click;
            // 
            // diagnosisButton
            // 
            diagnosisButton.BackColor = Color.FromArgb(255, 255, 244);
            diagnosisButton.Enabled = false;
            diagnosisButton.FlatAppearance.BorderSize = 0;
            diagnosisButton.FlatStyle = FlatStyle.Flat;
            diagnosisButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            diagnosisButton.ForeColor = Color.Black;
            diagnosisButton.Location = new Point(0, 49);
            diagnosisButton.Name = "diagnosisButton";
            diagnosisButton.Size = new Size(143, 49);
            diagnosisButton.TabIndex = 11;
            diagnosisButton.Text = "Diagnosis";
            diagnosisButton.UseVisualStyleBackColor = false;
            diagnosisButton.Click += diagnosisButton_Click;
            // 
            // checkupButton
            // 
            checkupButton.BackColor = Color.FromArgb(255, 255, 242);
            checkupButton.FlatAppearance.BorderSize = 0;
            checkupButton.FlatStyle = FlatStyle.Flat;
            checkupButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            checkupButton.ForeColor = Color.Black;
            checkupButton.Location = new Point(0, 0);
            checkupButton.Name = "checkupButton";
            checkupButton.Size = new Size(143, 49);
            checkupButton.TabIndex = 1;
            checkupButton.Text = "Check-Up Info.";
            checkupButton.UseVisualStyleBackColor = true;
            checkupButton.Click += checkupButton_Click;
            // 
            // checkupCheckbox
            // 
            checkupCheckbox.AutoSize = true;
            checkupCheckbox.Enabled = false;
            checkupCheckbox.Location = new Point(150, 96);
            checkupCheckbox.Name = "checkupCheckbox";
            checkupCheckbox.Size = new Size(15, 14);
            checkupCheckbox.TabIndex = 28;
            checkupCheckbox.UseVisualStyleBackColor = true;
            checkupCheckbox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // diagnosisCheckbox
            // 
            diagnosisCheckbox.AutoSize = true;
            diagnosisCheckbox.Enabled = false;
            diagnosisCheckbox.Location = new Point(150, 142);
            diagnosisCheckbox.Name = "diagnosisCheckbox";
            diagnosisCheckbox.Size = new Size(15, 14);
            diagnosisCheckbox.TabIndex = 29;
            diagnosisCheckbox.UseVisualStyleBackColor = true;
            // 
            // completedCheckbox
            // 
            completedCheckbox.AutoSize = true;
            completedCheckbox.Enabled = false;
            completedCheckbox.Location = new Point(150, 180);
            completedCheckbox.Name = "completedCheckbox";
            completedCheckbox.Size = new Size(15, 14);
            completedCheckbox.TabIndex = 30;
            completedCheckbox.UseVisualStyleBackColor = true;
            // 
            // completeInformationGroupbox
            // 
            completeInformationGroupbox.Controls.Add(orderedTestsGridview);
            completeInformationGroupbox.Controls.Add(label4);
            completeInformationGroupbox.Controls.Add(finalDiagnosisLabelSummary);
            completeInformationGroupbox.Controls.Add(initialDiagnosisLabelSummary);
            completeInformationGroupbox.Controls.Add(symptomsLabelSummary);
            completeInformationGroupbox.Controls.Add(pulseLabelSummary);
            completeInformationGroupbox.Controls.Add(temperatureLabelSummary);
            completeInformationGroupbox.Controls.Add(bloodpressureLabelSummary);
            completeInformationGroupbox.Controls.Add(heightLabelSummary);
            completeInformationGroupbox.Controls.Add(weightLabelSummary);
            completeInformationGroupbox.ForeColor = Color.FromArgb(244, 244, 242);
            completeInformationGroupbox.Location = new Point(266, 193);
            completeInformationGroupbox.Name = "completeInformationGroupbox";
            completeInformationGroupbox.Size = new Size(530, 383);
            completeInformationGroupbox.TabIndex = 31;
            completeInformationGroupbox.TabStop = false;
            completeInformationGroupbox.Text = "Information Summary";
            completeInformationGroupbox.Visible = false;
            // 
            // orderedTestsGridview
            // 
            orderedTestsGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderedTestsGridview.Location = new Point(134, 277);
            orderedTestsGridview.Name = "orderedTestsGridview";
            orderedTestsGridview.Size = new Size(346, 96);
            orderedTestsGridview.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 277);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 9;
            label4.Text = "Ordered Tests :";
            // 
            // finalDiagnosisLabelSummary
            // 
            finalDiagnosisLabelSummary.AutoSize = true;
            finalDiagnosisLabelSummary.Location = new Point(42, 232);
            finalDiagnosisLabelSummary.Name = "finalDiagnosisLabelSummary";
            finalDiagnosisLabelSummary.Size = new Size(92, 15);
            finalDiagnosisLabelSummary.TabIndex = 8;
            finalDiagnosisLabelSummary.Text = "Final Diagnosis :";
            // 
            // initialDiagnosisLabelSummary
            // 
            initialDiagnosisLabelSummary.AutoSize = true;
            initialDiagnosisLabelSummary.Location = new Point(42, 192);
            initialDiagnosisLabelSummary.Name = "initialDiagnosisLabelSummary";
            initialDiagnosisLabelSummary.Size = new Size(96, 15);
            initialDiagnosisLabelSummary.TabIndex = 7;
            initialDiagnosisLabelSummary.Text = "Initial Diagnosis :";
            // 
            // symptomsLabelSummary
            // 
            symptomsLabelSummary.AutoSize = true;
            symptomsLabelSummary.Location = new Point(42, 148);
            symptomsLabelSummary.Name = "symptomsLabelSummary";
            symptomsLabelSummary.Size = new Size(70, 15);
            symptomsLabelSummary.TabIndex = 6;
            symptomsLabelSummary.Text = "Symptoms :";
            // 
            // pulseLabelSummary
            // 
            pulseLabelSummary.AutoSize = true;
            pulseLabelSummary.Location = new Point(42, 94);
            pulseLabelSummary.Name = "pulseLabelSummary";
            pulseLabelSummary.Size = new Size(41, 15);
            pulseLabelSummary.TabIndex = 4;
            pulseLabelSummary.Text = "Pulse :";
            // 
            // temperatureLabelSummary
            // 
            temperatureLabelSummary.AutoSize = true;
            temperatureLabelSummary.Location = new Point(275, 41);
            temperatureLabelSummary.Name = "temperatureLabelSummary";
            temperatureLabelSummary.Size = new Size(79, 15);
            temperatureLabelSummary.TabIndex = 3;
            temperatureLabelSummary.Text = "Temperature :";
            // 
            // bloodpressureLabelSummary
            // 
            bloodpressureLabelSummary.AutoSize = true;
            bloodpressureLabelSummary.Location = new Point(161, 94);
            bloodpressureLabelSummary.Name = "bloodpressureLabelSummary";
            bloodpressureLabelSummary.Size = new Size(91, 15);
            bloodpressureLabelSummary.TabIndex = 2;
            bloodpressureLabelSummary.Text = "Blood Pressure :";
            // 
            // heightLabelSummary
            // 
            heightLabelSummary.AutoSize = true;
            heightLabelSummary.Location = new Point(163, 41);
            heightLabelSummary.Name = "heightLabelSummary";
            heightLabelSummary.Size = new Size(49, 15);
            heightLabelSummary.TabIndex = 1;
            heightLabelSummary.Text = "Height :";
            // 
            // weightLabelSummary
            // 
            weightLabelSummary.AutoSize = true;
            weightLabelSummary.Location = new Point(42, 40);
            weightLabelSummary.Name = "weightLabelSummary";
            weightLabelSummary.Size = new Size(51, 15);
            weightLabelSummary.TabIndex = 0;
            weightLabelSummary.Text = "Weight :";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(244, 243, 242);
            nurseNameLabel.Location = new Point(503, 112);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(64, 17);
            nurseNameLabel.TabIndex = 32;
            nurseNameLabel.Text = "Nurse ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(244, 243, 242);
            label6.Location = new Point(600, 110);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 33;
            label6.Text = "Nurse Name:";
            // 
            // VisitInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(806, 582);
            Controls.Add(routineGroupBox);
            Controls.Add(label6);
            Controls.Add(nurseNameLabel);
            Controls.Add(diagnosisGroupbox);
            Controls.Add(completedCheckbox);
            Controls.Add(diagnosisCheckbox);
            Controls.Add(checkupCheckbox);
            Controls.Add(appointmentsButtonPanel);
            Controls.Add(patientDobLabel);
            Controls.Add(doctorNameLabel);
            Controls.Add(doctorIDLabel);
            Controls.Add(patientnameLabel);
            Controls.Add(patientIDLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Controls.Add(completeInformationGroupbox);
            Name = "VisitInformation";
            Text = "Check-Up Information";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            routineGroupBox.ResumeLayout(false);
            routineGroupBox.PerformLayout();
            diagnosisGroupbox.ResumeLayout(false);
            diagnosisGroupbox.PerformLayout();
            appointmentsButtonPanel.ResumeLayout(false);
            completeInformationGroupbox.ResumeLayout(false);
            completeInformationGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderedTestsGridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private Button back_btn;
        private Label healthCareNameLabel;
        private PictureBox symbolPictureBox;
        private Label patientIDLabel;
        private Label patientnameLabel;
        private TextBox systolicTextBox;
        private Label bpLabel;
        private TextBox temperatureTextbox;
        private Label temperatureLabel;
        private Label pulseLabel;
        private TextBox pulseTextbox;
        private Label symptomsLabel;
        private RichTextBox symptomsTextbox;
        private RichTextBox diagnosisTextbox;
        private TextBox heightTextbox;
        private Label heightLabel;
        private TextBox weightTextbox;
        private Label weightLabel;
        private Label doctorIDLabel;
        private Label diagnosisLabel;
        private Button submitButton;
        private Label errorLabel;
        private Label doctorNameLabel;
        private Label patientDobLabel;
        private GroupBox routineGroupBox;
        private GroupBox diagnosisGroupbox;
        private Button confirmBtn;
        private Label label1;
        private RichTextBox finalDiagnosisTextbox;
        private Label label3;
        private Label label2;
        private TextBox distolicTextbox;
        private Panel appointmentsButtonPanel;
        private Button diagnosisButton;
        private Button checkupButton;
        private CheckBox checkupCheckbox;
        private CheckBox diagnosisCheckbox;
        private Button orderTestButton;
        private GroupBox completeInformationGroupbox;
        private Button completedButton;
        private CheckBox completedCheckbox;
        private Label heightLabelSummary;
        private Label weightLabelSummary;
        private Label bloodpressureLabelSummary;
        private Label pulseLabelSummary;
        private Label temperatureLabelSummary;
        private Label finalDiagnosisLabelSummary;
        private Label initialDiagnosisLabelSummary;
        private Label symptomsLabelSummary;
        private Label label5;
        private Label label4;
        private DataGridView orderedTestsGridview;
        private Label nurseNameLabel;
        private Label label6;
    }
}