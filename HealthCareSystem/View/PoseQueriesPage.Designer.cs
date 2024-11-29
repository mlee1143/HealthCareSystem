namespace HealthCareSystem.View
{
    partial class PoseQueriesPage
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
            poseQueryLabel = new Label();
            outputLabel = new Label();
            sqlQueryTextBox = new TextBox();
            getBackButton = new Button();
            submitButton = new Button();
            queryResultsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)queryResultsDataGridView).BeginInit();
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
            healthCareNamePanel.Size = new Size(570, 76);
            healthCareNamePanel.TabIndex = 1;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(6, 18);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // adminNameLabel
            // 
            adminNameLabel.AutoSize = true;
            adminNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            adminNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            adminNameLabel.Location = new Point(25, 93);
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
            adminIdLabel.Location = new Point(261, 93);
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
            adminBirthdateLabel.Location = new Point(365, 93);
            adminBirthdateLabel.Name = "adminBirthdateLabel";
            adminBirthdateLabel.Size = new Size(41, 19);
            adminBirthdateLabel.TabIndex = 4;
            adminBirthdateLabel.Text = "DOB:";
            // 
            // poseQueryLabel
            // 
            poseQueryLabel.AutoSize = true;
            poseQueryLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            poseQueryLabel.ForeColor = Color.FromArgb(242, 243, 244);
            poseQueryLabel.Location = new Point(25, 128);
            poseQueryLabel.Name = "poseQueryLabel";
            poseQueryLabel.Size = new Size(81, 19);
            poseQueryLabel.TabIndex = 5;
            poseQueryLabel.Text = "Pose Query";
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            outputLabel.ForeColor = Color.FromArgb(242, 243, 244);
            outputLabel.Location = new Point(25, 325);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(54, 19);
            outputLabel.TabIndex = 6;
            outputLabel.Text = "Output";
            // 
            // sqlQueryTextBox
            // 
            sqlQueryTextBox.Location = new Point(25, 150);
            sqlQueryTextBox.Multiline = true;
            sqlQueryTextBox.Name = "sqlQueryTextBox";
            sqlQueryTextBox.Size = new Size(600, 160);
            sqlQueryTextBox.TabIndex = 7;
            // 
            // getBackButton
            // 
            getBackButton.BackColor = Color.FromArgb(242, 243, 244);
            getBackButton.FlatAppearance.BorderSize = 0;
            getBackButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            getBackButton.Location = new Point(214, 530);
            getBackButton.Name = "getBackButton";
            getBackButton.Size = new Size(94, 42);
            getBackButton.TabIndex = 9;
            getBackButton.Text = "Get Back";
            getBackButton.UseVisualStyleBackColor = true;
            getBackButton.Click += getBackButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(242, 243, 244);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            submitButton.Location = new Point(348, 530);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 42);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // queryResultsDataGridView
            // 
            queryResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            queryResultsDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            queryResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            queryResultsDataGridView.Location = new Point(25, 347);
            queryResultsDataGridView.Name = "queryResultsDataGridView";
            queryResultsDataGridView.Size = new Size(600, 177);
            queryResultsDataGridView.TabIndex = 11;
            // 
            // PoseQueriesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(657, 596);
            Controls.Add(queryResultsDataGridView);
            Controls.Add(submitButton);
            Controls.Add(getBackButton);
            Controls.Add(sqlQueryTextBox);
            Controls.Add(outputLabel);
            Controls.Add(poseQueryLabel);
            Controls.Add(adminBirthdateLabel);
            Controls.Add(adminIdLabel);
            Controls.Add(adminNameLabel);
            Controls.Add(healthCareNamePanel);
            Controls.Add(symbolPictureBox);
            Name = "PoseQueriesPage";
            Text = "Pose Queries";
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)queryResultsDataGridView).EndInit();
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
        private Label poseQueryLabel;
        private Label outputLabel;
        private TextBox sqlQueryTextBox;
        private Button getBackButton;
        private Button submitButton;
        private DataGridView queryResultsDataGridView;
    }
}