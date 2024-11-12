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
    public partial class VisitInformation : Form
    {
        private Nurse nurse;
        private Appointment appointment;

        PatientDAL patientDAL;
        VisitDAL visitDAL;
        DoctorDAL doctorDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitInformation"/> class.
        /// </summary>
        /// <param name="nurse">The nurse.</param>
        /// <param name="appointment">The appointment.</param>
        public VisitInformation(Nurse nurse, Appointment appointment)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.appointment = appointment;

            this.patientDAL = new PatientDAL();
            this.visitDAL = new VisitDAL();
            this.doctorDAL = new DoctorDAL();

            this.SetupLabels();
        }

        private void SetupLabels()
        {
            this.patientIDLabel.Text += $" {appointment.PatientID}";

            Patient patient = patientDAL.GetPatientByID(appointment.PatientID);
            this.patientnameLabel.Text += $" {patient.FullName}";
            this.patientDobLabel.Text += $" {patient.Birthdate.ToString("yyyy-MM-dd")}";

            this.doctorIDLabel.Text += $" {appointment.DoctorID}";
            var doctorName = doctorDAL.GetDoctorNameByDoctorID(appointment.DoctorID);
            this.doctorNameLabel.Text += $" {doctorName}";

            if (visitDAL.VisitInformationExistsAlready(appointment.PatientID, appointment.AppointmentDateTime))
            {
                Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
                this.PopulateFields(visit);
            }
        }

        private void PopulateFields(Visit visit)
        {
            this.heightTextbox.Text = visit.Height.ToString();
            this.weightTextbox.Text = visit.Weight.ToString();
            this.bloodpressureTextBox.Text = visit.BloodPressure.ToString();
            this.pulseTextbox.Text = visit.Pulse.ToString();
            this.temperatureTextbox.Text = visit.Temperature.ToString();
            this.symptomsTextbox.Text = visit.SymptomsDescription.ToString();
        }

        private bool IsNumberValid(string number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(number, "^[0-9]+$");
        }

        private bool IsDecimalNumberValid(string number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(number, "^\\d+\\.\\d{1,2}$");
        }

        private void bloodpressureTextBox_TextChanged(object sender, EventArgs e)
        {
            var bp = bloodpressureTextBox.Text.Trim();

            if (!IsNumberValid(bp))
            {
                this.errorLabel.Text = $"Invalid Format: ({bp}) should only contains numbers.";
            }
            else 
            {
                this.errorLabel.Text = "";
            }
        }

        private void pulseTextbox_TextChanged(object sender, EventArgs e)
        {
            var pulse  = pulseTextbox.Text.Trim();

            if (!IsNumberValid(pulse))
            {
                this.errorLabel.Text = $"Invalid Format: ({pulse}) should only contains numbers.";
            }
            else
            {
                this.errorLabel.Text = "";
            }
        }

        private void temperatureTextbox_TextChanged(object sender, EventArgs e)
        {
            var temp = this.temperatureTextbox.Text.Trim();

            if (!IsDecimalNumberValid(temp))
            {
                this.errorLabel.Text = $"Invalid Format: ({temp}) should only contains numbers and at least one decimal.";
            }
            else
            {
                this.errorLabel.Text = "";
            }
        }

        private void heightTextbox_TextChanged(object sender, EventArgs e)
        {
            var height = this.heightTextbox.Text.Trim();

            if (!IsDecimalNumberValid(height))
            {
                this.errorLabel.Text = $"Invalid Format: ({height}) should only contains numbers and at least one decimal.";
            }
            else
            {
                this.errorLabel.Text = "";
            }
        }

        private void weightTextbox_TextChanged(object sender, EventArgs e)
        {
            var weight = this.weightTextbox.Text.Trim();

            if (!IsDecimalNumberValid(weight))
            {
                this.errorLabel.Text = $"Invalid Format: ({weight}) should only contains numbers and at least one decimal.";
            }
            else
            {
                this.errorLabel.Text = "";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Visit visit = new Visit(this.appointment, Convert.ToDouble(this.weightTextbox.Text), Convert.ToDouble(this.heightTextbox.Text), Convert.ToInt32(this.bloodpressureTextBox.Text), this.symptomsTextbox.Text)
            {
                NurseID = this.nurse.NurseId,
                Pulse = Convert.ToInt32(this.pulseTextbox.Text.Trim()),
                Temperature = Convert.ToDouble(this.temperatureTextbox.Text.Trim()),
                InitialDiagnosis = this.diagnosisTextbox.Text.Trim()
            };

            if (visitDAL.InsertVisitInformation(visit))
            {
                AppointmentsPage apps = new AppointmentsPage(this.nurse);
                apps.Show();
                this.Close();
            } else
            {
                errorLabel.Text = "Could not insert visit information";
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            AppointmentsPage appointmentsPage = new AppointmentsPage(this.nurse);
            appointmentsPage.Show();
            this.Close();
        }

        private bool CheckIfAllFieldsAreCompleted()
        {
            return true;
        }
    }
}
