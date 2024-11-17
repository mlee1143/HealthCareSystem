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

        public OrderTestPage(Nurse nurse, int patientId, string patientName, int doctorId, string doctorName)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.patientId = patientId;
            this.patientName = patientName;
            this.doctorId = doctorId;
            this.doctorName = doctorName;

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
            List<string> testTypes = labTestDAL.GetAllTestTypes();

            testOptionsComboBox.DataSource = testTypes;
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            string selectedTest = testOptionsComboBox.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(selectedTest) && !labTestsListBox.Items.Contains(selectedTest))
            {
                labTestsListBox.Items.Add(selectedTest);
            }
        }

        private void removeTestButton_Click(object sender, EventArgs e)
        {
            if (labTestsListBox.SelectedItem != null)
            {
                labTestsListBox.Items.Remove(labTestsListBox.SelectedItem);
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
