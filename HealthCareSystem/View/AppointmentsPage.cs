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
    public partial class AppointmentsPage : Form
    {
        private AppointmentDAL appointmentDAL;

        public AppointmentsPage()
        {
            InitializeComponent();
            this.appointmentDAL = new AppointmentDAL();

            this.loadAppointments();
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

        private void loadAppointments()
        {
            List<Appointment> appointments = this.appointmentDAL.getAllAppointments();
            //appointmentsDataGridView.DataSource = appointments;

            appointmentsDataGridView.Columns.Clear();
            appointmentsDataGridView.Columns.Add("PatientID", "Patient ID");
            appointmentsDataGridView.Columns.Add("DoctorID", "Doctor ID");
            appointmentsDataGridView.Columns.Add("AppointmentDateTime", "Date/Time");

            appointmentsDataGridView.Rows.Clear();


            foreach (var appointment in appointments)
            {
                appointmentsDataGridView.Rows.Add(appointment.PatientID, appointment.DoctorID, appointment.AppointmentDateTime);
            }
        }

        private void editAppointment_Click(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedRows.Count > 0)
            {
                int patientId = (int)appointmentsDataGridView.SelectedRows[0].Cells["PatientId"].Value;
                DateTime appointmentDateTime = (DateTime)appointmentsDataGridView.SelectedRows[0].Cells["AppointmentDateTime"].Value;

                AppointmentInformationPage editPage = new AppointmentInformationPage(patientId, appointmentDateTime);
                editPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.");
            }
        }
    }
}
