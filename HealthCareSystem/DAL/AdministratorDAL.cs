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
