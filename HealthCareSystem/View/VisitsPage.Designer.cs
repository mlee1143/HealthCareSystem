namespace HealthCareSystem.View
{
    partial class VisitsPage
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
            visitsButtonPanel = new Panel();
            backToMainButton = new Button();
            viewVisitInfoButton = new Button();
            enterDiagnosisButton = new Button();
            enterTestResultsButton = new Button();
            orderTestButton = new Button();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            visitsLabel = new Label();
            visitsDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            visitsButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitsDataGrid).BeginInit();
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
            healthCareNamePanel.Size = new Size(806, 76);
            healthCareNamePanel.TabIndex = 1;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(6, 22);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // visitsButtonPanel
            // 
            visitsButtonPanel.BackColor = Color.FromArgb(93, 109, 126);
            visitsButtonPanel.Controls.Add(backToMainButton);
            visitsButtonPanel.Controls.Add(viewVisitInfoButton);
            visitsButtonPanel.Controls.Add(enterDiagnosisButton);
            visitsButtonPanel.Controls.Add(enterTestResultsButton);
            visitsButtonPanel.Controls.Add(orderTestButton);
            visitsButtonPanel.Location = new Point(0, 82);
            visitsButtonPanel.Name = "visitsButtonPanel";
            visitsButtonPanel.Size = new Size(160, 444);
            visitsButtonPanel.TabIndex = 2;
            // 
            // backToMainButton
            // 
            backToMainButton.BackColor = Color.FromArgb(255, 255, 244);
            backToMainButton.FlatAppearance.BorderSize = 0;
            backToMainButton.FlatStyle = FlatStyle.Flat;
            backToMainButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            backToMainButton.Location = new Point(0, 200);
            backToMainButton.Name = "backToMainButton";
            backToMainButton.Size = new Size(160, 50);
            backToMainButton.TabIndex = 4;
            backToMainButton.Text = "Back To Main";
            backToMainButton.UseVisualStyleBackColor = true;
            backToMainButton.Click += backToMainButton_Click;
            // 
            // viewVisitInfoButton
            // 
            viewVisitInfoButton.BackColor = Color.FromArgb(255, 255, 244);
            viewVisitInfoButton.FlatAppearance.BorderSize = 0;
            viewVisitInfoButton.FlatStyle = FlatStyle.Flat;
            viewVisitInfoButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            viewVisitInfoButton.Location = new Point(0, 150);
            viewVisitInfoButton.Name = "viewVisitInfoButton";
            viewVisitInfoButton.Size = new Size(160, 50);
            viewVisitInfoButton.TabIndex = 3;
            viewVisitInfoButton.Text = "Visits Final Info.";
            viewVisitInfoButton.UseVisualStyleBackColor = true;
            viewVisitInfoButton.Click += viewVisitInfoButton_Click;
            // 
            // enterDiagnosisButton
            // 
            enterDiagnosisButton.BackColor = Color.FromArgb(255, 255, 244);
            enterDiagnosisButton.FlatAppearance.BorderSize = 0;
            enterDiagnosisButton.FlatStyle = FlatStyle.Flat;
            enterDiagnosisButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            enterDiagnosisButton.Location = new Point(0, 100);
            enterDiagnosisButton.Name = "enterDiagnosisButton";
            enterDiagnosisButton.Size = new Size(160, 50);
            enterDiagnosisButton.TabIndex = 2;
            enterDiagnosisButton.Text = "Enter Diagnosis";
            enterDiagnosisButton.UseVisualStyleBackColor = true;
            enterDiagnosisButton.Click += enterDiagnosisButton_Click;
            // 
            // enterTestResultsButton
            // 
            enterTestResultsButton.BackColor = Color.FromArgb(255, 255, 244);
            enterTestResultsButton.FlatAppearance.BorderSize = 0;
            enterTestResultsButton.FlatStyle = FlatStyle.Flat;
            enterTestResultsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            enterTestResultsButton.Location = new Point(0, 50);
            enterTestResultsButton.Name = "enterTestResultsButton";
            enterTestResultsButton.Size = new Size(160, 50);
            enterTestResultsButton.TabIndex = 1;
            enterTestResultsButton.Text = "Enter Test Result";
            enterTestResultsButton.UseVisualStyleBackColor = true;
            enterTestResultsButton.Click += enterTestResultsButton_Click;
            // 
            // orderTestButton
            // 
            orderTestButton.BackColor = Color.FromArgb(255, 255, 244);
            orderTestButton.FlatAppearance.BorderSize = 0;
            orderTestButton.FlatStyle = FlatStyle.Flat;
            orderTestButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            orderTestButton.Location = new Point(0, 0);
            orderTestButton.Name = "orderTestButton";
            orderTestButton.Size = new Size(160, 50);
            orderTestButton.TabIndex = 0;
            orderTestButton.Text = "Order Test";
            orderTestButton.UseVisualStyleBackColor = true;
            orderTestButton.Click += orderTestButton_Click;
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(166, 92);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(104, 21);
            nurseNameLabel.TabIndex = 3;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(413, 92);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(77, 21);
            nurseIdLabel.TabIndex = 4;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // visitsLabel
            // 
            visitsLabel.AutoSize = true;
            visitsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            visitsLabel.ForeColor = Color.FromArgb(242, 243, 244);
            visitsLabel.Location = new Point(166, 176);
            visitsLabel.Name = "visitsLabel";
            visitsLabel.Size = new Size(241, 21);
            visitsLabel.TabIndex = 5;
            visitsLabel.Text = "Visits with check-up completed:";
            // 
            // visitsDataGrid
            // 
            visitsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            visitsDataGrid.BackgroundColor = Color.FromArgb(93, 173, 226);
            visitsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsDataGrid.Location = new Point(166, 200);
            visitsDataGrid.Name = "visitsDataGrid";
            visitsDataGrid.ReadOnly = true;
            visitsDataGrid.Size = new Size(715, 314);
            visitsDataGrid.TabIndex = 6;
            // 
            // VisitsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(893, 526);
            Controls.Add(visitsDataGrid);
            Controls.Add(visitsLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(visitsButtonPanel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "VisitsPage";
            Text = "Visits";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            visitsButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbolPictureBox;
        private Panel healthCareNamePanel;
        private Panel visitsButtonPanel;
        private Label healthCareNameLabel;
        private Button viewVisitInfoButton;
        private Button enterDiagnosisButton;
        private Button enterTestResultsButton;
        private Button orderTestButton;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Label visitsLabel;
        private DataGridView visitsDataGrid;
        private Button backToMainButton;
    }
}