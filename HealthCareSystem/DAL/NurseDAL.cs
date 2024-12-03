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
    /// <summary>
    /// Data Access Layer (DAL) for performing database operations related to Nurses.
    /// Provides methods for retrieving and validating nurse data.
    /// </summary>
    public class NurseDAL
    {
        private readonly DataHelper databaseConnection;

        /// <summary>
        /// Initializes a new instance of the NurseDAL class.
        /// Establishes a connection helper for database operations.
        /// </summary>
        public NurseDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Retrieves a Nurse object by username.
        /// </summary>
        /// <param name="username">The username of the nurse.</param>
        /// <returns>A Nurse object if the username exists; otherwise, null.</returns>
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

        /// <summary>
        /// Validates the nurse's login credentials.
        /// </summary>
        /// <param name="username">The nurse's username.</param>
        /// <param name="password">The nurse's password.</param>
        /// <returns>A Nurse object if the credentials are valid; otherwise, null.</returns>
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
