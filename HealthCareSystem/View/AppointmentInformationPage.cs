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
        private int patientId;
        private DateTime originalDateTime;

        public AppointmentInformationPage()
        {
            InitializeComponent();
            this.doctorDAL = new DoctorDAL();
            this.patientDAL = new PatientDAL();
            this.appointmentDAL = new AppointmentDAL();

            this.loadDoctors();
            this.loadActivePatients();
        }


        public AppointmentInformationPage(int patientId, DateTime appointmentDateTime)
        {
            InitializeComponent();
            this.appointmentDAL = new AppointmentDAL();
            this.doctorDAL = new DoctorDAL();
            this.patientDAL = new PatientDAL();
            loadActivePatients();
            loadDoctors();

            this.patientId = patientId;
            this.originalDateTime = appointmentDateTime;
            LoadAppointmentData();
        }

        private void LoadAppointmentData()
        {
            var appointment = appointmentDAL.GetAppointment(patientId, originalDateTime);

            if (appointment != null)
            {
                patientComboBox.SelectedValue = appointment.PatientID;
                doctorComboBox.SelectedValue = appointment.DoctorID;
                apptDateTimePicker.Value = appointment.AppointmentDateTime;
                reasonTextBox.Text = appointment.Reason;
            }
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

            if (string.IsNullOrWhiteSpace(reasonTextBox.Text))
            {
                MessageBox.Show("Please enter a reason for the appointment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int patientId = (int)patientComboBox.SelectedValue;
                int doctorId = (int)doctorComboBox.SelectedValue;
                DateTime appointmentDateTime = apptDateTimePicker.Value;
                string reason = reasonTextBox.Text;
                Appointment newAppointment = new Appointment(patientId, doctorId, appointmentDateTime, reason);

                if (appointmentDAL.AppointmentExists(newAppointment))
                {
                    MessageBox.Show("This appointment already exists. Please select a different date or time.");
                    return;
                }

                if (appointmentDAL.DoctorAppointmentExists(doctorId, appointmentDateTime))
                {
                    MessageBox.Show("This doctor is already booked at the selected date and time. Please choose a different time.");
                    return;
                }

                bool success = appointmentDAL.InsertAppointment(newAppointment);

                if (success)
                {
                    MessageBox.Show("Appointment created successfully.");
                    AppointmentsPage appointments = new AppointmentsPage();
                    appointments.Show();

                    this.Close();
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
