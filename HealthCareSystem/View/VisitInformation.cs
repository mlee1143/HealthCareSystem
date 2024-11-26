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
        public Nurse nurse { get; set; }
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

            this.nurseNameLabel.Text += $"{this.nurse.Firstname} {this.nurse.Lastname}";
            this.nurseIdLabel.Text += $"{this.nurse.NurseId}";

            this.SetupCurrentVisit();
        }

        private void SetupCurrentVisit()
        {
            if (visitDAL.VisitInformationExistsAlready(appointment.PatientID, appointment.AppointmentDateTime))
            {
                this.checkupCheckbox.Checked = true;
                Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
                this.PopulateFields(visit);

                this.routineGroupBox.Visible = false;
                this.diagnosisGroupbox.Visible = true;
                this.diagnosisButton.Enabled = true;
            }

            if (visitDAL.InitialDiagnosisExistsForVisit(appointment.PatientID, appointment.AppointmentDateTime))
            {
                this.routineGroupBox.Visible = false;
                this.checkupCheckbox.Checked = true;
                this.diagnosisGroupbox.Visible = true;
                this.diagnosisButton.Enabled = true;

                Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
                this.PopulateDiagnosis(visit);

                this.orderTestButton.Enabled = true;
            }

            if (visitDAL.FinalDiagnosisExistsForVisit(appointment.PatientID, appointment.AppointmentDateTime))
            {
                this.routineGroupBox.Visible = false;
                this.diagnosisGroupbox.Visible = false;

                this.diagnosisButton.Enabled = false;
                this.checkupButton.Enabled = false;
                this.completedButton.Enabled = true;

                this.completeInformationGroupbox.Visible = true;

                this.diagnosisCheckbox.Checked = true;
                this.checkupCheckbox.Checked = true;
                this.completedCheckbox.Checked = true;

                this.orderTestButton.Enabled = true;

                Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
                this.PopulateSummary(visit);
            }
        }

        private void PopulateFields(Visit visit)
        {
            this.heightTextbox.Text = visit.Height.ToString();
            this.weightTextbox.Text = visit.Weight.ToString();

            string[] bp_values = visit.BloodPressure.Split('/');

            this.systolicTextBox.Text = bp_values[0];
            this.distolicTextbox.Text = bp_values[1];

            this.pulseTextbox.Text = visit.Pulse.ToString();
            this.temperatureTextbox.Text = visit.Temperature.ToString();
            this.symptomsTextbox.Text = visit.SymptomsDescription.ToString();
        }

        private void PopulateDiagnosis(Visit visit)
        {
            this.diagnosisTextbox.Text = visit.InitialDiagnosis;
            this.finalDiagnosisTextbox.Text = visit.FinalDiagnosis;
        }

        private void PopulateSummary(Visit visit)
        {
            this.heightLabelSummary.Text += visit.Height;
            this.weightLabelSummary.Text += visit.Weight;
            this.temperatureLabelSummary.Text += visit.Temperature;
            this.pulseLabelSummary.Text += visit.Pulse;
            this.bloodpressureLabelSummary.Text += visit.BloodPressure;
            this.symptomsLabelSummary.Text += visit.SymptomsDescription;
            this.initialDiagnosisLabelSummary.Text += visit.InitialDiagnosis;
            this.finalDiagnosisLabelSummary.Text += visit.FinalDiagnosis;

          

            //LabTestDAL labDal = new LabTestDAL();
           // List<LabTest> tests = labDal.GetLabTestsForVisit(visit.PatientID, visit.DoctorID, this.nurse.NurseId, visit.AppointmentDateTime);

            //orderedTestsGridview.Columns.Clear();
            //orderedTestsGridview.Columns.Add("TestCode", "Test Code");
            //orderedTestsGridview.Columns.Add("TestName", "Test Name");
            //orderedTestsGridview.Columns.Add("TestDateTime", "Test Date/Time");

            //orderedTestsGridview.Rows.Clear();
           // foreach (LabTest test in tests)
           // {
           //    this.orderedTestsGridview.Rows.Add(test.TestCode, test.TestName, test.TestDateTime);
          //  }

           
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
            var bp = systolicTextBox.Text.Trim();

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
            var pulse = pulseTextbox.Text.Trim();

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
            // CHECK FOR WHEN TO UPDATE INSTEAD OF INSERTING
            if (CheckIfAllFieldsAreCompleted())
            {
                string bloodpressure = $" {this.systolicTextBox.Text}/{this.distolicTextbox.Text}";
                Visit visit = new Visit(this.appointment, Convert.ToDouble(this.weightTextbox.Text), Convert.ToDouble(this.heightTextbox.Text), bloodpressure, this.symptomsTextbox.Text)
                {
                    NurseID = this.nurse.NurseId,
                    Pulse = Convert.ToInt32(this.pulseTextbox.Text.Trim()),
                    Temperature = Convert.ToDouble(this.temperatureTextbox.Text.Trim())

                };

                if (visitDAL.VisitInformationExistsAlready(this.appointment.PatientID, this.appointment.AppointmentDateTime))
                {
                    if (this.visitDAL.UpdateVisitInformationCheckUp(this.appointment.PatientID, this.appointment.AppointmentDateTime, visit))
                    {
                        MessageBox.Show("Update of visit information successful.");
                    }

                }
                else
                {
                    if (this.visitDAL.InsertVisitInformation(visit))
                    {
                        this.checkupCheckbox.Checked = true;
                        this.diagnosisGroupbox.Visible = true;
                        this.routineGroupBox.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Could NOT insert Visit information.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please fill out ALL the fields before submitting.");
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
            if (this.weightTextbox.Text.Length > 0 && this.heightTextbox.Text.Length > 0 && this.temperatureTextbox.Text.Length > 0 && this.systolicTextBox.Text.Length > 0 && this.distolicTextbox.Text.Length > 0 && this.pulseTextbox.Text.Length > 0 && this.symptomsTextbox.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void patientnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void diagnosisTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (this.diagnosisTextbox.Text.Length > 0)
            {
                this.visitDAL.UpdateInitialDiagnosisForVisit(this.diagnosisTextbox.Text, appointment.PatientID, appointment.AppointmentDateTime);
                this.orderTestButton.Enabled = true;

            }
            else
            {
                MessageBox.Show("No diagnosis to update. Please enter an initial diagnosis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (this.finalDiagnosisTextbox.Text.Length > 0)
            {
                const string message =
                    "Are you sure that you want to Confirm the final diagnosis? " +
                    "Once confirmed cannot go back and make changes to the visit.";

                const string caption = "Visit Information Confirmation";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.checkupButton.Enabled = false;
                    this.diagnosisButton.Enabled = false;
                    this.diagnosisCheckbox.Checked = true;
                    this.completedCheckbox.Checked = true;
                    this.completedButton.Enabled = true;

                    this.diagnosisGroupbox.Visible = false;
                    this.completeInformationGroupbox.Visible = true;

                    this.visitDAL.UpdateFinalDiagnosisForVisit(this.finalDiagnosisTextbox.Text, this.appointment.PatientID, this.appointment.AppointmentDateTime);

                    Visit visit = visitDAL.GetVisitByPatientIDAndAppointmentDateTime(appointment);
                    this.PopulateSummary(visit);
                }

            }
        }

        private void diagnosisButton_Click(object sender, EventArgs e)
        {
            this.diagnosisGroupbox.Visible = true;
            this.routineGroupBox.Visible = false;
            this.completeInformationGroupbox.Visible = false;
        }

        private void checkupButton_Click(object sender, EventArgs e)
        {
            this.routineGroupBox.Visible = true;
            this.diagnosisGroupbox.Visible = false;
            this.completeInformationGroupbox.Visible = false;
        }

        private void orderTestButton_Click(object sender, EventArgs e)
        {
            var patientName = patientDAL.GetPatientByID(appointment.PatientID);
            var doctorName = doctorDAL.GetDoctorNameByDoctorID(appointment.DoctorID);

            OrderTestPage otestPage = new OrderTestPage(this.nurse, this.appointment.PatientID, patientName.FullName, this.appointment.DoctorID, doctorName, appointment.AppointmentDateTime, this.nurse.NurseId);

            otestPage.Show();
            this.Close();
        }

    }
}
