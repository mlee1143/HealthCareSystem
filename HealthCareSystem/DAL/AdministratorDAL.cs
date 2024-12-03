using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    /// <summary>
    /// Data Access Layer (DAL) for performing database operations related to the Administrator.
    /// Provides methods to validate login and retrieve visit reports.
    /// </summary>
    public class AdministratorDAL
    {
        private readonly DataHelper databaseConnection;

        /// <summary>
        /// Initializes a new instance of the AdministratorDAL class.
        /// Establishes a connection helper for database operations.
        /// </summary>
        public AdministratorDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Validates the administrator's login credentials.
        /// </summary>
        /// <param name="username">The administrator's username.</param>
        /// <param name="password">The administrator's password.</param>
        /// <returns>
        /// An Administrator object if credentials are valid; otherwise, null.
        /// </returns>
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

        /// <summary>
        /// Retrieves a list of visit reports within a specified date range.
        /// </summary>
        /// <param name="startDate">The start date for the report.</param>
        /// <param name="endDate">The end date for the report.</param>
        /// <returns>
        /// A list of visit reports as dynamic objects containing patient, doctor, and nurse details.
        /// </returns>
        public List<dynamic> GetVisitReports(DateTime startDate, DateTime endDate)
        {
            List<dynamic> visits = new List<dynamic>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT v.appointment_datetime AS VisitDate,
                p.patient_id AS PatientId, CONCAT(p.fname, ' ', p.lname) AS PatientName,
                d.doctor_id AS DoctorId, CONCAT(d.fname, ' ', d.lname) AS DoctorName,
                n.nurse_id AS NurseId, CONCAT(n.fname, ' ', n.lname) AS NurseName,
                v.initial_diagnosis AS InitialDiagnosis,
                v.final_diagnosis AS FinalDiagnosis
                FROM visit v
                JOIN patient p ON v.patient_id = p.patient_id
                JOIN doctor d ON v.doctor_id = d.doctor_id
                JOIN nurse n ON v.nurse_id = n.nurse_id
                WHERE v.appointment_datetime BETWEEN @startDate AND @endDate
                ORDER BY v.appointment_datetime ASC, p.lname ASC";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var visit = new
                            {
                                VisitDate = reader.GetDateTime("VisitDate"),
                                PatientId = reader.GetInt32("PatientId"),
                                PatientName = reader.GetString("PatientName"),
                                DoctorId = reader.GetInt32("DoctorId"),
                                DoctorName = reader.GetString("DoctorName"),
                                NurseId = reader.GetInt32("NurseId"),
                                NurseName = reader.GetString("NurseName"),
                                InitialDiagnosis = reader.IsDBNull(reader.GetOrdinal("InitialDiagnosis")) ? "N/A" : reader.GetString("InitialDiagnosis"),
                                FinalDiagnosis = reader.IsDBNull(reader.GetOrdinal("FinalDiagnosis")) ? "N/A" : reader.GetString("FinalDiagnosis")
                            };

                            visits.Add(visit);
                        }
                    }
                }
            }

            return visits;
        }

    }
}
