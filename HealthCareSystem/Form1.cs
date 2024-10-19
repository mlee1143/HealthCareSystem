using HealthCareSystem.DAL;
using HealthCareSystem.Model;

namespace HealthCareSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // this.testConnection();

            Console.WriteLine("Found?");
        }

        private void testConnection()
        {
            NurseDAL dal = new NurseDAL();

            Nurse? nurse = dal.GetNurseByUsername("shinigami");

            Console.WriteLine(nurse.Firstname + " " + nurse.Lastname);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NurseDAL dal = new NurseDAL();

            Nurse? nurse = dal.GetNurseByUsername("shinigami");

            Label Mylablel = new Label();
            Mylablel.Location = new Point(96, 54);
            Mylablel.Text = nurse.Firstname + " " + nurse.Lastname;
            Mylablel.AutoSize = true;
            Mylablel.BackColor = Color.LightGray;

            // Add this label to form
            this.Controls.Add(Mylablel);
        }
    }
}
