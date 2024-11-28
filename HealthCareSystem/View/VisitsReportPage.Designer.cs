namespace HealthCareSystem.View
{
    partial class VisitsReportPage
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
            adminNameLabel = new Label();
            adminIdLabel = new Label();
            adminBirthdateLabel = new Label();
            visitDateOneLabel = new Label();
            visitDateTwoLabel = new Label();
            visitsReportLabel = new Label();
            testsForVisitLabel = new Label();
            visitOneDateTimePicker = new DateTimePicker();
            visitTwoDateTimePicker = new DateTimePicker();
            visitsDataGridView = new DataGridView();
            testsDataGridView = new DataGridView();
            getReportButton = new Button();
            getBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testsDataGridView).BeginInit();
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
            healthCareNamePanel.Size = new Size(650, 76);
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
            healthCareNameLabel.TabIndex = 2;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // adminNameLabel
            // 
            adminNameLabel.AutoSize = true;
            adminNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            adminNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminNameLabel.Location = new Point(37, 94);
            adminNameLabel.Name = "adminNameLabel";
            adminNameLabel.Size = new Size(49, 19);
            adminNameLabel.TabIndex = 2;
            adminNameLabel.Text = "Name:";
            // 
            // adminIdLabel
            // 
            adminIdLabel.AutoSize = true;
            adminIdLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            adminIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminIdLabel.Location = new Point(250, 94);
            adminIdLabel.Name = "adminIdLabel";
            adminIdLabel.Size = new Size(26, 19);
            adminIdLabel.TabIndex = 3;
            adminIdLabel.Text = "ID:";
            // 
            // adminBirthdateLabel
            // 
            adminBirthdateLabel.AutoSize = true;
            adminBirthdateLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            adminBirthdateLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminBirthdateLabel.Location = new Point(354, 94);
            adminBirthdateLabel.Name = "adminBirthdateLabel";
            adminBirthdateLabel.Size = new Size(41, 19);
            adminBirthdateLabel.TabIndex = 4;
            adminBirthdateLabel.Text = "DOB:";
            // 
            // visitDateOneLabel
            // 
            visitDateOneLabel.AutoSize = true;
            visitDateOneLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            visitDateOneLabel.ForeColor = Color.FromArgb(242, 243, 244);
            visitDateOneLabel.Location = new Point(34, 133);
            visitDateOneLabel.Name = "visitDateOneLabel";
            visitDateOneLabel.Size = new Size(68, 19);
            visitDateOneLabel.TabIndex = 5;
            visitDateOneLabel.Text = "Date One";
            // 
            // visitDateTwoLabel
            // 
            visitDateTwoLabel.AutoSize = true;
            visitDateTwoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            visitDateTwoLabel.ForeColor = Color.FromArgb(242, 243, 244);
            visitDateTwoLabel.Location = new Point(275, 133);
            visitDateTwoLabel.Name = "visitDateTwoLabel";
            visitDateTwoLabel.Size = new Size(68, 19);
            visitDateTwoLabel.TabIndex = 6;
            visitDateTwoLabel.Text = "Date Two";
            // 
            // visitsReportLabel
            // 
            visitsReportLabel.AutoSize = true;
            visitsReportLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            visitsReportLabel.ForeColor = Color.FromArgb(242, 243, 244);
            visitsReportLabel.Location = new Point(34, 166);
            visitsReportLabel.Name = "visitsReportLabel";
            visitsReportLabel.Size = new Size(43, 19);
            visitsReportLabel.TabIndex = 7;
            visitsReportLabel.Text = "Visits";
            // 
            // testsForVisitLabel
            // 
            testsForVisitLabel.AutoSize = true;
            testsForVisitLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            testsForVisitLabel.ForeColor = Color.FromArgb(242, 243, 244);
            testsForVisitLabel.Location = new Point(37, 385);
            testsForVisitLabel.Name = "testsForVisitLabel";
            testsForVisitLabel.Size = new Size(40, 19);
            testsForVisitLabel.TabIndex = 8;
            testsForVisitLabel.Text = "Tests";
            // 
            // visitOneDateTimePicker
            // 
            visitOneDateTimePicker.CalendarMonthBackground = Color.FromArgb(242, 243, 244);
            visitOneDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            visitOneDateTimePicker.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            visitOneDateTimePicker.Format = DateTimePickerFormat.Custom;
            visitOneDateTimePicker.Location = new Point(108, 133);
            visitOneDateTimePicker.Name = "visitOneDateTimePicker";
            visitOneDateTimePicker.ShowUpDown = true;
            visitOneDateTimePicker.Size = new Size(146, 23);
            visitOneDateTimePicker.TabIndex = 9;
            // 
            // visitTwoDateTimePicker
            // 
            visitTwoDateTimePicker.CalendarMonthBackground = Color.FromArgb(242, 243, 244);
            visitTwoDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            visitTwoDateTimePicker.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            visitTwoDateTimePicker.Format = DateTimePickerFormat.Custom;
            visitTwoDateTimePicker.Location = new Point(349, 133);
            visitTwoDateTimePicker.Name = "visitTwoDateTimePicker";
            visitTwoDateTimePicker.ShowUpDown = true;
            visitTwoDateTimePicker.Size = new Size(142, 23);
            visitTwoDateTimePicker.TabIndex = 10;
            // 
            // visitsDataGridView
            // 
            visitsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            visitsDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            visitsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsDataGridView.Location = new Point(37, 188);
            visitsDataGridView.Name = "visitsDataGridView";
            visitsDataGridView.Size = new Size(662, 187);
            visitsDataGridView.TabIndex = 11;
            // 
            // testsDataGridView
            // 
            testsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            testsDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            testsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testsDataGridView.Location = new Point(37, 407);
            testsDataGridView.Name = "testsDataGridView";
            testsDataGridView.Size = new Size(662, 197);
            testsDataGridView.TabIndex = 12;
            // 
            // getReportButton
            // 
            getReportButton.BackColor = Color.FromArgb(242, 243, 244);
            getReportButton.FlatAppearance.BorderSize = 0;
            getReportButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            getReportButton.Location = new Point(522, 127);
            getReportButton.Name = "getReportButton";
            getReportButton.Size = new Size(98, 36);
            getReportButton.TabIndex = 13;
            getReportButton.Text = "Get Report";
            getReportButton.UseVisualStyleBackColor = true;
            // 
            // getBackButton
            // 
            getBackButton.BackColor = Color.FromArgb(242, 243, 244);
            getBackButton.FlatAppearance.BorderSize = 0;
            getBackButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            getBackButton.Location = new Point(314, 610);
            getBackButton.Name = "getBackButton";
            getBackButton.Size = new Size(94, 42);
            getBackButton.TabIndex = 14;
            getBackButton.Text = "Get Back";
            getBackButton.UseVisualStyleBackColor = true;
            // 
            // VisitsReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(735, 659);
            Controls.Add(getBackButton);
            Controls.Add(getReportButton);
            Controls.Add(testsDataGridView);
            Controls.Add(visitsDataGridView);
            Controls.Add(visitTwoDateTimePicker);
            Controls.Add(visitOneDateTimePicker);
            Controls.Add(testsForVisitLabel);
            Controls.Add(visitsReportLabel);
            Controls.Add(visitDateTwoLabel);
            Controls.Add(visitDateOneLabel);
            Controls.Add(adminBirthdateLabel);
            Controls.Add(adminIdLabel);
            Controls.Add(adminNameLabel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "VisitsReportPage";
            Text = "Visits Report";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)testsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbolPictureBox;
        private Panel healthCareNamePanel;
        private Label healthCareNameLabel;
        private Label adminNameLabel;
        private Label adminIdLabel;
        private Label adminBirthdateLabel;
        private Label visitDateOneLabel;
        private Label visitDateTwoLabel;
        private Label visitsReportLabel;
        private Label testsForVisitLabel;
        private DateTimePicker visitOneDateTimePicker;
        private DateTimePicker visitTwoDateTimePicker;
        private DataGridView visitsDataGridView;
        private DataGridView testsDataGridView;
        private Button getReportButton;
        private Button getBackButton;
    }
}