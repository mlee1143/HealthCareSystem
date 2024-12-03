using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSystem.Model;
using MySqlConnector;

namespace HealthCareSystem.DAL
{
    /// <summary>
    /// Data Access Layer (DAL) for performing database operations related to doctors.
    /// Provides methods to retrieve doctor information and names based on their ID.
    /// </summary>
    public class DoctorDAL
    {
        private readonly DataHelper databaseConnection;

        /// <summary>
        /// Initializes a new instance of the DoctorDAL class.
        /// Establishes a connection helper for database operations.
        /// </summary>
        public DoctorDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Retrieves all doctors from the database.
        /// </summary>
        /// <returns>A list of Doctor objects containing detailed information about each doctor.</returns>
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("GetAllDoctors", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor(
                                reader.GetInt32("doctor_id"),
                                reader["fname"].ToString(),
                                reader["lname"].ToString()
                            )
                            {
                                Birthdate = Convert.ToDateTime(reader["birth_date"]),
                                Gender = (Gender)Enum.Parse(typeof(Gender), reader["gender"].ToString()),
                                Address = reader["address"].ToString(),
                                City = reader["city"].ToString(),
                                State = (States?)Enum.Parse(typeof(States), reader["state"].ToString()),
                                Country = reader["country"].ToString(),
                                ZipCode = reader["zipcode"] != DBNull.Value ? Convert.ToInt32(reader["zipcode"]) : (int?)null,
                                PhoneNumber = reader["phone_number"].ToString()
                            };

                            doctors.Add(doctor);
                        }
                    }
                }

            }

                return doctors;
        }

        /// <summary>
        /// Retrieves the full name of a doctor based on their unique ID.
        /// </summary>
        /// <param name="id">The unique identifier of the doctor.</param>
        /// <returns>The full name of the doctor as a string if found; otherwise, null.</returns>
        public string GetDoctorNameByDoctorID(int id)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("GetDoctorNameByDoctorId", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input_id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["full_name"].ToString();
                        }
                    }
                }
            }
            return null;
        }

    }
}
