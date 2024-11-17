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
        }

        private void setPeopleInvolvedInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
            doctorNameLabel.Text = $"Doctor Name: {this.doctorName}";
            doctorIdLabel.Text = $"Doctor ID: {this.doctorId}";
            patientInfoLabel.Text = $"Order Test For: {this.patientName} ID: {this.patientId}";
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            VisitsPage visitsPage = new VisitsPage(this.nurse);
            visitsPage.Show();

            this.Close();
        }
    }
}
