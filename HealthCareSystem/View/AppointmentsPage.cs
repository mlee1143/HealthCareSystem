using HealthCareSystem.DAL;
using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private PatientDAL patientDAL;

        private Nurse nurse;

        public AppointmentsPage(Nurse nurse)
        {
            InitializeComponent();
            this.appointmentDAL = new AppointmentDAL();
            this.patientDAL = new PatientDAL();

            this.nurse = nurse;

            this.loadAppointments();
        }

        private void newAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentInformationPage appointmentInformationPage = new AppointmentInformationPage(this.nurse);
            appointmentInformationPage.Show();

            this.Close();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(this.nurse);
            mainPage.Show();

            this.Close();
        }

        private void loadAppointments()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";

            var appointments = appointmentDAL.getAllAppointmentsWithDetails();

            appointmentsDataGridView.Columns.Clear();
            appointmentsDataGridView.Columns.Add("PatientID", "Patient ID");
            appointmentsDataGridView.Columns.Add("PatientName", "Patient Name");
            appointmentsDataGridView.Columns.Add("DoctorID", "Doctor ID");
            appointmentsDataGridView.Columns.Add("DoctorName", "Doctor Name");
            appointmentsDataGridView.Columns.Add("AppointmentDateTime", "Date/Time");

            appointmentsDataGridView.Rows.Clear();

            foreach (var appointment in appointments)
            {
                appointmentsDataGridView.Rows.Add(
                    appointment.PatientID,
                    appointment.PatientName,
                    appointment.DoctorID,
                    appointment.DoctorName,
                    appointment.AppointmentDateTime
                );
            }
        }

        private void editAppointment_Click(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedRows.Count > 0)
            {
                int patientId = (int)appointmentsDataGridView.SelectedRows[0].Cells["PatientId"].Value;
                DateTime appointmentDateTime = (DateTime)appointmentsDataGridView.SelectedRows[0].Cells["AppointmentDateTime"].Value;

                if (appointmentDateTime < DateTime.Now)
                {
                    MessageBox.Show(
                        "You cannot edit this appointment anymore because it is in the past.",
                        "Edit Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                AppointmentInformationPage editPage = new AppointmentInformationPage(this.nurse, patientId, appointmentDateTime);
                editPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void visitInformationButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = null;

            if (this.appointmentsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = appointmentsDataGridView.SelectedRows[0];

                if (selectedRow != null)
                {
                    var patientID = (int)selectedRow.Cells[0].Value;
                    var docID = selectedRow.Cells[2].Value;
                    DateTime appDateTime = (DateTime)selectedRow.Cells[4].Value;

                    if (patientID != null && appDateTime != null)
                    {
                        appointment = this.appointmentDAL.GetAppointment(patientID, appDateTime);
                    }

                }

            }
            else
            {
                MessageBox.Show("Please select an appointment to view Visit Information");
            }

            if (appointment != null)
            {
                VisitInformation visitInformation = new VisitInformation(this.nurse, appointment);
                visitInformation.Show();
                this.Close();

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.searchGroupBox.Visible)
            {
                this.searchGroupBox.Visible = false;
                this.nurseNameLabel.Visible = true;
                this.nurseIdLabel.Visible = true;
                this.loadAppointments();
            }
            else
            {
                this.searchGroupBox.Visible = true;
                this.nurseNameLabel.Visible = false;
                this.nurseIdLabel.Visible = false;
            }
        }

        private async void appointmentSearchButton_Click(object sender, EventArgs e)
        {
            if (this.nameRadioButton.Checked)
            {
                List<Appointment> appointments = await appointmentDAL.GetListOfAppointmentsByPatientName(fnameSearchTextBox.Text, lnameTextBox.Text);

                appointmentsDataGridView.Columns.Clear();
                appointmentsDataGridView.Columns.Add("PatientID", "Patient ID");
                appointmentsDataGridView.Columns.Add("PatientName", "Patient Name");
                appointmentsDataGridView.Columns.Add("DoctorID", "Doctor ID");
                appointmentsDataGridView.Columns.Add("DoctorName", "Doctor Name");
                appointmentsDataGridView.Columns.Add("AppointmentDateTime", "Date/Time");

                appointmentsDataGridView.Rows.Clear();

                foreach (var appointment in appointments)
                {
                    appointmentsDataGridView.Rows.Add(appointment.PatientID,
                    appointment.PatientName,
                    appointment.DoctorID,
                    appointment.DoctorName,
                    appointment.AppointmentDateTime);
                }
            }
            else if (this.birthdateDateRadioButton.Checked)
            {
                List<Appointment> appointments = await appointmentDAL.GetListOfAppointmentsByPatientBirthdate(searchDatePicker.Value);

                appointmentsDataGridView.Columns.Clear();
                appointmentsDataGridView.Columns.Add("PatientID", "Patient ID");
                appointmentsDataGridView.Columns.Add("PatientName", "Patient Name");
                appointmentsDataGridView.Columns.Add("DoctorID", "Doctor ID");
                appointmentsDataGridView.Columns.Add("DoctorName", "Doctor Name");
                appointmentsDataGridView.Columns.Add("AppointmentDateTime", "Date/Time");

                appointmentsDataGridView.Rows.Clear();

                foreach (var appointment in appointments)
                {
                    appointmentsDataGridView.Rows.Add(appointment.PatientID,
                    appointment.PatientName,
                    appointment.DoctorID,
                    appointment.DoctorName,
                    appointment.AppointmentDateTime);
                }
            }
            else if (this.bothRadioButton.Checked)
            {
                List<Appointment> appointments = await appointmentDAL.GetListOfAppointmentsByPatientNameAndBirthdate(fnameSearchTextBox.Text, lnameTextBox.Text, searchDatePicker.Value);

                appointmentsDataGridView.Columns.Clear();
                appointmentsDataGridView.Columns.Add("PatientID", "Patient ID");
                appointmentsDataGridView.Columns.Add("PatientName", "Patient Name");
                appointmentsDataGridView.Columns.Add("DoctorID", "Doctor ID");
                appointmentsDataGridView.Columns.Add("DoctorName", "Doctor Name");
                appointmentsDataGridView.Columns.Add("AppointmentDateTime", "Date/Time");

                appointmentsDataGridView.Rows.Clear();

                foreach (var appointment in appointments)
                {
                    appointmentsDataGridView.Rows.Add(appointment.PatientID,
                    appointment.PatientName,
                    appointment.DoctorID,
                    appointment.DoctorName,
                    appointment.AppointmentDateTime);
                }
            }
            else
            {
                MessageBox.Show("No search criteria selected. Please click Name, Birthdate or Both.");
            }
        }

        private void nameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = false;
            this.fnameSearchTextBox.Enabled = true;
            this.lnameTextBox.Enabled = true;

            this.appointmentSearchButton.Enabled = true;
            this.clearButton.Enabled = true;
        }

        private void birthdateDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = true;
            this.fnameSearchTextBox.Enabled = false;
            this.lnameTextBox.Enabled = false;

            this.appointmentSearchButton.Enabled = true;
            this.clearButton.Enabled = true;
        }

        private void bothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = true;
            this.fnameSearchTextBox.Enabled = true;
            this.lnameTextBox.Enabled = true;

            this.appointmentSearchButton.Enabled = true;
            this.clearButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.searchDatePicker.Value = DateTime.Now;
            this.fnameSearchTextBox.Text = string.Empty;
            this.lnameTextBox.Text = string.Empty;
        }
    }
}
