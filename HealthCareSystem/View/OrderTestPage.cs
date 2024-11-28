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
    public partial class OrderTestPage : Form
    {
        private Nurse nurse;
        private int patientId;
        private string patientName;
        private int doctorId;
        private string doctorName;
        private DateTime appointmentDateTime;
        private int visitNurseId;

        public OrderTestPage(Nurse nurse, int patientId, string patientName, int doctorId, string doctorName, DateTime appointmentDateTime , int visitNurseId)
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
            this.loadTestOptions();
        }

        private void setPeopleInvolvedInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
            doctorNameLabel.Text = $"Doctor Name: {this.doctorName}";
            doctorIdLabel.Text = $"Doctor ID: {this.doctorId}";
            patientInfoLabel.Text = $"Order Test For: {this.patientName} ID: {this.patientId}";
        }

        private void loadTestOptions()
        {
            LabTestDAL labTestDAL = new LabTestDAL();
            List<TestType> testTypes = labTestDAL.GetAllTestTypes();

            testOptionsComboBox.DisplayMember = "TestName";
            testOptionsComboBox.ValueMember = "TestCode";
            testOptionsComboBox.DataSource = testTypes;
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            if (testOptionsComboBox.SelectedItem is TestType selectedTest)
            {
                string formattedTest = $"{selectedTest.TestName} ({selectedTest.TestCode})";

                if (labTestsListBox.Items.Contains(formattedTest))
                {
                    MessageBox.Show("That test has been selected already.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    labTestsListBox.Items.Add(formattedTest);
                }
            }
        }

        private void removeTestButton_Click(object sender, EventArgs e)
        {
            if (labTestsListBox.SelectedItem != null)
            {
                labTestsListBox.Items.Remove(labTestsListBox.SelectedItem);
            }
        }

        private void orderTests_Click(object sender, EventArgs e)
        {
            if (!areTestsSelected())
                return;

            try
            {
                List<int> testCodes = extractTestCodesFromListBox();
                List<int> validTestCodes = validateTests(testCodes, this.appointmentDateTime);

                if (validTestCodes.Count > 0)
                {
                    bool success = insertValidTests(validTestCodes);
                    showInsertResult(success);
                }
                else
                {
                    MessageBox.Show("No valid tests were ordered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            VisitsPage visitsPage = new VisitsPage(this.nurse);
            visitsPage.Show();

            this.Close();
        }

        private bool areTestsSelected()
        {
            if (labTestsListBox.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one test before ordering.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private List<int> extractTestCodesFromListBox()
        {
            List<int> testCodes = new List<int>();

            foreach (var item in labTestsListBox.Items)
            {
                string test = item.ToString();
                int startIndex = test.LastIndexOf("(") + 1;
                int endIndex = test.LastIndexOf(")");
                int testCode = int.Parse(test.Substring(startIndex, endIndex - startIndex));
                testCodes.Add(testCode);
            }

            return testCodes;
        }

        //private List<int> validateTests(List<int> testCodes)
        //{
        //    LabTestDAL labTestDAL = new LabTestDAL();
        //    List<int> validTestCodes = new List<int>();

        //    foreach (var testCode in testCodes)
        //    {
        //        if (labTestDAL.IsTestAlreadyOrderedForPatient(testCode, this.patientId))
        //        {
        //            string testName = labTestsListBox.Items.Cast<string>().FirstOrDefault(t => t.Contains($"({testCode})"));
        //            MessageBox.Show($"The test '{testName}' has already been ordered for this patient.", "Duplicate Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            validTestCodes.Add(testCode);
        //        }
        //    }

        //    return validTestCodes;
        //}

        private List<int> validateTests(List<int> testCodes, DateTime appointmentDateTime)
        {
            LabTestDAL labTestDAL = new LabTestDAL();
            List<int> validTestCodes = new List<int>();

            foreach (var testCode in testCodes)
            {
                if (labTestDAL.IsTestAlreadyOrderedForPatient(testCode, this.patientId, appointmentDateTime))
                {
                    string testName = labTestsListBox.Items.Cast<string>().FirstOrDefault(t => t.Contains($"({testCode})"));

                    MessageBox.Show(
                        $"The test '{testName}' has already been ordered for this patient at the specified appointment time.",
                        "Duplicate Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    validTestCodes.Add(testCode);
                }
            }

            return validTestCodes;
        }


        private bool insertValidTests(List<int> testCodes)
        {
            LabTestDAL labTestDAL = new LabTestDAL();
            return labTestDAL.InsertLabTests(testCodes, this.patientId, this.visitNurseId, this.doctorId, this.appointmentDateTime);
        }

        private void showInsertResult(bool success)
        {
            if (success)
            {
                MessageBox.Show("Tests ordered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VisitsPage visitsPage = new VisitsPage(this.nurse);
                visitsPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to order tests. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
