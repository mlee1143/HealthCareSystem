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
    public partial class DiagnosisPage : Form
    {
        private Nurse nurse;

        private Appointment appointment;
        private PatientDAL patientDAL;
        private VisitDAL visitDAL;


        public DiagnosisPage(Nurse nurse, Appointment appointment)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.appointment = appointment;

            this.patientDAL = new PatientDAL();
            this.visitDAL = new VisitDAL();

            this.setInformation();
            this.setupPage();
        }

        private void setInformation()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";

            Patient patient = patientDAL.GetPatientByID(appointment.PatientID);
            patientInfoLabel.Text = $"Patient: {patient.FullName}   ID: {patient.PatientId}";
        }


        private void setupPage()
        {
            Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
            this.initialDiagnosisTextBox.Text = visit.InitialDiagnosis;
            this.finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
            if (visitDAL.FinalDiagnosisExistsForVisit(appointment.PatientID, appointment.AppointmentDateTime))
            {
                this.submitButton.Enabled = false;
                this.initialDiagnosisTextBox.Enabled = false;
                this.finalDiagnosisTextBox.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            VisitsPage visitsPage = new VisitsPage(this.nurse);
            visitsPage.Show();

            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (this.initialDiagnosisTextBox.Text.Length > 0)
            {
                this.visitDAL.UpdateInitialDiagnosisForVisit(this.initialDiagnosisTextBox.Text, appointment.PatientID, appointment.AppointmentDateTime);

                MessageBox.Show("Initial Diagnosis has been updated.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No diagnosis to update. Please enter an initial diagnosis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (this.finalDiagnosisTextBox.Text.Length > 0)
            {
                const string message =
                    "Are you sure that you want to Confirm the final diagnosis? " +
                    "Once confirmed cannot go back and make changes to the visit.";

                const string caption = "Visit Information Confirmation";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.visitDAL.UpdateFinalDiagnosisForVisit(this.finalDiagnosisTextBox.Text, this.appointment.PatientID, this.appointment.AppointmentDateTime);
                }

            }
        }
    }
}
