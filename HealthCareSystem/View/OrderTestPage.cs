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
            if (labTestsListBox.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one test before ordering.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
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

                LabTestDAL labTestDAL = new LabTestDAL();
                bool success = labTestDAL.InsertLabTests(testCodes, this.patientId, this.visitNurseId, this.doctorId, this.appointmentDateTime);

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
    }
}
