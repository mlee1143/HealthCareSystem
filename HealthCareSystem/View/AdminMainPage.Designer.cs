namespace HealthCareSystem.View
{
    partial class AdminMainPage
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
            buttonsPanel = new Panel();
            logOutButton = new Button();
            poseQueriesButton = new Button();
            visitsReportButton = new Button();
            adminPictureBox = new PictureBox();
            adminWelcomeLabel = new Label();
            adminUsernameLabel = new Label();
            adminIdLabel = new Label();
            adminBirthdateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminPictureBox).BeginInit();
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
            healthCareNamePanel.Size = new Size(692, 76);
            healthCareNamePanel.TabIndex = 1;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(6, 20);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.FromArgb(93, 109, 126);
            buttonsPanel.Controls.Add(logOutButton);
            buttonsPanel.Controls.Add(poseQueriesButton);
            buttonsPanel.Controls.Add(visitsReportButton);
            buttonsPanel.Controls.Add(adminPictureBox);
            buttonsPanel.Location = new Point(0, 76);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(174, 507);
            buttonsPanel.TabIndex = 2;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(255, 255, 242);
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            logOutButton.Location = new Point(0, 261);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(174, 49);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            // 
            // poseQueriesButton
            // 
            poseQueriesButton.BackColor = Color.FromArgb(255, 255, 242);
            poseQueriesButton.FlatAppearance.BorderSize = 0;
            poseQueriesButton.FlatStyle = FlatStyle.Flat;
            poseQueriesButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            poseQueriesButton.Location = new Point(0, 212);
            poseQueriesButton.Name = "poseQueriesButton";
            poseQueriesButton.Size = new Size(174, 49);
            poseQueriesButton.TabIndex = 5;
            poseQueriesButton.Text = "Queries";
            poseQueriesButton.UseVisualStyleBackColor = true;
            // 
            // visitsReportButton
            // 
            visitsReportButton.BackColor = Color.FromArgb(255, 255, 242);
            visitsReportButton.FlatAppearance.BorderSize = 0;
            visitsReportButton.FlatStyle = FlatStyle.Flat;
            visitsReportButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            visitsReportButton.Location = new Point(0, 163);
            visitsReportButton.Name = "visitsReportButton";
            visitsReportButton.Size = new Size(174, 49);
            visitsReportButton.TabIndex = 4;
            visitsReportButton.Text = "Visits Report";
            visitsReportButton.UseVisualStyleBackColor = true;
            // 
            // adminPictureBox
            // 
            adminPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            adminPictureBox.Image = Properties.Resources.admin;
            adminPictureBox.Location = new Point(0, 0);
            adminPictureBox.Name = "adminPictureBox";
            adminPictureBox.Size = new Size(174, 160);
            adminPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            adminPictureBox.TabIndex = 3;
            adminPictureBox.TabStop = false;
            // 
            // adminWelcomeLabel
            // 
            adminWelcomeLabel.AutoSize = true;
            adminWelcomeLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            adminWelcomeLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminWelcomeLabel.Location = new Point(193, 92);
            adminWelcomeLabel.Name = "adminWelcomeLabel";
            adminWelcomeLabel.Size = new Size(97, 25);
            adminWelcomeLabel.TabIndex = 3;
            adminWelcomeLabel.Text = "Welcome ";
            // 
            // adminUsernameLabel
            // 
            adminUsernameLabel.AutoSize = true;
            adminUsernameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            adminUsernameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminUsernameLabel.Location = new Point(193, 175);
            adminUsernameLabel.Name = "adminUsernameLabel";
            adminUsernameLabel.Size = new Size(103, 25);
            adminUsernameLabel.TabIndex = 4;
            adminUsernameLabel.Text = "Username:";
            // 
            // adminIdLabel
            // 
            adminIdLabel.AutoSize = true;
            adminIdLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            adminIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminIdLabel.Location = new Point(193, 130);
            adminIdLabel.Name = "adminIdLabel";
            adminIdLabel.Size = new Size(37, 25);
            adminIdLabel.TabIndex = 5;
            adminIdLabel.Text = "ID:";
            // 
            // adminBirthdateLabel
            // 
            adminBirthdateLabel.AutoSize = true;
            adminBirthdateLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            adminBirthdateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminBirthdateLabel.Location = new Point(193, 222);
            adminBirthdateLabel.Name = "adminBirthdateLabel";
            adminBirthdateLabel.Size = new Size(56, 25);
            adminBirthdateLabel.TabIndex = 6;
            adminBirthdateLabel.Text = "DOB:";
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(779, 581);
            Controls.Add(adminBirthdateLabel);
            Controls.Add(adminIdLabel);
            Controls.Add(adminUsernameLabel);
            Controls.Add(adminWelcomeLabel);
            Controls.Add(buttonsPanel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "AdminMainPage";
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbolPictureBox;
        private Panel healthCareNamePanel;
        private Panel buttonsPanel;
        private PictureBox adminPictureBox;
        private Label healthCareNameLabel;
        private Label adminWelcomeLabel;
        private Label adminUsernameLabel;
        private Label adminIdLabel;
        private Label adminBirthdateLabel;
        private Button logOutButton;
        private Button poseQueriesButton;
        private Button visitsReportButton;
    }
}