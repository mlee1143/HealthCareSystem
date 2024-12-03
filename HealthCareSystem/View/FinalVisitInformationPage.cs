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
    /// <summary>
    /// Final Visit Information page
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FinalVisitInformationPage : Form
    {
        private Nurse nurse;
        private int patientId;
        private string patientName;

        private Appointment appointment;
        private Patient patient;

        PatientDAL patientDAL;
        VisitDAL visitDAL;
        DoctorDAL doctorDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinalVisitInformationPage"/> class.
        /// </summary>
        /// <param name="nurse">The nurse.</param>
        /// <param name="appointment">The appointment.</param>
        public FinalVisitInformationPage(Nurse nurse, Appointment appointment)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.appointment = appointment;

            this.patientDAL = new PatientDAL();
            this.visitDAL = new VisitDAL();
            this.doctorDAL = new DoctorDAL();

            this.setInformation();
            this.SetupCurrentVisit();
        }

        private void setInformation()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";

            Patient patient = patientDAL.GetPatientByID(appointment.PatientID);
            patientInfoLabel.Text = $"Patient: {patient.FullName}   ID: {patient.PatientId}   DOB: {patient.Birthdate.ToShortDateString()}";
        }

        private void SetupCurrentVisit()
        {
            Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
            if (visitDAL.VisitInformationExistsAlready(appointment.PatientID, appointment.AppointmentDateTime))
            {
                
                this.PopulateFields(visit);
            }

            if (visitDAL.InitialDiagnosisExistsForVisit(appointment.PatientID, appointment.AppointmentDateTime))
            {
                this.PopulateDiagnosis(visit);
                this.PopulateOrderedTests(visit);
            }

        }

        private void PopulateFields(Visit visit)
        {
            this.heightLabel.Text += visit.Height.ToString() + " in.";
            this.weightLabel.Text += visit.Weight.ToString() + " lbs.";

            this.bloodPressureLabel.Text += visit.BloodPressure;

            this.pulseLabel.Text += visit.Pulse.ToString() + " bpm";
            this.temperatureLabel.Text += visit.Temperature.ToString() + " F°";
            this.symptomsTextBox.Text = visit.SymptomsDescription.ToString();
        }

        private void PopulateDiagnosis(Visit visit)
        {
            this.initialDiagnosisTextBox.Text = visit.InitialDiagnosis;
            this.finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
        }

        private void PopulateOrderedTests(Visit visit)
        {
            try
            {
                LabTestDAL labTestDAL = new LabTestDAL();
                var labTests = labTestDAL.GetAllLabTestsForVisit(visit.Appointment.PatientID, visit.Appointment.AppointmentDateTime);

                orderedTestDataGridView.Columns.Clear();
                orderedTestDataGridView.Columns.Add("TestCode", "Test Code");
                orderedTestDataGridView.Columns.Add("TestName", "Test Name");
                orderedTestDataGridView.Columns.Add("TestPerformDate", "Performed Date");
                orderedTestDataGridView.Columns.Add("Result", "Result");
                orderedTestDataGridView.Columns.Add("Abnormal", "Abnormal");

                orderedTestDataGridView.Rows.Clear();
                foreach (var (labTest, testType) in labTests)
                {
                    orderedTestDataGridView.Rows.Add(
                        labTest.TestCode,
                        testType.TestName,
                        labTest.TestDateTime?.ToString("yyyy-MM-dd HH:mm") ?? "N/A",
                        labTest.Result ?? "N/A",
                        labTest.IsAbnormal.HasValue ? (labTest.IsAbnormal.Value ? "Yes" : "No") : "N/A"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading test details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            VisitsPage visitsPage = new VisitsPage(this.nurse);
            visitsPage.Show();

            this.Close();
        }
    }
}
