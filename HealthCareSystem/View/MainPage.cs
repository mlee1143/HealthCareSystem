using HealthCareSystem.DAL;
using HealthCareSystem.Model;
using Microsoft.VisualBasic.Logging;
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
    public partial class MainPage : Form
    {
        private PatientDAL patientDAL;

        private Nurse nurse;

        public MainPage(Nurse nurse)
        {
            InitializeComponent();
            this.patientDAL = new PatientDAL();

            this.nurse = nurse;

            this.LoadPatientData();
            this.setNurseInfo(nurse);
        }

        private void setNurseInfo(Nurse nurse)
        {
            welcomeNameLabel.Text = $"Welcome, {nurse.Firstname} {nurse.Lastname}";
            idLabel.Text = $"Nurse ID: {nurse.NurseId}";

            this.LoadPatientData();
        }

        private void LoadPatientData()
        {
            List<Patient> patients = patientDAL.GetAllPatients();

            registeredPatiensDataGridView.Columns.Clear();
            registeredPatiensDataGridView.Columns.Add("PatientId", "Patient ID");
            registeredPatiensDataGridView.Columns.Add("FirstName", "First Name");
            registeredPatiensDataGridView.Columns.Add("LastName", "Last Name");
            registeredPatiensDataGridView.Columns.Add("Gender", "Gender");
            registeredPatiensDataGridView.Columns.Add("Birthdate", "Birth Date");

            registeredPatiensDataGridView.Rows.Clear();


            foreach (var patient in patients)
            {
                registeredPatiensDataGridView.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString());
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();

            this.Close();
        }

        private void registerPatientButton_Click(object sender, EventArgs e)
        {
            PatientInformation patientInfo = new PatientInformation(this.nurse);
            patientInfo.Show();

            this.Close();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            Patient patient = null;

            if (this.registeredPatiensDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = registeredPatiensDataGridView.SelectedRows[0];

                if (selectedRow != null)
                {
                    var patientid = selectedRow.Cells[0].Value;

                    if (patientid != null)
                    {
                        patient = this.patientDAL.GetPatientByID(Convert.ToInt32(patientid));
                    }

                }

            }
            else
            {
                MessageBox.Show("No Patient selected. Please select a patient to edit patient information");
            }

            if (patient != null)
            {
                PatientInformation patientInformation = new PatientInformation(this.nurse, patient);
                patientInformation.Show();

                this.Close();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.searchGroupBox.Visible)
            {
                this.searchGroupBox.Visible = false;
                this.welcomeNameLabel.Visible = true;
                this.idLabel.Visible = true;
                this.LoadPatientData();
            }
            else
            {
                this.searchGroupBox.Visible = true;
                this.welcomeNameLabel.Visible = false;
                this.idLabel.Visible = false;
            }
        }

        private async void patientSearchButton_Click(object sender, EventArgs e)
        {
            if (this.nameRadioButton.Checked) // Condense this part PH
            {
                List<Patient> patients = await patientDAL.GetPatientsByName(fnameSearchTextBox.Text, lnameTextBox.Text);

                registeredPatiensDataGridView.Columns.Clear();
                registeredPatiensDataGridView.Columns.Add("PatientId", "Patient ID");
                registeredPatiensDataGridView.Columns.Add("FirstName", "First Name");
                registeredPatiensDataGridView.Columns.Add("LastName", "Last Name");
                registeredPatiensDataGridView.Columns.Add("Gender", "Gender");
                registeredPatiensDataGridView.Columns.Add("Birthdate", "Birth Date");

                registeredPatiensDataGridView.Rows.Clear();


                foreach (var patient in patients)
                {
                    registeredPatiensDataGridView.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString());
                }
            }
            else if (this.birthdateRadioButton.Checked)
            {
                List<Patient> patients = await patientDAL.GetPatientsByBirthdate(this.searchDatePicker.Value);

                registeredPatiensDataGridView.Columns.Clear();
                registeredPatiensDataGridView.Columns.Add("PatientId", "Patient ID");
                registeredPatiensDataGridView.Columns.Add("FirstName", "First Name");
                registeredPatiensDataGridView.Columns.Add("LastName", "Last Name");
                registeredPatiensDataGridView.Columns.Add("Gender", "Gender");
                registeredPatiensDataGridView.Columns.Add("Birthdate", "Birth Date");

                registeredPatiensDataGridView.Rows.Clear();


                foreach (var patient in patients)
                {
                    registeredPatiensDataGridView.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString());
                }
            }
            else if (this.bothRadioButton.Checked)
            {
                List<Patient> patients = await patientDAL.GetPatientsByNameAndBirthdate(fnameSearchTextBox.Text, lnameTextBox.Text, this.searchDatePicker.Value);

                registeredPatiensDataGridView.Columns.Clear();
                registeredPatiensDataGridView.Columns.Add("PatientId", "Patient ID");
                registeredPatiensDataGridView.Columns.Add("FirstName", "First Name");
                registeredPatiensDataGridView.Columns.Add("LastName", "Last Name");
                registeredPatiensDataGridView.Columns.Add("Gender", "Gender");
                registeredPatiensDataGridView.Columns.Add("Birthdate", "Birth Date");

                registeredPatiensDataGridView.Rows.Clear();


                foreach (var patient in patients)
                {
                    registeredPatiensDataGridView.Rows.Add(patient.PatientId, patient.Firstname, patient.Lastname, patient.Gender, patient.Birthdate.ToShortDateString());
                }
            }
            else
            {
                this.errormessageLabel.Text = "No criteria selected."; // Maybe change to search being disabled
            }
        }


        private void nameRadioButton_Click(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = false;
            this.fnameSearchTextBox.Enabled = true;
            this.lnameTextBox.Enabled = true;

            this.patientSearchButton.Enabled = true;
        }

        private void birthdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = true;
            this.fnameSearchTextBox.Enabled = false;
            this.lnameTextBox.Enabled = false;

            this.patientSearchButton.Enabled = true;
        }

        private void bothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.searchDatePicker.Enabled = true;
            this.fnameSearchTextBox.Enabled = true;
            this.lnameTextBox.Enabled = true;

            this.patientSearchButton.Enabled = true;
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointments = new AppointmentsPage(this.nurse);
            appointments.Show();

            this.Close();
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {
            VisitsPage visits = new VisitsPage(this.nurse);
            visits.Show();

            this.Close();
        }
    }

}
