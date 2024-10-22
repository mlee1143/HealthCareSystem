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
    public partial class PatientInformation : Form
    {
        private PatientDAL patientDAL;

        private int id;
        private string name;
        private Patient patient;

        public List<States> States { get; } = Enum.GetValues(typeof(States)).Cast<States>().ToList();

        public PatientInformation(int id, string name, Patient patient)
        {
            InitializeComponent();

            this.patientDAL = new PatientDAL();

            this.id = id;
            this.name = name;
            this.patient = patient;

            this.PopulateFields();

        }


        public PatientInformation(int id, string name)
        {
            InitializeComponent();

            this.patientDAL = new PatientDAL();

            this.id = id;
            this.name = name;

        }

        private void PopulateFields()
        {
            this.nurseIdLabel.Text = $"ID: {this.id}";
            this.nurseNameLabel.Text = $"Name: {this.name}";

            this.pt_fnamelabel.Text = this.patient.Firstname;
            this.pt_lnamelabel.Text = this.patient.Lastname;
            this.address_label.Text = this.patient.Address;
            this.zip_label.Text = this.patient.ZipCode.ToString();
            this.bdate_label.Text = this.patient.Birthdate.ToShortDateString();
            this.phone_num_label.Text = this.patient.PhoneNumber;
            this.minit_txtbx.Text = this.patient.MiddleInitial;
            this.city_txtbx.Text = this.patient.City;
            this.state_label.Text = (this.patient.State.ToString());

            if (patient.IsActive == 1)
            {
                this.yesRadioButton.Checked = true;
                this.noRadioButton.Checked = false;
            }
            else
            {
                this.noRadioButton.Checked = true;
                this.yesRadioButton.Checked = false;
            }

            if (patient.Gender == Gender.Male)
            {
                this.maleRadioButton.Checked = true;
                this.femaleRadioButton.Checked = false;
            }
            else
            {
                this.femaleRadioButton.Checked = true;
                this.maleRadioButton.Checked = false;
            }

        }

        private async void register_btn_Click(object sender, EventArgs e)
        {
            var fname = this.pt_fnamelabel.Text;
            var lname = this.pt_lnamelabel.Text;
            var minit = this.minit_txtbx.Text;
            Gender gender;
            Enum.TryParse(this.GetSelectedRadioButtonTag(), out gender);
            var address = this.address_label.Text;
            var city = this.city_txtbx.Text;
            var zip = Convert.ToInt32(this.zip_label.Text);
            var phone = this.phone_num_label.Text;
            States state = (States)Enum.Parse(typeof(States), this.state_label.Text);

            DateTime date = DateTime.Parse(this.bdate_label.Text);
            int isActive = this.yesRadioButton.Checked == true ? 1 : 0;

            Patient patient = new Patient(fname, lname, date, gender, isActive)
            {
                MiddleInitial = minit,
                Address = address,
                City = city,
                State = state,
                Country = "USA",
                ZipCode = zip,
                PhoneNumber = phone

            };

            await this.patientDAL.RegisterPatient(patient);

            MainPage main = new MainPage(this.id, this.name);
            main.Show();
            this.Close();
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            var fname = this.pt_fnamelabel.Text;
            var lname = this.pt_lnamelabel.Text;
            var minit = this.minit_txtbx.Text;
            Gender gender;
            Enum.TryParse(this.GetSelectedRadioButtonTag(), out gender);
            var address = this.address_label.Text;
            var city = this.city_txtbx.Text;
            var zip = Convert.ToInt32(this.zip_label.Text);
            var phone = this.phone_num_label.Text;
            States state = (States)Enum.Parse(typeof(States), this.state_label.Text);

            DateTime date = DateTime.Parse(this.bdate_label.Text);

            int isActive = this.yesRadioButton.Checked == true ? 1 : 0;

            Patient patient = new Patient(fname, lname, date, gender, isActive)
            {
                MiddleInitial = minit,
                Address = address,
                City = city,
                State = state,
                Country = "USA",
                ZipCode = zip,
                PhoneNumber = phone

            };

            await this.patientDAL.UpdatePatientInformation(patient);

            MainPage main = new MainPage(this.id, this.name);
            main.Show();
            this.Close();

        }

        private string GetSelectedRadioButtonTag()
        {
            foreach (Control curr in this.genderGroupBox.Controls)
            {
                if (curr is RadioButton radioBtn && radioBtn.Checked == true)
                {
                    return radioBtn.Tag.ToString();
                }
            }
            return null;
        }

        private bool IsNameValid(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, "^[A-Za-z]+$");
        }

        private bool IsNumberValid(string number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(number, "^[0-9]+$");
        }

        private void phone_num_label_TextChanged(object sender, EventArgs e)
        {
            string number = phone_num_label.Text.Trim();

            if (string.IsNullOrWhiteSpace(number))
            {
                this.feedback_label.Text = "Phone number cannot be empty";
            }
            else if (!IsNumberValid(number))
            {
                this.feedback_label.Text = $"Invalid number format. Phone number: ({number}) should contain only numbers.";
            }
            else if (number.Length != 10)
            {
                this.feedback_label.Text = $"Phone number: ({number}) must be 10 digits";
            }
            else
            {
                this.feedback_label.Text = "";
            }
        }

        private void zip_label_TextChanged(object sender, EventArgs e)
        {
            string zipcode = this.zip_label.Text.Trim();

            if (string.IsNullOrWhiteSpace(zipcode))
            {
                this.feedback_label.Text = "Zip code cannot be empty";
            }
            else if (!IsNumberValid(zipcode))
            {
                this.feedback_label.Text = $"Invalid number format. Zipcode: ({zipcode}) should contain only numbers.";
            }
            else if (zipcode.Length > 5)
            {
                this.feedback_label.Text = $"Zip code: ({zipcode}) must be 5 digits";
            }
            else
            {
                this.feedback_label.Text = "";
            }
        }
    }
}
