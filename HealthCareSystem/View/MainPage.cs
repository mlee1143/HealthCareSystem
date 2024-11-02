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
        public string name { get; private set; }
        public int id { get; private set; }

        public MainPage(int id, string name)
        {
            InitializeComponent();
            this.patientDAL = new PatientDAL();

            this.id = id;
            this.name = name;

            this.LoadPatientData();
            this.SetNurseInfo(id, name);
        }

        public void SetNurseInfo(int nurseId, string nurseName)
        {
            welcomeNameLabel.Text = $"Welcome, {nurseName}";
            idLabel.Text = $"Nurse ID: {nurseId}";

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
            PatientInformation patientInfo = new PatientInformation(this.id, this.name);
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
                        patient = this.patientDAL.GetPatientByID(Convert.ToInt32(patientid)); // Handle null
                    }

                }

            }
            else
            {
                this.errormessageLabel.Visible = true;
                this.errormessageLabel.Text = "No Patient selected. Please select a patient to edit patient information.";
            }

            if (patient != null)
            {
                PatientInformation patientInformation = new PatientInformation(this.id, this.name, patient);
                patientInformation.Show();

                this.Close();
            }

        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointments = new AppointmentsPage();
            appointments.Show();

            this.Close();
        }
    }
}
