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
            nurseNameLabel.Text = $"Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
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

                AppointmentInformationPage editPage = new AppointmentInformationPage(this.nurse, patientId, appointmentDateTime);
                editPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.");
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
                    var docID = selectedRow.Cells[1].Value;
                    DateTime appDateTime = (DateTime)selectedRow.Cells[2].Value;

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
            if (this.nameRadioButton.Checked) // Condense this part PH
            {
                //Patient patient = await patientDAL
                List<Appointment> appointments = appointmentDAL.getAllAppointments();

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
            else if (this.birthdateDateRadioButton.Checked)
            {
                List<Appointment> appointments =  appointmentDAL.getAllAppointments();

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
            else if (this.bothRadioButton.Checked)
            {
                List<Appointment> appointments = appointmentDAL.getAllAppointments();

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
            else
            {
                MessageBox.Show("No search criteria selected. Please click Name, Birthdate or Both.");

                this.errorLabel.Text = "No criteria selected."; // Maybe change to search being disabled
            }
        }
    }
}
