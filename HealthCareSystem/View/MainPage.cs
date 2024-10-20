using Microsoft.VisualBasic.Logging;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SetNurseInfo(int nurseId, string nurseName)
        {
            welcomeNameLabel.Text = $"Welcome, {nurseName}";
            idLabel.Text = $"Nurse ID: {nurseId}";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();

            this.Close();
        }
    }
}
