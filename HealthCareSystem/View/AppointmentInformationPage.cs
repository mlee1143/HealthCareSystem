using HealthCareSystem.DAL;
using HealthCareSystem.Model;
using MySqlConnector;
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
        private DoctorDAL doctorDAL;
        private PatientDAL patientDAL;
        private AppointmentDAL appointmentDAL;

        public AppointmentInformationPage()
        {
            InitializeComponent();
            this.doctorDAL = new DoctorDAL();
            this.patientDAL = new PatientDAL();
            this.appointmentDAL = new AppointmentDAL();

            this.loadDoctors();
            this.loadActivePatients();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointments = new AppointmentsPage();
            appointments.Show();

            this.Close();
        }

        private void loadDoctors()
        {
            List<Doctor> doctors = doctorDAL.GetAllDoctors();

            doctorComboBox.DisplayMember = "FullName";
            doctorComboBox.ValueMember = "DoctorId";
            doctorComboBox.DataSource = doctors;
        }

        private void loadActivePatients()
        {
            List<Patient> activePatients = patientDAL.GetActivePatients();

            patientComboBox.DisplayMember = "FullName";
            patientComboBox.ValueMember = "PatientID";
            patientComboBox.DataSource = activePatients;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = (int)patientComboBox.SelectedValue;
                int doctorId = (int)doctorComboBox.SelectedValue;
                DateTime appointmentDateTime = apptDateTimePicker.Value;
                string reason = reasonTextBox.Text;
                Appointment newAppointment = new Appointment(patientId, doctorId, appointmentDateTime, reason);

                if (appointmentDAL.AppointmentExists(patientId, doctorId, appointmentDateTime))
                {
                    MessageBox.Show("This appointment already exists. Please select a different date or time.");
                    return;
                }

                bool success = appointmentDAL.InsertAppointment(newAppointment);

                if (success)
                {
                    MessageBox.Show("Appointment created successfully.");
                    AppointmentsPage appointments = new AppointmentsPage();
                    appointments.Show();

                    this.Close()
                }
                else
                {
                    MessageBox.Show("Failed to create the appointment. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
