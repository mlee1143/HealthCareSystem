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

            this.pt_fname_txtbx.Text = this.patient.Firstname;
            this.pt_lname_txtbx.Text = this.patient.Lastname;
            this.address_txtbx.Text = this.patient.Address;
            this.zip_txtbx.Text = this.patient.ZipCode.ToString();
            this.bdate_txtbx.Text = this.patient.Birthdate.ToShortDateString();
            this.phone_num_txtbx.Text = this.patient.PhoneNumber;
            this.minit_txtbx.Text = this.patient.MiddleInitial;
            this.city_txtbx.Text = this.patient.City;
            this.state_label.Text = (this.patient.State.ToString());
            this.country_txtbx.Text = this.patient.Country;
            this.patientID_txtbx.Text = this.patient.PatientId.ToString();

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
            var fname = this.pt_fname_txtbx.Text;
            var lname = this.pt_lname_txtbx.Text;
            var minit = this.minit_txtbx.Text;
            Gender gender;
            Enum.TryParse(this.GetSelectedRadioButtonTag(), out gender);
            var address = this.address_txtbx.Text;
            var city = this.city_txtbx.Text;
            var zip = Convert.ToInt32(this.zip_txtbx.Text);
            var phone = this.phone_num_txtbx.Text;
            States state = (States)Enum.Parse(typeof(States), this.state_label.Text);

            DateTime date = DateTime.Parse(this.bdate_txtbx.Text);
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
            var fname = this.pt_fname_txtbx.Text;
            var lname = this.pt_lname_txtbx.Text;
            var minit = this.minit_txtbx.Text;
            Gender gender;
            Enum.TryParse(this.GetSelectedRadioButtonTag(), out gender);
            var address = this.address_txtbx.Text;
            var city = this.city_txtbx.Text;
            var zip = Convert.ToInt32(this.zip_txtbx.Text);
            var phone = this.phone_num_txtbx.Text;
            States state = (States)Enum.Parse(typeof(States), this.state_label.Text);

            DateTime date = DateTime.Parse(this.bdate_txtbx.Text);

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



        private void back_btn_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage(this.id, this.name);
            main.Show();
            this.Close();
        }

        private void pt_fname_txtbx_TextChanged(object sender, EventArgs e)
        {
            var name = pt_fname_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                this.feedback_label.Text = "First name cannot be empty";
            }
            else if (!IsNameValid(name))
            {
                this.feedback_label.Text = $"Invalid name format. {name} should contain only letters.";
            }
            else
            {
                this.feedback_label.Text = string.Empty;
            }
        }

        private void pt_lname_txtbx_TextChanged(object sender, EventArgs e)
        {
            var name = pt_lname_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                this.feedback_label.Text = "Last name cannot be empty";
            }
            else if (!IsNameValid(name))
            {
                this.feedback_label.Text = $"Invalid name format. {name} should contain only letters.";
            }
            else
            {
                this.feedback_label.Text = string.Empty;
            }

        }

        private void birthdate_datepicker_ValueChanged(object sender, EventArgs e)
        {
            var date = this.birthdate_datepicker.Value;


        }

        private void address_txtbx_TextChanged(object sender, EventArgs e)
        {
            string address = address_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(address))
            {
                this.feedback_label.Text = "Address cannot be empty";
            }
            else
            {
                this.feedback_label.Text = string.Empty;
            }
        }

        private void city_txtbx_TextChanged(object sender, EventArgs e)
        {
            string city = city_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(city))
            {
                feedback_label.Text = "City cannot be empty";
            }
            else if (!IsNameValid(city))
            {
                feedback_label.Text = $"Invalid city format. {city} should contain only letters.";
            }
            else
            {
                this.feedback_label.Text = string.Empty;
            }
        }

        private void states_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zip_txtbx_TextChanged(object sender, EventArgs e)
        {
           string zipcode = this.zip_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(zipcode))
            {
                this.feedback_label.Text = "Zipcode cannot be empty.";
            } else if (!IsNumberValid(zipcode))
            {
                this.feedback_label.Text = $"{zipcode} : Can only contain numbers.";
            } else if (zipcode.Length > 5)
            {
                this.feedback_label.Text = $"{zipcode} : Can not be longer than 5 digits.";
            } else
            {
                this.feedback_label.Text = string.Empty;
            }

        }

        private void country_txtbx_TextChanged(object sender, EventArgs e)
        {
            string country = country_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(country))
            {
                feedback_label.Text = "Country cannot be empty.";
            }
            else if (!IsNameValid(country))
            {
                feedback_label.Text = $"Invalid Country format. ({country}) should contain only letters.";
            }
            else
            {
                this.feedback_label.Text = string.Empty;
            }
        }

        private void phone_num_txtbx_TextChanged(object sender, EventArgs e)
        {
            string number = phone_num_txtbx.Text.Trim();
            

            if (string.IsNullOrEmpty(number))
            {
                this.feedback_label.Text = "Phone number cannot be empty.";
            }
            else if (!IsNumberValid(number))
            {
                feedback_label.Text = $"Invalid number format. Phone number: ({number}) should contain only numbers.";
            }
            else if (number.Length != 10)
            {
                feedback_label.Text = $"Phone number: ({number}) must be 10 digits";
            }
            else
            {
                feedback_label.Text = string.Empty;
            }
        }

        private void minit_txtbx_TextChanged(object sender, EventArgs e)
        {
            string minit = minit_txtbx.Text.Trim();

            if (!IsNameValid(minit))
            {
                this.feedback_label.Text = $"Invalid format. Middle initial: ({minit}) should only contain letters";
            } else if (minit.Length > 1)
            {
                this.feedback_label.Text = $"Middle Initial: ({minit}) can only be 1 character";
            } else
            {
                this.feedback_label.Text = string.Empty;
            }
        }
    }
}
