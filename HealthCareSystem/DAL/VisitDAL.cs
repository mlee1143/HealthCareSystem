using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
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

        public bool InsertVisitInformation(Visit visit)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "INSERT INTO visit (patient_id, doctor_id, appointment_datetime, nurse_id, weight, height, blood_pressure, pulse, temperature, symptomsDescription, initial_diagnosis) " +
                               "VALUES (@patientId, @doctorId, @appointmentDateTime, @nurse_id, @weight, @height, @blood_pressure, @pulse, @temperature, @symptomsDescription, @initial_diagnosis)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", visit.Appointment.PatientID);
                    cmd.Parameters.AddWithValue("@doctorId", visit.Appointment.DoctorID);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", visit.Appointment.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"));
                    cmd.Parameters.AddWithValue("@nurse_id", visit.Nurse.NurseId);
                    cmd.Parameters.AddWithValue("@weight", visit.Weight);
                    cmd.Parameters.AddWithValue("@height", visit.Height);
                    cmd.Parameters.AddWithValue("@blood_pressure", visit.BloodPressure);
                    cmd.Parameters.AddWithValue("@pulse", visit.Pulse);
                    cmd.Parameters.AddWithValue("@temperature", visit.Temperature);
                    cmd.Parameters.AddWithValue("@symptomsDescription", visit.SymptomsDescription);
                    cmd.Parameters.AddWithValue("@initial_diagnosis", visit.InitialDiagnosis);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public List<dynamic> GetAllVisitsWithDetails()
        {
            List<dynamic> visits = new List<dynamic>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT 
                v.patient_id, 
                CONCAT(p.fname, ' ', p.lname) AS PatientName, 
                v.doctor_id, 
                CONCAT(d.fname, ' ', d.lname) AS DoctorName, 
                v.appointment_datetime, 
                v.symptomsDescription
            FROM 
                visit v
            JOIN 
                patient p ON v.patient_id = p.patient_id
            JOIN 
                doctor d ON v.doctor_id = d.doctor_id";

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
                                AppointmentDateTime = reader.GetDateTime("appointment_datetime"),
                                SymptomsDescription = reader.GetString("symptomsDescription")
                            });
                        }
                    }
                }
            }

            return visits;
        }
    }
}
