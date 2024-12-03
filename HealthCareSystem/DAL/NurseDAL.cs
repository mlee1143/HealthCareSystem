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

                using (var cmd = new MySqlCommand("GetNurseByUsername", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

                using (var cmd = new MySqlCommand("ValidateNurseLogin", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input_username", username);
                    cmd.Parameters.AddWithValue("@input_password", password);

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
