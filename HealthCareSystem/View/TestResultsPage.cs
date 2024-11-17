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
            if (labTestDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a test before saving the result.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int testCode = Convert.ToInt32(labTestDataGrid.SelectedRows[0].Cells["TestCode"].Value);

                decimal? lowValue = noLowValueCheckBox.Checked ? null : (decimal?)Convert.ToDecimal(lowTextBox.Text);
                decimal? highValue = noHighValueCheckBox.Checked ? null : (decimal?)Convert.ToDecimal(highTextBox.Text);
                string unitMeasurement = "mIU/L";
                DateTime testDateTime = testDateTimePicker.Value;
                string result = testResultTextBox.Text;

                if (string.IsNullOrWhiteSpace(result))
                {
                    MessageBox.Show("Please enter a test result.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (lowValue.HasValue && highValue.HasValue && lowValue.Value > highValue.Value)
                {
                    MessageBox.Show("Low value cannot be greater than High value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool? isAbnormal = null;

                if (lowValue.HasValue && highValue.HasValue)
                {
                    decimal numericResult = Convert.ToDecimal(result);
                    isAbnormal = numericResult < lowValue || numericResult > highValue;
                }
                else if (lowValue.HasValue || highValue.HasValue)
                {
                    decimal numericResult = Convert.ToDecimal(result);
                    if (lowValue.HasValue)
                    {
                        isAbnormal = numericResult < lowValue;
                    }
                    else if (highValue.HasValue)
                    {
                        isAbnormal = numericResult > highValue;
                    }
                }
                else if (normalityGroupBox.Enabled)
                {
                    isAbnormal = abnormalRadioButton.Checked ? true : (normalRadioButton.Checked ? false : (bool?)null);
                }

                if (!isAbnormal.HasValue)
                {
                    MessageBox.Show("Please specify whether the result is normal or abnormal.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LabTestDAL labTestDAL = new LabTestDAL();
                bool success = labTestDAL.UpdateLabTestResult(
                    testCode,
                    patientId,
                    visitNurseId,
                    doctorId,
                    appointmentDateTime,
                    lowValue,
                    highValue,
                    unitMeasurement,
                    testDateTime,
                    isAbnormal,
                    result
                );

                if (success)
                {
                    MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadLabTests();
                }
                else
                {
                    MessageBox.Show("Failed to save test result. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numeric input for test result, low, or high values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<LabTest> labTests = labTestDAL.GetLabTestsForVisit(this.patientId, this.doctorId, this.visitNurseId, this.appointmentDateTime);

            labTestDataGrid.Columns.Clear();
            labTestDataGrid.Columns.Add("TestCode", "Test Code");
            labTestDataGrid.Columns.Add("TestName", "Test Name");
            labTestDataGrid.Columns.Add("NurseID", "Nurse ID");
            labTestDataGrid.Columns.Add("AppointmentDateTime", "Appointment Date/Time");
            labTestDataGrid.Columns.Add("Low", "Low");
            labTestDataGrid.Columns.Add("High", "High");
            labTestDataGrid.Columns.Add("UnitMeasurement", "Unit Measurement");
            labTestDataGrid.Columns.Add("TestDateTime", "Test Date/Time");
            labTestDataGrid.Columns.Add("Abnormal", "Abnormal");
            labTestDataGrid.Columns.Add("Result", "Result");

            labTestDataGrid.Rows.Clear();
            foreach (var labTest in labTests)
            {
                labTestDataGrid.Rows.Add(
                    labTest.TestCode,
                    labTest.TestName,
                    labTest.NurseID,
                    labTest.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"),
                    labTest.Low?.ToString() ?? "",
                    labTest.High?.ToString() ?? "",
                    labTest.UnitMeasurement ?? "",
                    labTest.TestDateTime?.ToString("yyyy-MM-dd HH:mm") ?? "",
                    labTest.IsAbnormal.HasValue ? (labTest.IsAbnormal.Value ? "Yes" : "No") : "",
                    labTest.Result ?? ""
                );
            }
        }

        private void labTestDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool isTestSelected = labTestDataGrid.SelectedRows.Count > 0;

            lowTextBox.Enabled = isTestSelected;
            highTextBox.Enabled = isTestSelected;
            noLowValueCheckBox.Enabled = isTestSelected;
            noHighValueCheckBox.Enabled = isTestSelected;
            normalityGroupBox.Enabled = false;
            testResultTextBox.Enabled = isTestSelected;
            testDateTimePicker.Enabled = isTestSelected;
            saveResultButton.Enabled = isTestSelected;

            if (!isTestSelected)
            {
                lowTextBox.Text = "";
                highTextBox.Text = "";
                noLowValueCheckBox.Checked = false;
                noHighValueCheckBox.Checked = false;
                abnormalRadioButton.Checked = false;
                normalRadioButton.Checked = false;
                testResultTextBox.Text = "";
                testDateTimePicker.Value = DateTime.Now;
            }
        }

        private void noLowValueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lowTextBox.Enabled = !noLowValueCheckBox.Checked;

            EvaluateNormalityGroupAvailability();
        }

        private void noHighValueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            highTextBox.Enabled = !noHighValueCheckBox.Checked;

            EvaluateNormalityGroupAvailability();
        }

        private void EvaluateNormalityGroupAvailability()
        {
            normalityGroupBox.Enabled = noLowValueCheckBox.Checked && noHighValueCheckBox.Checked;
        }
    }
}
