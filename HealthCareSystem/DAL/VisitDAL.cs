using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    /// <summary>
    /// Data Access Layer (DAL) for performing database operations related to the visits.
    /// Provides methods to retrieve data from vists and update visit.
    /// </summary>
    public class VisitDAL
    {
        /// <summary>
        /// Initializes a new instance of the VisitDAL class.
        /// Establishes a connection helper for database operations.
        /// </summary>
        private readonly DataHelper databaseConnection;

        public VisitDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Gets the visit by patient identifier and appointment date time.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <returns></returns>
        public Visit GetVisitByPatientIDAndAppointmentDateTime(Appointment app)
        {
            int id = app.PatientID;
            DateTime appointmentDateTime = app.AppointmentDateTime;

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT * FROM visit WHERE patient_id = @id AND appointment_datetime = @appointmentDateTime;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int patientId = reader.GetInt32("patient_id");
                            int doctorID = reader.GetInt32("doctor_id");
                            DateTime date = reader.GetDateTime("appointment_datetime");

                            Appointment appointment = new Appointment(patientId, doctorID, date, app.Reason);

                            return new Visit(
                                appointment,
                                reader.GetDouble("weight"),
                                reader.GetDouble("height"),
                                reader.GetString("blood_pressure"),
                                reader.GetString("symptomsDescription"))
                            {
                                InitialDiagnosis = reader["initial_diagnosis"].ToString(),
                                FinalDiagnosis = reader["final_diagnosis"].ToString(),
                                Pulse = Convert.ToInt32(reader["pulse"]),
                                Temperature = Convert.ToDouble(reader["temperature"]),
                                NurseID = Convert.ToInt32(reader["nurse_id"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Inserts the visit information.
        /// </summary>
        /// <param name="visit">The visit.</param>
        /// <returns></returns>
        public bool InsertVisitInformation(Visit visit)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "INSERT INTO visit (patient_id, doctor_id, appointment_datetime, nurse_id, weight, height, blood_pressure, pulse, temperature, symptomsDescription) " +
                               "VALUES (@patientId, @doctorId, @appointmentDateTime, @nurse_id, @weight, @height, @blood_pressure, @pulse, @temperature, @symptomsDescription)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", visit.Appointment.PatientID);
                    cmd.Parameters.AddWithValue("@doctorId", visit.Appointment.DoctorID);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", visit.Appointment.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"));
                    cmd.Parameters.AddWithValue("@nurse_id", visit.NurseID);
                    cmd.Parameters.AddWithValue("@weight", visit.Weight);
                    cmd.Parameters.AddWithValue("@height", visit.Height);
                    cmd.Parameters.AddWithValue("@blood_pressure", visit.BloodPressure);
                    cmd.Parameters.AddWithValue("@pulse", visit.Pulse);
                    cmd.Parameters.AddWithValue("@temperature", visit.Temperature);
                    cmd.Parameters.AddWithValue("@symptomsDescription", visit.SymptomsDescription);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        /// <summary>
        /// Updates the visit information check up.
        /// </summary>
        /// <param name="patientID">The patient identifier.</param>
        /// <param name="appointmentDateTime">The appointment date time.</param>
        /// <param name="visit">The visit.</param>
        /// <returns></returns>
        public bool UpdateVisitInformationCheckUp(int patientID, DateTime appointmentDateTime, Visit visit)
        {

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "UPDATE visit SET height = @height, weight = @weight, temperature = @temperature, blood_pressure = @blood_pressure, pulse = @pulse, symptomsDescription = @symptoms WHERE patient_id = @patient_id AND appointment_datetime = @appointment_datetime;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patientID);
                    command.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);

                    command.Parameters.AddWithValue("@weight", visit.Weight);
                    command.Parameters.AddWithValue("@height", visit.Height);
                    command.Parameters.AddWithValue("@blood_pressure", visit.BloodPressure);
                    command.Parameters.AddWithValue("@pulse", visit.Pulse);
                    command.Parameters.AddWithValue("@temperature", visit.Temperature);
                    command.Parameters.AddWithValue("@symptoms", visit.SymptomsDescription);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Visits the information exists already.
        /// </summary>
        /// <param name="patientID">The patient identifier.</param>
        /// <param name="appointmentDateTime">The appointment date time.</param>
        /// <returns></returns>
        public bool VisitInformationExistsAlready(int patientID, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM visit WHERE patient_id = @patient_id AND appointment_datetime = @appointment_datetime;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patientID);
                    command.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Initials the diagnosis exists for visit.
        /// </summary>
        /// <param name="patientID">The patient identifier.</param>
        /// <param name="appointmentDateTime">The appointment date time.</param>
        /// <returns></returns>
        public bool InitialDiagnosisExistsForVisit(int patientID, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) AS init_diagnosis_exists FROM visit WHERE patient_id = @patient_id AND appointment_datetime = @appointment_datetime AND initial_diagnosis IS NOT NULL AND initial_diagnosis <> '';";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patientID);
                    command.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Finals the diagnosis exists for visit.
        /// </summary>
        /// <param name="patientID">The patient identifier.</param>
        /// <param name="appointmentDateTime">The appointment date time.</param>
        /// <returns></returns>
        public bool FinalDiagnosisExistsForVisit(int patientID, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) AS final_diagnosis_exists FROM visit WHERE patient_id = @patient_id AND appointment_datetime = @appointment_datetime AND final_diagnosis IS NOT NULL AND final_diagnosis <> '';";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patientID);
                    command.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Updates the initial diagnosis for visit.
        /// </summary>
        /// <param name="diagnosis">The diagnosis.</param>
        /// <param name="patientID">The patient identifier.</param>
        /// <param name="appointmentDateTime">The appointment date time.</param>
        /// <returns></returns>
        public bool UpdateInitialDiagnosisForVisit(string diagnosis, int patientID, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "UPDATE visit SET initial_diagnosis = @initial_diagnosis WHERE patient_id = @patient_id AND appointment_datetime = @appointment_datetime;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patientID);
                    command.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);
                    command.Parameters.AddWithValue("@initial_diagnosis", diagnosis);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Updates the final diagnosis for visit.
        /// </summary>
        /// <param name="diagnosis">The diagnosis.</param>
        /// <param name="patientID">The patient identifier.</param>
        /// <param name="appointmentDateTime">The appointment date time.</param>
        /// <returns></returns>
        public bool UpdateFinalDiagnosisForVisit(string diagnosis, int patientID, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "UPDATE visit SET final_diagnosis = @final_diagnosis WHERE patient_id = @patient_id AND appointment_datetime = @appointment_datetime;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patientID);
                    command.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);
                    command.Parameters.AddWithValue("@final_diagnosis", diagnosis);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Gets all visits with details.
        /// </summary>
        /// <returns></returns>
        public List<dynamic> GetAllVisitsWithDetails()
        {
            List<dynamic> visits = new List<dynamic>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT v.patient_id, 
                CONCAT(p.fname, ' ', p.lname) AS PatientName, 
                v.doctor_id, 
                CONCAT(d.fname, ' ', d.lname) AS DoctorName, 
                v.nurse_id,
                CONCAT(n.fname, ' ', n.lname) AS NurseName,
                v.appointment_datetime
            FROM visit v
            JOIN patient p ON v.patient_id = p.patient_id
            JOIN doctor d ON v.doctor_id = d.doctor_id
            JOIN nurse n ON v.nurse_id = n.nurse_id";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visits.Add(new
                            {
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.GetString("PatientName"),
                                DoctorID = reader.GetInt32("doctor_id"),
                                DoctorName = reader.GetString("DoctorName"),
                                NurseID = reader.GetInt32("nurse_id"),
                                NurseName = reader.GetString("NurseName"),
                                AppointmentDateTime = reader.GetDateTime("appointment_datetime")
                            });
                        }
                    }
                }
            }
            return visits;
        }

        /// <summary>
        /// Gets the name of the visits with details by patient.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <returns></returns>
        public List<dynamic> GetVisitsWithDetailsByPatientName(string fname, string lname)
        {
            List<dynamic> visits = new List<dynamic>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT v.patient_id, 
                CONCAT(p.fname, ' ', p.lname) AS PatientName, 
                v.doctor_id, 
                CONCAT(d.fname, ' ', d.lname) AS DoctorName, 
                v.nurse_id,
                CONCAT(n.fname, ' ', n.lname) AS NurseName,
                v.appointment_datetime
            FROM visit v
            JOIN patient p ON v.patient_id = p.patient_id
            JOIN doctor d ON v.doctor_id = d.doctor_id
            JOIN nurse n ON v.nurse_id = n.nurse_id
            WHERE p.fname = @fname AND p.lname = @lname";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visits.Add(new
                            {
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.GetString("PatientName"),
                                DoctorID = reader.GetInt32("doctor_id"),
                                DoctorName = reader.GetString("DoctorName"),
                                NurseID = reader.GetInt32("nurse_id"),
                                NurseName = reader.GetString("NurseName"),
                                AppointmentDateTime = reader.GetDateTime("appointment_datetime")
                            });
                        }
                    }
                }
            }
            return visits;
        }


        /// <summary>
        /// Gets the visits with details by patient birthdate.
        /// </summary>
        /// <param name="birthdate">The birthdate.</param>
        /// <returns></returns>
        public List<dynamic> GetVisitsWithDetailsByPatientBirthdate(DateTime birthdate)
        {
            List<dynamic> visits = new List<dynamic>();

            var bdate = birthdate.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT v.patient_id, 
                CONCAT(p.fname, ' ', p.lname) AS PatientName, 
                v.doctor_id, 
                CONCAT(d.fname, ' ', d.lname) AS DoctorName, 
                v.nurse_id,
                CONCAT(n.fname, ' ', n.lname) AS NurseName,
                v.appointment_datetime
            FROM visit v
            JOIN patient p ON v.patient_id = p.patient_id
            JOIN doctor d ON v.doctor_id = d.doctor_id
            JOIN nurse n ON v.nurse_id = n.nurse_id
            WHERE p.bdate = @bdate;";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@bdate", bdate);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visits.Add(new
                            {
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.GetString("PatientName"),
                                DoctorID = reader.GetInt32("doctor_id"),
                                DoctorName = reader.GetString("DoctorName"),
                                NurseID = reader.GetInt32("nurse_id"),
                                NurseName = reader.GetString("NurseName"),
                                AppointmentDateTime = reader.GetDateTime("appointment_datetime")
                            });
                        }
                    }
                }
            }
            return visits;
        }

        /// <summary>
        /// Gets the visits with details by patient name and birthdate.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="birthdate">The birthdate.</param>
        /// <returns></returns>
        public List<dynamic> GetVisitsWithDetailsByPatientNameAndBirthdate(string fname, string lname,DateTime birthdate)
        {
            List<dynamic> visits = new List<dynamic>();

            var bdate = birthdate.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT v.patient_id, 
                CONCAT(p.fname, ' ', p.lname) AS PatientName, 
                v.doctor_id, 
                CONCAT(d.fname, ' ', d.lname) AS DoctorName, 
                v.nurse_id,
                CONCAT(n.fname, ' ', n.lname) AS NurseName,
                v.appointment_datetime
            FROM visit v
            JOIN patient p ON v.patient_id = p.patient_id
            JOIN doctor d ON v.doctor_id = d.doctor_id
            JOIN nurse n ON v.nurse_id = n.nurse_id
            WHERE p.fname = @fname AND p.lname = @lname AND p.bdate = @bdate;";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@bdate", bdate);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visits.Add(new
                            {
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.GetString("PatientName"),
                                DoctorID = reader.GetInt32("doctor_id"),
                                DoctorName = reader.GetString("DoctorName"),
                                NurseID = reader.GetInt32("nurse_id"),
                                NurseName = reader.GetString("NurseName"),
                                AppointmentDateTime = reader.GetDateTime("appointment_datetime")
                            });
                        }
                    }
                }
            }
            return visits;
        }

    }

}
