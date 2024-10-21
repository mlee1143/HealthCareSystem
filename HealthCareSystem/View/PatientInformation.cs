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

        private void register_btn_Click(object sender, EventArgs e)
        {
            var fname = this.pt_fnamelabel.Text;
            var lname = this.pt_lnamelabel.Text;
            var minit = this.minit_txtbx.Text;
            Gender gender = Gender.Male;//(Gender) Enum.Parse(typeof(Gender), this.genderGroupBox.Controls.);
            var address = this.address_label.Text;
            var city = this.cityLabel.Text;
            var zip = Convert.ToInt32(this.zip_label.Text);
            var phone = this.phone_num_label.Text;
            States state = (States) Enum.Parse(typeof(States), this.state_label.Text);


            int isActive = this.yesRadioButton.Checked == true ? 1 : 0;

            Patient patient = new Patient(fname, lname, DateTime.Now, gender, isActive)
            {
                Address = address,
                City = city,
                State = state,
                ZipCode = zip,
                PhoneNumber = phone

            };

             this.patientDAL.RegisterPatient(patient);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void PatientInformation_Load(object sender, EventArgs e)
        {

        }


    }
}
