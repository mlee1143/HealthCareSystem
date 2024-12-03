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
    public partial class VisitsPage : Form
    {
        private Nurse nurse;
        public VisitsPage(Nurse nurse)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.setLoggedNurseInfo();
            this.loadVisits();
        }

        private void setLoggedNurseInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
        }

        private void orderTestButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                //string patientName = (string)selectedRow.Cells["PatientName"].Value;
                int doctorId = (int)selectedRow.Cells["DoctorID"].Value;
                string doctorName = (string)selectedRow.Cells["DoctorName"].Value;
                int visitNurseId = (int)selectedRow.Cells["NurseID"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                OrderTestPage orderTestPage = new OrderTestPage(this.nurse, patientId, doctorId, doctorName, appointmentDateTime, visitNurseId);
                orderTestPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private void enterTestResultsButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                //string patientName = (string)selectedRow.Cells["PatientName"].Value;
                int doctorId = (int)selectedRow.Cells["DoctorID"].Value;
                string doctorName = (string)selectedRow.Cells["DoctorName"].Value;
                int visitNurseId = (int)selectedRow.Cells["NurseID"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                TestResultsPage orderTestPage = new TestResultsPage(this.nurse, patientId, doctorId, doctorName, appointmentDateTime, visitNurseId);
                orderTestPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private void loadVisits()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";

            VisitDAL visitDAL = new VisitDAL();
            List<dynamic> visits = visitDAL.GetAllVisitsWithDetails();

            visitsDataGrid.Columns.Clear();
            visitsDataGrid.Columns.Add("PatientID", "Patient ID");
            visitsDataGrid.Columns.Add("PatientName", "Patient Name");
            visitsDataGrid.Columns.Add("DoctorID", "Doctor ID");
            visitsDataGrid.Columns.Add("DoctorName", "Doctor Name");
            visitsDataGrid.Columns.Add("NurseID", "Nurse ID");
            visitsDataGrid.Columns.Add("NurseName", "Nurse Name");
            visitsDataGrid.Columns.Add("AppointmentDateTime", "Appointment Date/Time");

            visitsDataGrid.Rows.Clear();

            foreach (var visit in visits)
            {
                visitsDataGrid.Rows.Add(
                    visit.PatientID,
                    visit.PatientName,
                    visit.DoctorID,
                    visit.DoctorName,
                    visit.NurseID,
                    visit.NurseName,
                    visit.AppointmentDateTime
                );
            }
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(this.nurse);
            mainPage.Show();

            this.Close();
        }

        private void viewVisitInfoButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                AppointmentDAL apptDal = new AppointmentDAL();
                Appointment app = apptDal.GetAppointment(patientId, appointmentDateTime);

                FinalVisitInformationPage finalInfo = new FinalVisitInformationPage(this.nurse, app);
                finalInfo.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }

        private void enterDiagnosisButton_Click(object sender, EventArgs e)
        {
            if (visitsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = visitsDataGrid.SelectedRows[0];
                int patientId = (int)selectedRow.Cells["PatientID"].Value;
                string patientName = (string)selectedRow.Cells["PatientName"].Value;
                DateTime appointmentDateTime = (DateTime)selectedRow.Cells["AppointmentDateTime"].Value;

                AppointmentDAL apptDal = new AppointmentDAL();
                Appointment app = apptDal.GetAppointment(patientId, appointmentDateTime);

                DiagnosisPage diagnosisPage = new DiagnosisPage(this.nurse, app);
                diagnosisPage.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a visit to order tests for.");
            }
        }
    }
}
