using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSystem.Model;
using MySqlConnector;

namespace HealthCareSystem.DAL
{
    public class DoctorDAL
    {
        private readonly DataHelper databaseConnection;

        public DoctorDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM doctor";

                using (var cmd = new MySqlCommand(query, connection))
                {
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

    }
}
