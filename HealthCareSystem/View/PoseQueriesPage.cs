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
    public partial class PoseQueriesPage : Form
    {
        private Administrator administrator;

        public PoseQueriesPage(Administrator admin)
        {
            InitializeComponent();

            this.administrator = admin;

            this.setAdminInformation();
        }

        private void setAdminInformation()
        {
            adminNameLabel.Text = $"Name: {this.administrator.Firstname} {this.administrator.Lastname}";
            adminIdLabel.Text = $"ID: {this.administrator.AdministratorId}";
            adminBirthdateLabel.Text = $"DOB: {this.administrator.Birthdate.ToString("yyyy-MM-dd")}";
        }

        private void getBackButton_Click(object sender, EventArgs e)
        {
            AdminMainPage mainPage = new AdminMainPage(this.administrator);
            mainPage.Show();

            this.Close();
        }
    }
}
