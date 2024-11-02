using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
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
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime);
                    cmd.Parameters.AddWithValue("@reason", appointment.Reason);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
