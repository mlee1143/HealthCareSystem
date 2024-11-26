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
    public partial class DiagnosisPage : Form
    {
        private Nurse nurse;
        private int patientId;
        private string patientName;

        public DiagnosisPage(Nurse nurse, int patientId, string patientName)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.patientId = patientId;
            this.patientName = patientName;

            this.setInformation();
        }

        private void setInformation()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
            patientInfoLabel.Text = $"Patient: {this.patientName} ID: {this.patientId}";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            VisitsPage visitsPage = new VisitsPage(this.nurse);
            visitsPage.Show();

            this.Close();
        }
    }
}
