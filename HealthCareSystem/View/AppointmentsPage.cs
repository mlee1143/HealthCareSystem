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
    public partial class AppointmentsPage : Form
    {
        public AppointmentsPage()
        {
            InitializeComponent();
        }

        private void newAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentInformationPage appointmentInformationPage = new AppointmentInformationPage();
            appointmentInformationPage.Show();

            this.Close();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(0, "cobra");
            mainPage.Show();

            this.Close();
        }
    }
}
