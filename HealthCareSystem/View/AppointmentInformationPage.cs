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
    public partial class AppointmentInformationPage : Form
    {
        public AppointmentInformationPage()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointments = new AppointmentsPage();
            appointments.Show();

            this.Close();
        }
    }
}
