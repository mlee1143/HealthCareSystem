using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class AppointmentDAL
    {
        private readonly DataHelper databaseConnection;

        public AppointmentDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        public List<Appointment> getAllAppointments() 
        {
            List<Appointment> appointments = new List<Appointment>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                string query = "SELECT patient_id, doctor_id, appointment_datetime, reason FROM appointment";
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appointments.Add(new Appointment(
                            reader.GetInt32("patient_id"),
                            reader.GetInt32("doctor_id"),
                            reader.GetDateTime("appointment_datetime"),
                            reader.GetString("reason")
                            ));
                    }
                }

            }

                return appointments;
        }

        public bool InsertAppointment(Appointment appointment)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "INSERT INTO appointment (patient_id, doctor_id, appointment_datetime, reason) " +
                               "VALUES (@patientId, @doctorId, @appointmentDateTime, @reason)";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", appointment.PatientID);
                    cmd.Parameters.AddWithValue("@doctorId", appointment.DoctorID);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"));
                    cmd.Parameters.AddWithValue("@reason", appointment.Reason);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool AppointmentExists(int patientId, int doctorId, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM appointment WHERE patient_id = @patientId " +
                               "AND doctor_id = @doctorId " +
                               "AND DATE_FORMAT(appointment_datetime, '%Y-%m-%d %H:%i') = DATE_FORMAT(@appointmentDateTime, '%Y-%m-%d %H:%i')";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm"));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
