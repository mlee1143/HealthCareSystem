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
        private int originalPatientId;
        private DateTime originalDateTime;
        private Nurse nurse;
        private List<Patient>? allPatients;
        private List<Doctor>? allDoctors;
        private bool bypassEvent = false;

        public AppointmentInformationPage(Nurse nurse)
        {
            InitializeComponent();
            this.doctorDAL = new DoctorDAL();
            this.patientDAL = new PatientDAL();
            this.appointmentDAL = new AppointmentDAL();
           
            this.nurse = nurse;

            this.setNurseInformation();
            this.loadDoctors();
            this.loadActivePatients();
        }


        public AppointmentInformationPage(Nurse nurse, int patientId, DateTime appointmentDateTime)
        {
            InitializeComponent();
            this.appointmentDAL = new AppointmentDAL();
            this.doctorDAL = new DoctorDAL();
            this.patientDAL = new PatientDAL();

            this.nurse = nurse;

            this.originalPatientId = patientId;
            this.originalDateTime = appointmentDateTime;

            this.setNurseInformation();
            this.loadActivePatients();
            this.loadDoctors();
            this.loadAppointmentData();
        }

        private void setNurseInformation()
        {
            nurseNameLabel.Text = $"Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
        }

        private void loadAppointmentData()
        {
            var appointment = appointmentDAL.GetAppointment(this.originalPatientId, this.originalDateTime);

            if (appointment != null)
            {
                patientComboBox.SelectedValue = appointment.PatientID;
                doctorComboBox.SelectedValue = appointment.DoctorID;
                apptDateTimePicker.Value = appointment.AppointmentDateTime;
                reasonTextBox.Text = appointment.Reason;

                if (appointment.AppointmentDateTime < DateTime.Now)
                {
                    MessageBox.Show("This appointment is in the past and cannot be edited.", "Edit Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    patientComboBox.Enabled = false;
                    doctorComboBox.Enabled = false;
                    apptDateTimePicker.Enabled = false;
                    reasonTextBox.Enabled = false;
                    saveButton.Enabled = false;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointments = new AppointmentsPage(this.nurse);
            appointments.Show();

            this.Close();
        }

        private void loadDoctors()
        {
            this.allDoctors = doctorDAL.GetAllDoctors();

            doctorComboBox.DisplayMember = "FullName";
            doctorComboBox.ValueMember = "DoctorId";
            doctorComboBox.DataSource = this.allDoctors;
        }

        private void loadActivePatients()
        {
            this.allPatients = patientDAL.GetActivePatients();

            patientComboBox.DisplayMember = "FullName";
            patientComboBox.ValueMember = "PatientId";
            patientComboBox.DataSource = this.allPatients;
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
                int newPatientId = (int)patientComboBox.SelectedValue;
                int doctorId = (int)doctorComboBox.SelectedValue;
                DateTime newDateTime = apptDateTimePicker.Value;
                string reason = reasonTextBox.Text;
                Appointment appointment = new Appointment(newPatientId, doctorId, newDateTime, reason);

                if (this.originalDateTime != DateTime.MinValue)
                {
                    if (isDoctorDoubleBooked(doctorId, newDateTime, this.originalPatientId, this.originalDateTime))
                    {
                        return;
                    }

                    if (updateExistingAppointment(this.originalPatientId, this.originalDateTime, appointment))
                    {
                        AppointmentsPage appointments = new AppointmentsPage(this.nurse);
                        appointments.Show();
                        this.Close();
                    }
                }
                else
                {
                    if (isDoctorDoubleBooked(doctorId, newDateTime))
                    {
                        return;
                    }

                    if (insertNewAppointment(appointment))
                    {
                        AppointmentsPage appointments = new AppointmentsPage(this.nurse);
                        appointments.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private bool isDoctorDoubleBooked(int doctorId, DateTime appointmentDateTime, int? excludePatientId = null, DateTime? excludeDateTime = null)
        {
            if (appointmentDAL.DoctorAppointmentExists(doctorId, appointmentDateTime, excludePatientId, excludeDateTime))
            {
                MessageBox.Show("This doctor is already booked at the selected date and time. Please choose a different time.");
                return true;
            }
            return false;
        }


        private bool insertNewAppointment(Appointment newAppointment)
        {
            if (appointmentDAL.AppointmentExists(newAppointment))
            {
                MessageBox.Show("This appointment already exists. Please select a different date or time.");
                return false;
            }

            bool success = appointmentDAL.InsertAppointment(newAppointment);
            if (success)
            {
                MessageBox.Show("Appointment created successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Failed to create the appointment. Please try again.");
                return false;
            }
        }

        private bool updateExistingAppointment(int originalPatientId, DateTime originalDateTime, Appointment updatedAppointment)
        {
            bool success = appointmentDAL.UpdateAppointment(
                originalPatientId,
                originalDateTime,
                updatedAppointment
            );

            if (success)
            {
                MessageBox.Show("Appointment updated successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Failed to update the appointment. Please try again.");
                return false;
            }
        }

        private void patientComboBox_TextChanged(object sender, EventArgs e)
        {
            if (bypassEvent) return;

            string searchText = patientComboBox.Text.ToLower();

            bypassEvent = true;

            var filteredPatients = this.allPatients
                .Where(p => p.FullName.ToLower().Contains(searchText))
                .ToList();

           
            patientComboBox.DisplayMember = "FullName";
            patientComboBox.ValueMember = "PatientId";
            patientComboBox.DataSource = filteredPatients;

            patientComboBox.Text = searchText;
            patientComboBox.SelectionStart = searchText.Length;
            patientComboBox.SelectionLength = 0;

            bypassEvent = false;
        }

        private void doctorComboBox_TextChanged(object sender, EventArgs e)
        {
            if (bypassEvent) return;

            string searchText = doctorComboBox.Text.ToLower();

            bypassEvent = true;

            var filteredDoctors = this.allDoctors
                .Where(d => d.FullName.ToLower().Contains(searchText))
                .ToList();

            doctorComboBox.DataSource = filteredDoctors;
            doctorComboBox.DisplayMember = "FullName";
            doctorComboBox.ValueMember = "DoctorId";

            doctorComboBox.Text = searchText;
            doctorComboBox.SelectionStart = searchText.Length;
            doctorComboBox.SelectionLength = 0;

            bypassEvent = false;
        }
    }
}
