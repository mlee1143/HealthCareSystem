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
    public partial class VisitsPage : Form
    {
        private Nurse nurse;
        private PatientDAL patientDAL;

        public VisitsPage(Nurse nurse)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.patientDAL = new PatientDAL();
            this.setLoggedNurseInfo();
            this.loadVisits();
        }

        private void setLoggedNurseInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
        }

        private void orderTestButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                //string patientName = (string)selectedRow.Cells["PatientName"].Value;
                int doctorId = (int)selectedRow.Cells["DoctorID"].Value;
                string doctorName = (string)selectedRow.Cells["DoctorName"].Value;
                int visitNurseId = (int)selectedRow.Cells["NurseID"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                OrderTestPage orderTestPage = new OrderTestPage(this.nurse, patientId, doctorId, doctorName, appointmentDateTime, visitNurseId);
                orderTestPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private void enterTestResultsButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                //string patientName = (string)selectedRow.Cells["PatientName"].Value;
                int doctorId = (int)selectedRow.Cells["DoctorID"].Value;
                string doctorName = (string)selectedRow.Cells["DoctorName"].Value;
                int visitNurseId = (int)selectedRow.Cells["NurseID"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                TestResultsPage orderTestPage = new TestResultsPage(this.nurse, patientId, doctorId, doctorName, appointmentDateTime, visitNurseId);
                orderTestPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private void loadVisits()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";

            VisitDAL visitDAL = new VisitDAL();
            List<dynamic> visits = visitDAL.GetAllVisitsWithDetails();

            visitsDataGrid.Columns.Clear();
            visitsDataGrid.Columns.Add("PatientID", "Patient ID");
            visitsDataGrid.Columns.Add("PatientName", "Patient Name");
            visitsDataGrid.Columns.Add("DoctorID", "Doctor ID");
            visitsDataGrid.Columns.Add("DoctorName", "Doctor Name");
            visitsDataGrid.Columns.Add("NurseID", "Nurse ID");
            visitsDataGrid.Columns.Add("NurseName", "Nurse Name");
            visitsDataGrid.Columns.Add("AppointmentDateTime", "Appointment Date/Time");

            visitsDataGrid.Rows.Clear();

            foreach (var visit in visits)
            {
                visitsDataGrid.Rows.Add(
                    visit.PatientID,
                    visit.PatientName,
                    visit.DoctorID,
                    visit.DoctorName,
                    visit.NurseID,
                    visit.NurseName,
                    visit.AppointmentDateTime
                );
            }
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(this.nurse);
            mainPage.Show();

            this.Close();
        }

        private void viewVisitInfoButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                AppointmentDAL apptDal = new AppointmentDAL();
                Appointment app = apptDal.GetAppointment(patientId, appointmentDateTime);

                FinalVisitInformationPage finalInfo = new FinalVisitInformationPage(this.nurse, app);
                finalInfo.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private void enterDiagnosisButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                string patientName = (string)selectedRow.Cells["PatientName"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                AppointmentDAL apptDal = new AppointmentDAL();
                Appointment app = apptDal.GetAppointment(patientId, appointmentDateTime);

                DiagnosisPage diagnosisPage = new DiagnosisPage(this.nurse, app);
                diagnosisPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private async void patientSearchButton_Click(object sender, EventArgs e)
        {
            if (this.nameRadioButton.Checked) // Condense this part PH
            {
                List<Patient> patients = await patientDAL.GetPatientsByName(fnameSearchTextBox.Text, lnameTextBox.Text);

                visitsDataGrid.Columns.Clear();
                visitsDataGrid.Columns.Add("PatientId", "Patient ID");
                visitsDataGrid.Columns.Add("FirstName", "First Name");
                visitsDataGrid.Columns.Add("LastName", "Last Name");
                visitsDataGrid.Columns.Add("Gender", "Gender");
                visitsDataGrid.Columns.Add("Birthdate", "Birth Date");
                visitsDataGrid.Columns.Add("IsActive", "Active");

                visitsDataGrid.Rows.Clear();


                foreach (var patient in patients)
                {
                    visitsDataGrid.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString(), patient.IsActive);
                }
            }
            else if (this.birthdateRadioButton.Checked)
            {
                List<Patient> patients = await patientDAL.GetPatientsByBirthdate(this.searchDatePicker.Value);

                visitsDataGrid.Columns.Clear();
                visitsDataGrid.Columns.Add("PatientId", "Patient ID");
                visitsDataGrid.Columns.Add("FirstName", "First Name");
                visitsDataGrid.Columns.Add("LastName", "Last Name");
                visitsDataGrid.Columns.Add("Gender", "Gender");
                visitsDataGrid.Columns.Add("Birthdate", "Birth Date");
                visitsDataGrid.Columns.Add("IsActive", "Active");

                visitsDataGrid.Rows.Clear();


                foreach (var patient in patients)
                {
                    visitsDataGrid.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString(), patient.IsActive);
                }
            }
            else if (this.bothRadioButton.Checked)
            {
                List<Patient> patients = await patientDAL.GetPatientsByNameAndBirthdate(fnameSearchTextBox.Text, lnameTextBox.Text, this.searchDatePicker.Value);

                visitsDataGrid.Columns.Clear();
                visitsDataGrid.Columns.Add("PatientId", "Patient ID");
                visitsDataGrid.Columns.Add("FirstName", "First Name");
                visitsDataGrid.Columns.Add("LastName", "Last Name");
                visitsDataGrid.Columns.Add("Gender", "Gender");
                visitsDataGrid.Columns.Add("Birthdate", "Birth Date");
                visitsDataGrid.Columns.Add("IsActive", "Active");

                visitsDataGrid.Rows.Clear();


                foreach (var patient in patients)
                {
                    visitsDataGrid.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString(), patient.IsActive);
                }
            }
            else
            {
                MessageBox.Show("No criteria selected.", "Error");
            }
        }


        private void nameRadioButton_Click(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = false;
            this.fnameSearchTextBox.Enabled = true;
            this.lnameTextBox.Enabled = true;

            this.patientSearchButton.Enabled = true;
            this.clearButton.Enabled = true;
        }

        private void birthdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = true;
            this.fnameSearchTextBox.Enabled = false;
            this.lnameTextBox.Enabled = false;

            this.patientSearchButton.Enabled = true;
            this.clearButton.Enabled = true;
        }

        private void bothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = true;
            this.fnameSearchTextBox.Enabled = true;
            this.lnameTextBox.Enabled = true;

            this.patientSearchButton.Enabled = true;
            this.clearButton.Enabled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.searchGroupBox.Visible)
            {
                this.searchGroupBox.Visible = false;
                this.nurseNameLabel.Visible = true;
                this.nurseIdLabel.Visible = true;
                this.loadVisits();
            }
            else
            {
                this.searchGroupBox.Visible = true;
                this.nurseNameLabel.Visible = false;
                this.nurseIdLabel.Visible = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.searchDatePicker.Value = DateTime.Now;
            this.fnameSearchTextBox.Text = string.Empty;
            this.lnameTextBox.Text = string.Empty;
        }
    }
}

