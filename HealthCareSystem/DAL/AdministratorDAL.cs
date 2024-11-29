using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class AdministratorDAL
    {
        private readonly DataHelper databaseConnection;

        public AdministratorDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        public Administrator? ValidateAdministratorLogin(string username, string password)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM administrator WHERE username = @username AND password = @password";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Administrator(
                                reader["fname"].ToString(),
                                reader["lname"].ToString(),
                                Convert.ToDateTime(reader["birth_date"]),
                                (Gender)Enum.Parse(typeof(Gender), reader["gender"].ToString()),
                                reader["address"].ToString(),
                                reader["city"].ToString(),
                                reader["country"].ToString(),
                                Convert.ToInt32(reader["zipcode"]),
                                reader["phone_number"].ToString(),
                                reader["username"].ToString(),
                                reader["password"].ToString()
                            )
                            {
                                AdministratorId = Convert.ToInt32(reader["admin_id"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
