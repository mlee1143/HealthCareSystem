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
        public MainPage()
        {
            InitializeComponent();
            this.patientDAL = new PatientDAL();
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
            registeredPatiensDataGridView.Columns.Add("FullName", "Full Name");
            registeredPatiensDataGridView.Columns.Add("Gender", "Gender");

            registeredPatiensDataGridView.Rows.Clear();

            foreach (var patient in patients)
            {
                string fullName = $"{patient.Firstname} {patient.Lastname}";
                registeredPatiensDataGridView.Rows.Add(patient.PatientId, fullName, patient.Gender);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();

            this.Close();
        }
    }
}
