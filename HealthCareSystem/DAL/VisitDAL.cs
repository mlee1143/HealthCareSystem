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
    public class VisitDAL
    {
        private readonly DataHelper databaseConnection;

        public VisitDAL()
        {
            this.databaseConnection = new DataHelper();
        }

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

        public bool InsertVisitInformation(Visit visit)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "INSERT INTO visit (patient_id, doctor_id, appointment_datetime, nurse_id, weight, height, blood_pressure, pulse, temperature, symptomsDescription) " + //, initial_diagnosis
                               "VALUES (@patientId, @doctorId, @appointmentDateTime, @nurse_id, @weight, @height, @blood_pressure, @pulse, @temperature, @symptomsDescription)"; //, @initial_diagnosis

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
    }
}
