using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    /// <summary>
    /// PatientDAl class.
    /// </summary>
    public class PatientDAL
    {
        private readonly DataHelper databaseConnection;

        /// <summary>
        /// PatientDAL constructor.
        /// </summary>
        public PatientDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Gets all the patients from the database.
        /// </summary>
        /// <returns> A list of all patients from the database.</returns>
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

        /// <summary>
        /// Registers a patient.
        /// </summary>
        /// <param name="patient"> The patient being registered.</param>
        /// <returns> True if updated, false otherwise.</returns>
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

        /// <summary>
        /// Updates the patient information.
        /// </summary>
        /// <param name="patient"> The patient who is updating infromation.</param>
        /// <returns> True if patient updated, false otherwise.</returns>
        public async Task<bool> UpdatePatientInformation(Patient patient)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString())) // FIX to update names too. BOTH Updates
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

        /// <summary>
        /// Updates the patient information.
        /// </summary>
        /// <param name="patientID"> The patient ID</param>
        /// <param name="patient"> The patient.</param>
        /// <returns> True if patient was updated, false otherwise.</returns>
        public async Task<bool> UpdatePatientInformationUsingID(int patientID, Patient patient)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "UPDATE patient " +
                       "SET fname = @fname, " +
                       "minitial = @minitial, " +
                       "lname = @lname, " +
                        "gender = @gender, " +
                        "address = @address, " +
                        "city = @city, " +
                        "state = @state, " +
                        "country = @country, " +
                        "zipcode = @zipcode, " +
                        "bdate = @bdate, " +
                        "phone_number = @phone_number, " +
                        "active = @active " +
                       "WHERE patient_id = @id;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", patientID);

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

        /// <summary>
        /// Gets the Patient from database by ID
        /// </summary>
        /// <param name="id">id of the patient being searched for.</param>
        /// <returns>patient from database.</returns>
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

        /// <summary>
        /// Gets a list of active patients
        /// </summary>
        /// <returns> A list of active patients.</returns>
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

        /// <summary>
        /// Gets a list of patients with specified first name and last name
        /// </summary>
        /// <param name="firstName"> The first name.</param>
        /// <param name="lastName"> The last name.</param>
        /// <returns> A list of patients who have the specified first name and last name.</returns>
        public async Task<List<Patient>> GetPatientsByName(string firstName, string lastName)
        {
            var patients = new List<Patient>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "SELECT * FROM patient WHERE fname = @fname AND lname = @lname";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fname", firstName);
                    command.Parameters.AddWithValue("@lname", lastName);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
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

        /// <summary>
        /// Gets a list of patients who have the specified birthdate.
        /// </summary>
        /// <param name="dob"> The dob being searched.</param>
        /// <returns> A list of patients who have the specified birthdate.</returns>
        public async Task<List<Patient>> GetPatientsByBirthdate(DateTime dob)
        {
            var patients = new List<Patient>();

            var bdate = dob.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "SELECT * FROM patient WHERE bdate = @bdate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bdate", bdate);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
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

        /// <summary>
        /// Gets a list of patients by specified name and birthdate.
        /// </summary>
        /// <param name="firstname">The first name.</param>
        /// <param name="lastname"> The last name.</param>
        /// <param name="dob"> The dob</param>
        /// <returns> Returns a list of patients retrieved by the specified first name, last name and birthdate.</returns>
        public async Task<List<Patient>> GetPatientsByNameAndBirthdate(string firstname, string lastname, DateTime dob)
        {
            var patients = new List<Patient>();

            var bdate = dob.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "SELECT * FROM patient WHERE fname = @fname AND lname = @lname AND bdate = @bdate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fname", firstname);
                    command.Parameters.AddWithValue("@lname", lastname);
                    command.Parameters.AddWithValue("@bdate", bdate);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
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

        /// <summary>
        /// Get the name of the patient from ID
        /// </summary>
        /// <param name="id"> The specified ID.</param>
        /// <returns> The patient name from the specified ID.</returns>
        public string GetPatientNameFromPatientID(int id)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT fname, lname FROM patient WHERE patient_id = @id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["fname"].ToString() + " " + reader["lname"].ToString();
                        }
                    }
                }
            }
            return null;
        }


    }
}
