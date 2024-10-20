using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class PatientDAL
    {
        private readonly DataHelper databaseConnection;

        public PatientDAL()
        {
            this.databaseConnection = new DataHelper();
        }
        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM patient";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient(
                                reader["fname"].ToString(),
                                reader["lname"].ToString(),
                                Convert.ToDateTime(reader["bdate"]),
                                (Gender)Enum.Parse(typeof(Gender), reader["gender"].ToString()),
                                Convert.ToBoolean(reader["active"]),
                                (Symptom)Enum.Parse(typeof(Symptom), reader["symptom"].ToString())
                            )
                            {
                                PatientId = Convert.ToInt32(reader["patient_id"]),
                                MiddleInitial = reader["minitial"].ToString(),
                                Address = reader["address"].ToString(),
                                City = reader["city"].ToString(),
                                State = (States?)Enum.Parse(typeof(States), reader["state"].ToString()),
                                Country = reader["country"].ToString(),
                                ZipCode = reader["zipcode"] != DBNull.Value ? Convert.ToInt32(reader["zipcode"]) : (int?)null,
                                PhoneNumber = reader["phone_number"].ToString()
                            };

                            patients.Add(patient);
                        }
                    }
                }
            }

            return patients;
        }
}
