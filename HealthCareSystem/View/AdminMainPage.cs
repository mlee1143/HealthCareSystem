using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareSystem.View
{
    public partial class AdminMainPage : Form
    {
        private Administrator administrator;

        public AdminMainPage(Administrator admin)
        {
            InitializeComponent();

            this.administrator = admin;
        }

        private void setAdminInformation()
        {
            adminWelcomeLabel.Text = $"Welcome, {this.administrator.Firstname} {this.administrator.Lastname}!";
            adminIdLabel.Text = $"ID: {this.administrator.AdministratorId}";
            adminUsernameLabel.Text = $"Username: {this.administrator.Username}";
            adminBirthdateLabel.Text = $"DOB: {this.administrator.Birthdate}";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();

            this.Close();
        }

        private void visitsReportButton_Click(object sender, EventArgs e)
        {

        }

        private void poseQueriesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
