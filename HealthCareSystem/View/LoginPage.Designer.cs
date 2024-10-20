namespace HealthCareSystem.View
{
    partial class LoginPage
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
            healthCareNameLabel = new Label();
            healthCareTopPanel = new Panel();
            symbolPictureBox = new PictureBox();
            loginLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            healthCareTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).BeginInit();
            SuspendLayout();
            // 
            // healthCareNameLabel
            // 
            healthCareNameLabel.AutoSize = true;
            healthCareNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            healthCareNameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            healthCareNameLabel.Location = new Point(9, 16);
            healthCareNameLabel.Name = "healthCareNameLabel";
            healthCareNameLabel.Size = new Size(298, 32);
            healthCareNameLabel.TabIndex = 0;
            healthCareNameLabel.Text = "UWG Health Care System";
            // 
            // healthCareTopPanel
            // 
            healthCareTopPanel.BackColor = Color.FromArgb(93, 109, 126);
            healthCareTopPanel.Controls.Add(healthCareNameLabel);
            healthCareTopPanel.Location = new Point(70, -7);
            healthCareTopPanel.Name = "healthCareTopPanel";
            healthCareTopPanel.Size = new Size(344, 68);
            healthCareTopPanel.TabIndex = 1;
            // 
            // symbolPictureBox
            // 
            symbolPictureBox.BackColor = Color.FromArgb(242, 243, 244);
            symbolPictureBox.Image = Properties.Resources.Symbol;
            symbolPictureBox.Location = new Point(0, -4);
            symbolPictureBox.Name = "symbolPictureBox";
            symbolPictureBox.Size = new Size(73, 65);
            symbolPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            symbolPictureBox.TabIndex = 2;
            symbolPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Arial Rounded MT Bold", 35F);
            loginLabel.ForeColor = Color.FromArgb(242, 243, 244);
            loginLabel.Location = new Point(124, 120);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(149, 54);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Login";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Arial Rounded MT Bold", 14.25F);
            usernameLabel.ForeColor = Color.FromArgb(242, 243, 244);
            usernameLabel.Location = new Point(147, 202);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(103, 22);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial Rounded MT Bold", 14.25F);
            passwordLabel.ForeColor = Color.FromArgb(242, 243, 244);
            passwordLabel.Location = new Point(147, 282);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 22);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 255, 242);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(147, 379);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(105, 45);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(255, 255, 242);
            usernameTextBox.ForeColor = Color.Black;
            usernameTextBox.Location = new Point(89, 227);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(220, 22);
            usernameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(255, 255, 242);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(89, 307);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            //passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(220, 22);
            passwordTextBox.TabIndex = 8;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 116, 166);
            ClientSize = new Size(411, 548);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(loginLabel);
            Controls.Add(symbolPictureBox);
            Controls.Add(healthCareTopPanel);
            Name = "LoginPage";
            Text = "LoginPage";
            healthCareTopPanel.ResumeLayout(false);
            healthCareTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label healthCareNameLabel;
        private Panel healthCareTopPanel;
        private PictureBox symbolPictureBox;
        private Label loginLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
    }
}