using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
                                Convert.ToInt32(reader["active"])
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

        public async Task<bool> RegisterPatient(Patient patient)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = $"insert into patient(fname, minitial, lname, bdate, gender, address, city, state, country, zipcode, phone_number, active) "
                             + $" values(@fname, @minitial, @lname, @bdate, @gender, @address, @city, @state, @country, @zipcode, @phone_number, @active);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fname", patient.Firstname);
                    command.Parameters.AddWithValue("@minitial", patient.MiddleInitial);
                    command.Parameters.AddWithValue("@lname", patient.Lastname);
                    command.Parameters.AddWithValue("@bdate", patient.Birthdate);
                    command.Parameters.AddWithValue("@gender", patient.Gender.ToString());
                    command.Parameters.AddWithValue("@address", patient.Address);
                    command.Parameters.AddWithValue("@city", patient.City);
                    command.Parameters.AddWithValue("@state", patient.State.ToString());
                    command.Parameters.AddWithValue("@country", patient.Country);
                    command.Parameters.AddWithValue("@zipcode", patient.ZipCode);
                    command.Parameters.AddWithValue("@phone_number", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@active", patient.IsActive);

                    int affected = await command.ExecuteNonQueryAsync();
                    return affected > 1;
                }

                
            }
        }

        public async Task<bool> UpdatePatientInformation(Patient patient)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "UPDATE patient " +
                       "SET minitial = @minitial, " +
                        "gender = @gender, " + 
                        "address = @address, " +
                        "city = @city, " +
                        "state = @state, " +
                        "country = @country, " +
                        "zipcode = @zipcode, " +
                        "bdate = @bdate, " +
                        "phone_number = @phone_number, " +
                        "active = @active " +
                       "WHERE fname = @fname AND lname = @lname;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fname", patient.Firstname);
                    command.Parameters.AddWithValue("@lname", patient.Lastname);
                    command.Parameters.AddWithValue("@bdate", patient.Birthdate);

                    command.Parameters.AddWithValue("@minitial", patient.MiddleInitial);
                    command.Parameters.AddWithValue("@gender", patient.Gender.ToString());
                    command.Parameters.AddWithValue("@address", patient.Address);
                    command.Parameters.AddWithValue("@city", patient.City);
                    command.Parameters.AddWithValue("@state", patient.State.ToString());
                    command.Parameters.AddWithValue("@country", patient.Country);
                    command.Parameters.AddWithValue("@zipcode", patient.ZipCode);
                    command.Parameters.AddWithValue("@phone_number", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@active", patient.IsActive);

                    int affected = await command.ExecuteNonQueryAsync();

                    return affected > 1;
                }
            }
        }

        public async Task<bool> UpdatePatientInformationUsingID(Patient patient)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "UPDATE patient " +
                       "SET minitial = @minitial, " +
                        "gender = @gender, " +
                        "address = @address, " +
                        "city = @city, " +
                        "state = @state, " +
                        "country = @country, " +
                        "zipcode = @zipcode, " +
                        "phone_number = @phone_number, " +
                        "active = @active " +
                       "WHERE patient_id = @id;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", patient.PatientId); 
                    //command.Parameters.AddWithValue("@fname", patient.Firstname);
                    //command.Parameters.AddWithValue("@lname", patient.Lastname);
                    //command.Parameters.AddWithValue("@bdate", patient.Birthdate);

                    command.Parameters.AddWithValue("@minitial", patient.MiddleInitial);
                    command.Parameters.AddWithValue("@gender", patient.Gender.ToString());
                    command.Parameters.AddWithValue("@address", patient.Address);
                    command.Parameters.AddWithValue("@city", patient.City);
                    command.Parameters.AddWithValue("@state", patient.State.ToString());
                    command.Parameters.AddWithValue("@country", patient.Country);
                    command.Parameters.AddWithValue("@zipcode", patient.ZipCode);
                    command.Parameters.AddWithValue("@phone_number", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@active", patient.IsActive);

                    int affected = await command.ExecuteNonQueryAsync();

                    return affected > 1;
                }
            }
        }

        public Patient GetPatientByID(int id)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString())) {
                connection.Open();

                string query = "SELECT * FROM patient WHERE patient_id = @id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Patient(
                                reader["fname"].ToString(),
                                reader["lname"].ToString(),
                                Convert.ToDateTime(reader["bdate"]),
                                (Gender)Enum.Parse(typeof(Gender), reader["gender"].ToString()),
                                Convert.ToInt32(reader["active"]))
                            {
                                PatientId = Convert.ToInt32(reader["patient_id"]),
                                MiddleInitial = reader["minitial"].ToString(),
                                Address = reader["address"].ToString(),
                                City = reader["city"].ToString(),
                                State = (States)Enum.Parse(typeof(States), reader["state"].ToString()),
                                Country = reader["country"].ToString(),
                                ZipCode = Convert.ToInt32(reader["zipcode"].ToString()),
                                PhoneNumber = reader["phone_number"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Patient> GetActivePatients()
        {
            List<Patient> activePatients = new List<Patient>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM patient WHERE active = 1";

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
                                Convert.ToInt32(reader["active"])
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

                            activePatients.Add(patient);
                        }
                    }
                }
            }

            return activePatients;
        }


    }
}
