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
        public VisitInformation()
        {
            InitializeComponent();
        }

        private bool IsNumberValid(string number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(number, "^[0-9]+$");
        }

        private void bloodpressureTextBox_TextChanged(object sender, EventArgs e)
        {
            var bp = bloodpressureTextBox.Text.Trim();
        }

        private void pulseTextbox_TextChanged(object sender, EventArgs e)
        {
            var pulse  = pulseTextbox.Text.Trim();
        }

        private void temperatureTextbox_TextChanged(object sender, EventArgs e)
        {
            var temp = this.temperatureTextbox.Text.Trim();
        }

        private void heightTextbox_TextChanged(object sender, EventArgs e)
        {
            var height = this.heightTextbox.Text.Trim();
        }

        private void weightTextbox_TextChanged(object sender, EventArgs e)
        {
            var weight = this.weightTextbox.Text.Trim();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //AppointmentsPage appointmentsPage = new AppointmentsPage();
            //main.Show();
            //this.Close();
        }
    }
}
