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
    public partial class AppointmentInformationPage : Form
    {
        private DoctorDAL doctorDAL;
        private PatientDAL patientDAL;

        public AppointmentInformationPage()
        {
            InitializeComponent();
            this.doctorDAL = new DoctorDAL();
            this.patientDAL = new PatientDAL();

            this.loadDoctors();
            this.loadActivePatients();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointments = new AppointmentsPage();
            appointments.Show();

            this.Close();
        }

        private void loadDoctors()
        {
            List<Doctor> doctors = doctorDAL.GetAllDoctors();

            doctorComboBox.DisplayMember = "FullName";
            doctorComboBox.ValueMember = "DoctorId";
            doctorComboBox.DataSource = doctors;
        }

        private void loadActivePatients()
        {
            List<Patient> activePatients = patientDAL.GetActivePatients();

            patientComboBox.DisplayMember = "FullName";
            patientComboBox.ValueMember = "PatientID";
            patientComboBox.DataSource = activePatients;
        }
    }
}
