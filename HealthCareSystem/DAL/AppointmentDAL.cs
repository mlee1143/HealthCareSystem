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
    }
}
