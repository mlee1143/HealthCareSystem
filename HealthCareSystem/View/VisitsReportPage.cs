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
    public partial class VisitsReportPage : Form
    {
        private Administrator administrator;

        public VisitsReportPage(Administrator admin)
        {
            InitializeComponent();

            this.administrator = admin;

            this.setAdminInformation();
        }

        private void setAdminInformation()
        {
            adminNameLabel.Text = $"Name: {this.administrator.Firstname} {this.administrator.Lastname}";
            adminIdLabel.Text = $"ID: {this.administrator.AdministratorId}";
            adminBirthdateLabel.Text = $"DOB: {this.administrator.Birthdate.ToString("yyyy-MM-dd")}";
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = visitOneDateTimePicker.Value;
            DateTime endDate = visitTwoDateTimePicker.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("The start date cannot be later than the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                loadVisitInformation(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the visit reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getBackButton_Click(object sender, EventArgs e)
        {
            AdminMainPage mainPage = new AdminMainPage(this.administrator);
            mainPage.Show();

            this.Close();
        }

        private void loadVisitInformation(DateTime startDate, DateTime endDate)
        {
            AdministratorDAL visitReportDAL = new AdministratorDAL();
            List<dynamic> visits = visitReportDAL.GetVisitReports(startDate, endDate);

            if (visits.Count == 0)
            {
                MessageBox.Show("No visits found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            visitsDataGridView.Columns.Clear();
            visitsDataGridView.Columns.Add("VisitDate", "Visit Date");
            visitsDataGridView.Columns.Add("PatientID", "Patient ID");
            visitsDataGridView.Columns.Add("PatientName", "Patient Name");
            visitsDataGridView.Columns.Add("DoctorID", "Doctor ID");
            visitsDataGridView.Columns.Add("DoctorName", "Doctor Name");
            visitsDataGridView.Columns.Add("NurseID", "Nurse ID");
            visitsDataGridView.Columns.Add("NurseName", "Nurse Name");
            visitsDataGridView.Columns.Add("InitialDiagnosis", "Initial Diagnosis");
            visitsDataGridView.Columns.Add("FinalDiagnosis", "Final Diagnosis");

            visitsDataGridView.Rows.Clear();

            foreach (var visit in visits)
            {
                visitsDataGridView.Rows.Add(
                    visit.VisitDate,
                    visit.PatientId,
                    visit.PatientName,
                    visit.DoctorId,
                    visit.DoctorName,
                    visit.NurseId,
                    visit.NurseName,
                    visit.InitialDiagnosis,
                    visit.FinalDiagnosis
                );
            }

        }
    }
}
