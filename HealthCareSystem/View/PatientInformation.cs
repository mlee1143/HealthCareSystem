using HealthCareSystem.DAL;
using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareSystem.View
{
    public partial class PatientInformation : Form
    {
        private PatientDAL patientDAL;

        private Nurse nurse;
        private Patient patient;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientInformation"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="patient">The patient.</param>
        public PatientInformation(Nurse nurse, Patient patient)
        {
            InitializeComponent();

            this.patientDAL = new PatientDAL();
            this.nurse = nurse;
            this.patient = patient;

            this.PopulateComboBoxes();
            this.PopulateFields();

            this.register_btn.Visible = false;
            this.register_btn.Enabled = false;
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientInformation"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        public PatientInformation(Nurse nurse)
        {
            InitializeComponent();

            this.nurse = nurse;

            this.patientDAL = new PatientDAL();

            this.PopulateComboBoxes();
            this.SetupRegisterForm();
            this.PopulateFields();
            
        }

        private void PopulateComboBoxes()
        {
            this.gender_cmbobx.DataSource = Enum.GetValues(typeof(Gender));
            this.states_combobox.DataSource = Enum.GetValues(typeof(States));
        }

        private void SetupRegisterForm()
        {
            this.update_btn.Enabled = false;
            this.update_btn.Visible = false;

            this.patientID_txtbx.Visible = false;
            this.patientID_txtbx.Enabled = false;

            this.ptId_label.Visible = false;
            this.ptId_label.Enabled = false;
        }

        private void PopulateFields()
        {
            this.nurseIdLabel.Text = $"ID: {this.nurse.NurseId}";
            this.nurseNameLabel.Text = $"Name: {this.nurse.Firstname} {this.nurse.Lastname}";

            if (patient != null)
            {
                this.patientID_txtbx.Text = this.patient.PatientId.ToString();
                this.pt_fname_txtbx.Text = this.patient.Firstname;
                this.minit_txtbx.Text = this.patient.MiddleInitial;
                this.pt_lname_txtbx.Text = this.patient.Lastname;
                this.birthdate_datepicker.Value = this.patient.Birthdate;
                this.address_txtbx.Text = this.patient.Address;
                this.city_txtbx.Text = this.patient.City;
                this.states_combobox.SelectedItem = this.patient.State;
                this.zip_txtbx.Text = this.patient.ZipCode.ToString();
                this.country_txtbx.Text = this.patient.Country;
                this.phone_num_txtbx.Text = this.patient.PhoneNumber;
                this.gender_cmbobx.SelectedItem = this.patient.Gender;

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

            }
           
        }

        private async void register_btn_Click(object sender, EventArgs e)
        {
            if (this.IsReadyToClick())
            {


                var fname = this.pt_fname_txtbx.Text;

                var minit = this.minit_txtbx.Text;

                var lname = this.pt_lname_txtbx.Text;

                DateTime date = this.birthdate_datepicker.Value;

                var address = this.address_txtbx.Text;

                var city = this.city_txtbx.Text;

                States state = (States)this.states_combobox.SelectedItem;

                var zip = Convert.ToInt32(this.zip_txtbx.Text);

                string country = this.country_txtbx.Text;

                var phone = this.phone_num_txtbx.Text;

                Gender gender = (Gender)this.gender_cmbobx.SelectedItem;

                int isActive = this.yesRadioButton.Checked == true ? 1 : 0;

                Patient patient = new Patient(fname, lname, date, gender, isActive)
                {
                    MiddleInitial = minit,
                    Address = address,
                    City = city,
                    State = state,
                    Country = country,
                    ZipCode = zip,
                    PhoneNumber = phone

                };

                await this.patientDAL.RegisterPatient(patient);

                MainPage main = new MainPage(this.nurse);
                main.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Please fill out ALL required fields");
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (this.IsReadyToClick())
            {
                var fname = this.pt_fname_txtbx.Text;

                var minit = this.minit_txtbx.Text;

                var lname = this.pt_lname_txtbx.Text;

                DateTime date = this.birthdate_datepicker.Value;

                var address = this.address_txtbx.Text;

                var city = this.city_txtbx.Text;

                States state = (States)this.states_combobox.SelectedItem;

                var zip = Convert.ToInt32(this.zip_txtbx.Text);

                string country = this.country_txtbx.Text;

                var phone = this.phone_num_txtbx.Text;

                Gender gender = (Gender)this.gender_cmbobx.SelectedItem;

                int isActive = this.yesRadioButton.Checked == true ? 1 : 0;

                Patient patient = new Patient(fname, lname, date, gender, isActive)
                {
                    MiddleInitial = minit,
                    Address = address,
                    City = city,
                    State = state,
                    Country = country,
                    ZipCode = zip,
                    PhoneNumber = phone
                };

                int patientID = Convert.ToInt32(this.patientID_txtbx.Text);

                await this.patientDAL.UpdatePatientInformationUsingID(patientID, patient);

                MainPage main = new MainPage(this.nurse);
                main.Show();
                this.Close();

            } else
            {
                MessageBox.Show("Please fill out ALL required fields.");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage(this.nurse);
            main.Show();
            this.Close();
        }

        private bool IsNameValid(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, "^[A-Za-z]+( [A-Za-z]+)?$");
        }

        private bool IsNumberValid(string number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(number, "^[0-9]+$");
        }

        private bool IsAddressValid(string address)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(address, "^[A - Za - z] + ([A - Za - z] +) ?$");
        }

        private void pt_fname_txtbx_TextChanged(object sender, EventArgs e)
        {
            var name = pt_fname_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = "First name cannot be empty";
            }
            else if (!IsNameValid(name))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"Invalid name format. {name} should contain only letters.";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
           
        }

        private void pt_lname_txtbx_TextChanged(object sender, EventArgs e)
        {
            var name = pt_lname_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = "Last name cannot be empty";
            }
            else if (!IsNameValid(name))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"Invalid name format. {name} should contain only letters.";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
            
        }

        private void address_txtbx_TextChanged(object sender, EventArgs e)
        {
            string address = address_txtbx.Text.Trim();

            if (this.IsAddressValid(address))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"Invalid Address Format: ({address} is invalid format.)";
            }
            else if (string.IsNullOrEmpty(address))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = "Address cannot be empty";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
           
        }

        private void city_txtbx_TextChanged(object sender, EventArgs e)
        {
            string city = city_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(city))
            {
                this.feedback_label.Visible = true;
                feedback_label.Text = "City cannot be empty";
            }
            else if (!IsNameValid(city))
            {
                this.feedback_label.Visible = true;
                feedback_label.Text = $"Invalid city format. {city} should contain only letters.";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
           
        }

        private void zip_txtbx_TextChanged(object sender, EventArgs e)
        {
            string zipcode = this.zip_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(zipcode))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = "Zipcode cannot be empty.";
            }
            else if (!IsNumberValid(zipcode))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"{zipcode} : Can only contain numbers.";
            }
            else if (zipcode.Length > 5)
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"{zipcode} : Can not be longer than 5 digits.";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
           
        }

        private void country_txtbx_TextChanged(object sender, EventArgs e)
        {
            string country = country_txtbx.Text.Trim();

            if (string.IsNullOrEmpty(country))
            {
                this.feedback_label.Visible = true;
                feedback_label.Text = "Country cannot be empty.";
            }
            else if (!IsNameValid(country))
            {
                this.feedback_label.Visible = true;
                feedback_label.Text = $"Invalid Country format. ({country}) should contain only letters.";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
           
        }

        private void phone_num_txtbx_TextChanged(object sender, EventArgs e)
        {
            string number = phone_num_txtbx.Text.Trim();


            if (string.IsNullOrEmpty(number))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = "Phone number cannot be empty.";
            }
            else if (!IsNumberValid(number))
            {
                this.feedback_label.Visible = true;
                feedback_label.Text = $"Invalid number format. Phone number: ({number}) should contain only numbers.";
            }
            else if (number.Length != 10)
            {
                this.feedback_label.Visible = true;
                feedback_label.Text = $"Phone number: ({number}) must be 10 digits";
            }
            else
            {
                this.feedback_label.Visible = false;
                feedback_label.Text = string.Empty;
            }
            
        }

        private void minit_txtbx_TextChanged(object sender, EventArgs e)
        {
            string minit = minit_txtbx.Text.Trim();

            if (!IsNameValid(minit))
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"Invalid format. Middle initial: ({minit}) should only contain letters";
            }
            else if (minit.Length > 1)
            {
                this.feedback_label.Visible = true;
                this.feedback_label.Text = $"Middle Initial: ({minit}) can only be 1 character";
            }
            else
            {
                this.feedback_label.Visible = false;
                this.feedback_label.Text = string.Empty;
            }
            
        }

        private bool IsReadyToClick()
        {
            if (!feedback_label.Visible)
            {
                if (pt_fname_txtbx.Text.Length > 0 && pt_lname_txtbx.Text.Length > 0 && address_txtbx.Text.Length > 0 && city_txtbx.Text.Length > 0 && states_combobox.SelectedItem != null && zip_txtbx.Text.Length > 0 && country_txtbx.Text.Length > 0 && gender_cmbobx.SelectedItem != null && phone_num_txtbx.Text.Length > 0)
                {
                   //this.register_btn.Enabled = true;
                   //this.update_btn.Enabled = true;
                    return true;
                }
            }
            return false;
        }
    }
}
