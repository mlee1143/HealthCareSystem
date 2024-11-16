namespace HealthCareSystem.View
{
    partial class OrderTestPage
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
            testOptionsComboBox = new ComboBox();
            addTestButton = new Button();
            removeTestButton = new Button();
            selectedTestsListView = new ListView();
            cancelButton = new Button();
            orderTests = new Button();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
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
            healthCareNamePanel.Size = new Size(560, 76);
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
            nurseNameLabel.Location = new Point(12, 91);
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
            nurseIdLabel.Location = new Point(192, 91);
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
            doctorNameLabel.Location = new Point(341, 91);
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
            doctorIdLabel.Location = new Point(518, 91);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(71, 19);
            doctorIdLabel.TabIndex = 5;
            doctorIdLabel.Text = "Doctor Id:";
            // 
            // patientInfoLabel
            // 
            patientInfoLabel.AutoSize = true;
            patientInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            patientInfoLabel.ForeColor = Color.FromArgb(242, 243, 244);
            patientInfoLabel.Location = new Point(12, 139);
            patientInfoLabel.Name = "patientInfoLabel";
            patientInfoLabel.Size = new Size(149, 19);
            patientInfoLabel.TabIndex = 6;
            patientInfoLabel.Text = "Order Test For Patient:";
            // 
            // testOptionsComboBox
            // 
            testOptionsComboBox.BackColor = Color.FromArgb(242, 243, 244);
            testOptionsComboBox.Font = new Font("Segoe UI", 10F);
            testOptionsComboBox.FormattingEnabled = true;
            testOptionsComboBox.Location = new Point(12, 162);
            testOptionsComboBox.Name = "testOptionsComboBox";
            testOptionsComboBox.Size = new Size(392, 25);
            testOptionsComboBox.TabIndex = 7;
            // 
            // addTestButton
            // 
            addTestButton.BackColor = Color.FromArgb(255, 255, 242);
            addTestButton.FlatAppearance.BorderSize = 0;
            addTestButton.FlatStyle = FlatStyle.Flat;
            addTestButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            addTestButton.Location = new Point(426, 160);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(80, 26);
            addTestButton.TabIndex = 8;
            addTestButton.Text = "Add Test";
            addTestButton.UseVisualStyleBackColor = true;
            // 
            // removeTestButton
            // 
            removeTestButton.BackColor = Color.FromArgb(255, 255, 242);
            removeTestButton.FlatAppearance.BorderSize = 0;
            removeTestButton.FlatStyle = FlatStyle.Flat;
            removeTestButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            removeTestButton.Location = new Point(555, 160);
            removeTestButton.Name = "removeTestButton";
            removeTestButton.Size = new Size(80, 26);
            removeTestButton.TabIndex = 9;
            removeTestButton.Text = "Remove Test";
            removeTestButton.UseVisualStyleBackColor = true;
            // 
            // selectedTestsListView
            // 
            selectedTestsListView.Font = new Font("Segoe UI", 12F);
            selectedTestsListView.Location = new Point(12, 205);
            selectedTestsListView.Name = "selectedTestsListView";
            selectedTestsListView.Size = new Size(623, 190);
            selectedTestsListView.TabIndex = 10;
            selectedTestsListView.UseCompatibleStateImageBehavior = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 255, 242);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cancelButton.Location = new Point(207, 408);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 30);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // orderTests
            // 
            orderTests.BackColor = Color.FromArgb(255, 255, 242);
            orderTests.FlatAppearance.BorderSize = 0;
            orderTests.FlatStyle = FlatStyle.Flat;
            orderTests.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            orderTests.Location = new Point(347, 408);
            orderTests.Name = "orderTests";
            orderTests.Size = new Size(90, 30);
            orderTests.TabIndex = 12;
            orderTests.Text = "OrderTests";
            orderTests.UseVisualStyleBackColor = true;
            // 
            // OrderTestPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(647, 450);
            Controls.Add(orderTests);
            Controls.Add(cancelButton);
            Controls.Add(selectedTestsListView);
            Controls.Add(removeTestButton);
            Controls.Add(addTestButton);
            Controls.Add(testOptionsComboBox);
            Controls.Add(patientInfoLabel);
            Controls.Add(doctorIdLabel);
            Controls.Add(doctorNameLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "OrderTestPage";
            Text = "Order Test Page";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
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
        private ComboBox testOptionsComboBox;
        private Button addTestButton;
        private Button removeTestButton;
        private ListView selectedTestsListView;
        private Button cancelButton;
        private Button orderTests;
    }
}