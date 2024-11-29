using HealthCareSystem.DAL;
using HealthCareSystem.Model;
using MySqlConnector;
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
    public partial class PoseQueriesPage : Form
    {
        private readonly DataHelper databaseConnection;
        private Administrator administrator;

        public PoseQueriesPage(Administrator admin)
        {
            InitializeComponent();

            this.administrator = admin;
            this.databaseConnection = new DataHelper();

            this.setAdminInformation();
        }

        private void setAdminInformation()
        {
            adminNameLabel.Text = $"Name: {this.administrator.Firstname} {this.administrator.Lastname}";
            adminIdLabel.Text = $"ID: {this.administrator.AdministratorId}";
            adminBirthdateLabel.Text = $"DOB: {this.administrator.Birthdate.ToString("yyyy-MM-dd")}";
        }

        private void getBackButton_Click(object sender, EventArgs e)
        {
            AdminMainPage mainPage = new AdminMainPage(this.administrator);
            mainPage.Show();

            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string query = sqlQueryTextBox.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a valid SQL query.", "Invalid Query", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var results = ExecuteCustomQuery(query);

                if (results != null && results.Rows.Count > 0)
                {
                    queryResultsDataGridView.DataSource = results;
                }
                else
                {
                    MessageBox.Show("Query executed successfully, but no data was returned.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ExecuteCustomQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

    }
}
