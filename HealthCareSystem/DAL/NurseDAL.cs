using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class NurseDAL
    {
        private readonly DataHelper databaseConnection;

        public NurseDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        public Nurse?  GetNurseByUsername(string username)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM nurse WHERE username = @username";


                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Nurse(
                                reader["fname"].ToString(),
                                reader["lname"].ToString(),
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
                                NurseId = Convert.ToInt32(reader["nurse_id"])

                            };
                        }
                    }
                }
            }
            return null;
        }

        public Nurse? ValidateNurseLogin(string username, string password)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM nurse WHERE username = @username AND password = @password";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Nurse(
                                reader["fname"].ToString(),
                                reader["lname"].ToString(),
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
                                NurseId = Convert.ToInt32(reader["nurse_id"])
                            };
                        }
                    }
                }
            }
            return null; 
        }
    }
}
