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
    public partial class VisitsPage : Form
    {
        private Nurse nurse;
        public VisitsPage(Nurse nurse)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.setLoggedNurseInfo();
        }

        private void setLoggedNurseInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(this.nurse);
            mainPage.Show();

            this.Close();
        }
    }
}
