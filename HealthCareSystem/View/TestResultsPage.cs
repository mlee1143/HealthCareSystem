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
        //private string patientName;
        private int doctorId;
        private string doctorName;
        private DateTime appointmentDateTime;
        private int visitNurseId;

        public TestResultsPage(Nurse nurse, int patientId, int doctorId, string doctorName, DateTime appointmentDateTime, int visitNurseId)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.patientId = patientId;
            //this.patientName = patientName;
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.appointmentDateTime = appointmentDateTime;
            this.visitNurseId = visitNurseId;

            this.setPeopleInvolvedInfo();
            this.loadLabTests();
        }

        private void setPeopleInvolvedInfo()
        {
            PatientDAL patientDAL = new PatientDAL();
            Patient patient = patientDAL.GetPatientByID(this.patientId);

            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
            doctorNameLabel.Text = $"Doctor Name: {this.doctorName}";
            doctorIdLabel.Text = $"Doctor ID: {this.doctorId}";
            patientInfoLabel.Text = $"Order Test For: {patient.FullName} ID: {patient.PatientId}  DOB: {patient.Birthdate.ToString("yyyy-MM-dd")}";
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            if (labTestDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lab test to save the result.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = labTestDataGrid.SelectedRows[0];

            int testCode = Convert.ToInt32(selectedRow.Cells["TestCode"].Value);
            DateTime testDateTime = testDateTimePicker.Value;

            if (!decimal.TryParse(testResultTextBox.Text, out decimal result))
            {
                MessageBox.Show("Please enter a valid numeric test result.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lowValueStr = selectedRow.Cells["Low"].Value?.ToString();
            string highValueStr = selectedRow.Cells["High"].Value?.ToString();
            decimal? lowValue = decimal.TryParse(lowValueStr, out decimal low) ? low : (decimal?)null;
            decimal? highValue = decimal.TryParse(highValueStr, out decimal high) ? high : (decimal?)null;

            bool? isAbnormal = this.determineAbnormality(result, lowValue, highValue, abnormalRadioButton.Checked ? true : normalRadioButton.Checked ? false : null);

            LabTestDAL labTestDAL = new LabTestDAL();
            bool success = labTestDAL.UpdateLabTestResult(testCode: testCode, patientId: this.patientId, nurseId: this.visitNurseId, doctorId: this.doctorId,
                appointmentDateTime: this.appointmentDateTime, testDateTime: testDateTime, isAbnormal: isAbnormal, result: result);

            if (success)
            {
                MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadLabTests();
            }
            else
            {
                MessageBox.Show("Failed to save the test result. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            //labTestDataGrid.Columns.Add("PatientID", "Patient ID");
            //labTestDataGrid.Columns.Add("NurseID", "Nurse ID");
            //labTestDataGrid.Columns.Add("DoctorID", "Doctor ID");
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
                    //labTest.PatientID,
                    //labTest.NurseID,
                    //labTest.DoctorID,
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

            testResultTextBox.Enabled = isTestSelected;
            testDateTimePicker.Enabled = isTestSelected;
            saveResultButton.Enabled = isTestSelected;

            this.parseAndEvaluateNormality();
        }

        private void testResultTextBox_TextChanged(object sender, EventArgs e)
        {
            this.parseAndEvaluateNormality();
        }

        private void parseAndEvaluateNormality()
        {
            var selectedRow = labTestDataGrid.SelectedRows.Count > 0 ? labTestDataGrid.SelectedRows[0] : null;

            if (selectedRow == null)
            {
                normalityGroupBox.Enabled = false;
                abnormalRadioButton.Checked = false;
                normalRadioButton.Checked = false;
                testResultTextBox.Text = "";
                testDateTimePicker.Value = DateTime.Now;
                return;
            }

            string lowValueStr = selectedRow.Cells["Low"].Value?.ToString();
            string highValueStr = selectedRow.Cells["High"].Value?.ToString();

            decimal? lowValue = decimal.TryParse(lowValueStr, out decimal low) ? low : (decimal?)null;
            decimal? highValue = decimal.TryParse(highValueStr, out decimal high) ? high : (decimal?)null;

            if (!lowValue.HasValue && !highValue.HasValue)
            {
                normalityGroupBox.Enabled = true;
            }
            else
            {
                normalityGroupBox.Enabled = false;
            }

            this.evaluateNormalityBasedOnResult(lowValue, highValue);
        }

        private void evaluateNormalityBasedOnResult(decimal? low, decimal? high)
        {
            if (decimal.TryParse(testResultTextBox.Text, out decimal result))
            {
                if (low.HasValue && high.HasValue)
                {
                    abnormalRadioButton.Checked = result < low || result > high;
                    normalRadioButton.Checked = !abnormalRadioButton.Checked;
                }
                else if (low.HasValue)
                {
                    abnormalRadioButton.Checked = result < low;
                    normalRadioButton.Checked = !abnormalRadioButton.Checked;
                }
                else if (high.HasValue)
                {
                    abnormalRadioButton.Checked = result > high;
                    normalRadioButton.Checked = !abnormalRadioButton.Checked;
                }
            }
            else
            {
                abnormalRadioButton.Checked = false;
                normalRadioButton.Checked = false;
            }
        }

        private bool? determineAbnormality(decimal result, decimal? lowValue, decimal? highValue, bool? abnormalFromGroupBox)
        {
            if (lowValue.HasValue || highValue.HasValue)
            {
                if (lowValue.HasValue && highValue.HasValue)
                {
                    return result < lowValue || result > highValue;
                }
                else if (lowValue.HasValue)
                {
                    return result < lowValue;
                }
                else if (highValue.HasValue)
                {
                    return result > highValue;
                }
            }

            return abnormalFromGroupBox;
        }

    }
}
