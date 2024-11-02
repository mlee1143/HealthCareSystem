namespace HealthCareSystem.View
{
    partial class AppointmentsPage
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
            appointmentsButtonPanel = new Panel();
            backToMainButton = new Button();
            editAppointment = new Button();
            newAppointmentButton = new Button();
            appointmentsDataGridView = new DataGridView();
            nurseNameLabel = new Label();
            nurseIdLabel = new Label();
            appointmentsLabel = new Label();
            errorLabel = new Label();
            healthCareNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            appointmentsButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // healthCareNamePanel
            // 
            healthCareNamePanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareNamePanel.Controls.Add(healthCareNameLabel);
            healthCareNamePanel.Location = new Point(87, 0);
            healthCareNamePanel.Name = "healthCareNamePanel";
            healthCareNamePanel.Size = new Size(558, 76);
            healthCareNamePanel.TabIndex = 0;
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(7, 23);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(0, 0);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(87, 76);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 1;
            symbolPictureBox.TabStop = false;
            // 
            // appointmentsButtonPanel
            // 
            appointmentsButtonPanel.BackColor = Color.FromArgb(93, 109, 126);
            appointmentsButtonPanel.Controls.Add(backToMainButton);
            appointmentsButtonPanel.Controls.Add(editAppointment);
            appointmentsButtonPanel.Controls.Add(newAppointmentButton);
            appointmentsButtonPanel.Location = new Point(0, 80);
            appointmentsButtonPanel.Name = "appointmentsButtonPanel";
            appointmentsButtonPanel.Size = new Size(160, 411);
            appointmentsButtonPanel.TabIndex = 2;
            // 
            // backToMainButton
            // 
            backToMainButton.BackColor = Color.FromArgb(255, 255, 242);
            backToMainButton.FlatAppearance.BorderSize = 0;
            backToMainButton.FlatStyle = FlatStyle.Flat;
            backToMainButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            backToMainButton.ForeColor = Color.Black;
            backToMainButton.Location = new Point(0, 94);
            backToMainButton.Name = "backToMainButton";
            backToMainButton.Size = new Size(160, 47);
            backToMainButton.TabIndex = 2;
            backToMainButton.Text = "Back To Main";
            backToMainButton.UseVisualStyleBackColor = true;
            // 
            // editAppointment
            // 
            editAppointment.BackColor = Color.FromArgb(255, 255, 242);
            editAppointment.FlatAppearance.BorderSize = 0;
            editAppointment.FlatStyle = FlatStyle.Flat;
            editAppointment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            editAppointment.ForeColor = Color.Black;
            editAppointment.Location = new Point(0, 47);
            editAppointment.Name = "editAppointment";
            editAppointment.Size = new Size(160, 47);
            editAppointment.TabIndex = 1;
            editAppointment.Text = "Edit Appointment";
            editAppointment.UseVisualStyleBackColor = true;
            // 
            // newAppointmentButton
            // 
            newAppointmentButton.BackColor = Color.FromArgb(255, 255, 242);
            newAppointmentButton.FlatAppearance.BorderSize = 0;
            newAppointmentButton.FlatStyle = FlatStyle.Flat;
            newAppointmentButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            newAppointmentButton.ForeColor = Color.Black;
            newAppointmentButton.Location = new Point(0, 0);
            newAppointmentButton.Name = "newAppointmentButton";
            newAppointmentButton.Size = new Size(160, 47);
            newAppointmentButton.TabIndex = 0;
            newAppointmentButton.Text = "New Appointment";
            newAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentsDataGridView.BackgroundColor = Color.FromArgb(93, 173, 226);
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDataGridView.Location = new Point(166, 163);
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.Size = new Size(473, 316);
            appointmentsDataGridView.TabIndex = 3;
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nurseNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseNameLabel.Location = new Point(166, 79);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new Size(57, 21);
            nurseNameLabel.TabIndex = 4;
            nurseNameLabel.Text = "Name:";
            // 
            // nurseIdLabel
            // 
            nurseIdLabel.AutoSize = true;
            nurseIdLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nurseIdLabel.ForeColor = Color.FromArgb(242, 243, 244);
            nurseIdLabel.Location = new Point(349, 79);
            nurseIdLabel.Name = "nurseIdLabel";
            nurseIdLabel.Size = new Size(77, 21);
            nurseIdLabel.TabIndex = 5;
            nurseIdLabel.Text = "Nurse ID:";
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.AutoSize = true;
            appointmentsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            appointmentsLabel.ForeColor = Color.FromArgb(242, 243, 244);
            appointmentsLabel.Location = new Point(166, 139);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(115, 21);
            appointmentsLabel.TabIndex = 6;
            appointmentsLabel.Text = "Appointments";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(349, 139);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(52, 21);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "Error: ";
            errorLabel.Visible = false;
            // 
            // AppointmentsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(644, 491);
            Controls.Add(errorLabel);
            Controls.Add(appointmentsLabel);
            Controls.Add(nurseIdLabel);
            Controls.Add(nurseNameLabel);
            Controls.Add(appointmentsDataGridView);
            Controls.Add(appointmentsButtonPanel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareNamePanel);
            Name = "AppointmentsPage";
            Text = "Appointments";
            healthCareNamePanel.ResumeLayout(false);
            healthCareNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            appointmentsButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel healthCareNamePanel;
        private PictureBox symbolPictureBox;
        private Panel appointmentsButtonPanel;
        private DataGridView appointmentsDataGridView;
        private Label nurseNameLabel;
        private Label nurseIdLabel;
        private Label appointmentsLabel;
        private Label healthCareNameLabel;
        private Button backToMainButton;
        private Button editAppointment;
        private Button newAppointmentButton;
        private Label errorLabel;
    }
}