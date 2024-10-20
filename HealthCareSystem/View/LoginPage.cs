using HealthCareSystem.DAL;
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
    public partial class LoginPage : Form
    {
        private NurseDAL nurseDAL;
        public LoginPage()
        {
            InitializeComponent();
            this.nurseDAL = new NurseDAL();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            Nurse nurse = nurseDAL.ValidateNurseLogin(enteredUsername, enteredPassword);

            if (nurse != null)
            {
                MainPage mainPage = new MainPage();
                mainPage.SetNurseInfo(nurse.NurseId, $"{nurse.Firstname} {nurse.Lastname}");
                mainPage.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
