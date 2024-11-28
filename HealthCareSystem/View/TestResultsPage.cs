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
    public partial class TestResultsPage : Form
    {
        private Nurse nurse;
        private int patientId;
        private string patientName;
        private int doctorId;
        private string doctorName;
        private DateTime appointmentDateTime;
        private int visitNurseId;

        public TestResultsPage(Nurse nurse, int patientId, string patientName, int doctorId, string doctorName, DateTime appointmentDateTime, int visitNurseId)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.patientId = patientId;
            this.patientName = patientName;
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.appointmentDateTime = appointmentDateTime;
            this.visitNurseId = visitNurseId;

            this.setPeopleInvolvedInfo();
            this.loadLabTests();
        }

        private void setPeopleInvolvedInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
            doctorNameLabel.Text = $"Doctor Name: {this.doctorName}";
            doctorIdLabel.Text = $"Doctor ID: {this.doctorId}";
            patientInfoLabel.Text = $"Order Test For: {this.patientName} ID: {this.patientId}";
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {

        }


        private void goBackButton_Click(object sender, EventArgs e)
        {
            VisitsPage visitsPage = new VisitsPage(this.nurse);
            visitsPage.Show();

            this.Close();
        }

        private void loadLabTests()
        {
            LabTestDAL labTestDAL = new LabTestDAL();
            var labTests = labTestDAL.GetAllLabTestsForVisit(this.patientId, this.appointmentDateTime);

            labTestDataGrid.Columns.Clear();
            labTestDataGrid.Columns.Add("TestCode", "Test Code");
            labTestDataGrid.Columns.Add("TestName", "Test Name");
            labTestDataGrid.Columns.Add("PatientID", "Patient ID");
            labTestDataGrid.Columns.Add("NurseID", "Nurse ID");
            labTestDataGrid.Columns.Add("DoctorID", "Doctor ID");
            labTestDataGrid.Columns.Add("AppointmentDateTime", "Appointment Date/Time");
            labTestDataGrid.Columns.Add("TestDateTime", "Test Date/Time");
            labTestDataGrid.Columns.Add("Low", "Low");
            labTestDataGrid.Columns.Add("High", "High");
            labTestDataGrid.Columns.Add("UnitMeasurement", "Unit Measurement");
            labTestDataGrid.Columns.Add("Abnormal", "Abnormal");
            labTestDataGrid.Columns.Add("Result", "Result");

            labTestDataGrid.Rows.Clear();
            foreach (var (labTest, testType) in labTests)
            {
                labTestDataGrid.Rows.Add(
                    labTest.TestCode,
                    testType.TestName,
                    labTest.PatientID,
                    labTest.NurseID,
                    labTest.DoctorID,
                    labTest.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"),
                    labTest.TestDateTime?.ToString("yyyy-MM-dd HH:mm") ?? "",
                    testType.Low > 0 ? testType.Low.ToString() : "",
                    testType.High > 0 ? testType.High.ToString() : "",
                    testType.UnitMeasurement,
                    labTest.IsAbnormal.HasValue ? (labTest.IsAbnormal.Value ? "Yes" : "No") : "",
                    labTest.Result ?? ""
                );
            }
        }

        private void labTestDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool isTestSelected = labTestDataGrid.SelectedRows.Count > 0;

            normalityGroupBox.Enabled = false;
            testResultTextBox.Enabled = isTestSelected;
            testDateTimePicker.Enabled = isTestSelected;
            saveResultButton.Enabled = isTestSelected;

            if (!isTestSelected)
            {
                abnormalRadioButton.Checked = false;
                normalRadioButton.Checked = false;
                testResultTextBox.Text = "";
                testDateTimePicker.Value = DateTime.Now;
            }
        }

        private void EvaluateNormalityGroupAvailability()
        {
            
        }
    }
}
