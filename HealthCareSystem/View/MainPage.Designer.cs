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
            editPatientButton = new Button();
            logoutButton = new Button();
            registerPatientButton = new Button();
            genericNursePictureBox = new PictureBox();
            idLabel = new Label();
            registeredPatiensDataGridView = new DataGridView();
            patientsLabel = new Label();
            errormessageLabel = new Label();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genericNursePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registeredPatiensDataGridView).BeginInit();
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
            buttonsPanel.Controls.Add(editPatientButton);
            buttonsPanel.Controls.Add(logoutButton);
            buttonsPanel.Controls.Add(registerPatientButton);
            buttonsPanel.Controls.Add(genericNursePictureBox);
            buttonsPanel.Location = new Point(0, 76);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(174, 541);
            buttonsPanel.TabIndex = 3;
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
            logoutButton.Location = new Point(0, 255);
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
            registeredPatiensDataGridView.Location = new Point(180, 241);
            registeredPatiensDataGridView.Name = "registeredPatiensDataGridView";
            registeredPatiensDataGridView.Size = new Size(595, 362);
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
            errormessageLabel.Location = new Point(388, 219);
            errormessageLabel.Name = "errormessageLabel";
            errormessageLabel.Size = new Size(35, 15);
            errormessageLabel.TabIndex = 7;
            errormessageLabel.Text = "Error:";
            errormessageLabel.Visible = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(779, 615);
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
    }
}