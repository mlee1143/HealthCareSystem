using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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
                connection.Open();
                using (var command = new MySqlCommand("GetAllAppointments", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

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

            }

                return appointments;
        }

        public List<dynamic> getAllAppointmentsWithDetails()
        {
            List<dynamic> appointments = new List<dynamic>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("GetAppointments", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new
                            {
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.GetString("PatientName"),
                                DoctorID = reader.GetInt32("doctor_id"),
                                DoctorName = reader.GetString("DoctorName"),
                                AppointmentDateTime = reader.GetDateTime("appointment_datetime")
                            });
                        }
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

        public bool AppointmentExists(Appointment appointment)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM appointment WHERE patient_id = @patientId " +
                               "AND DATE_FORMAT(appointment_datetime, '%Y-%m-%d %H:%i') = DATE_FORMAT(@appointmentDateTime, '%Y-%m-%d %H:%i')";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", appointment.PatientID);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool DoctorAppointmentExists(int doctorId, DateTime appointmentDateTime, int? excludePatientId = null, DateTime? excludeDateTime = null)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM appointment WHERE doctor_id = @doctorId " +
                               "AND DATE_FORMAT(appointment_datetime, '%Y-%m-%d %H:%i') = DATE_FORMAT(@appointmentDateTime, '%Y-%m-%d %H:%i')";

                if (excludePatientId.HasValue && excludeDateTime.HasValue)
                {
                    query += " AND NOT (patient_id = @excludePatientId AND DATE_FORMAT(appointment_datetime, '%Y-%m-%d %H:%i') = DATE_FORMAT(@excludeDateTime, '%Y-%m-%d %H:%i'))";
                }

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);

                    if (excludePatientId.HasValue && excludeDateTime.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@excludePatientId", excludePatientId.Value);
                        cmd.Parameters.AddWithValue("@excludeDateTime", excludeDateTime.Value.ToString("yyyy-MM-dd HH:mm"));
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public Appointment GetAppointment(int patientId, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT * FROM appointment WHERE patient_id = @patientId AND appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Appointment(
                            reader.GetInt32("patient_id"),
                            reader.GetInt32("doctor_id"),
                            reader.GetDateTime("appointment_datetime"),
                            reader.GetString("reason")
                            );

                        }
                    }
                }
            }
            return null;
        }

        public bool UpdateAppointment(int originalPatientId, DateTime originalDateTime, Appointment appointment)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "UPDATE appointment SET patient_id = @newPatientId, doctor_id = @doctorId, " +
                               "appointment_datetime = @newDateTime, reason = @reason " +
                               "WHERE patient_id = @originalPatientId AND appointment_datetime = @originalDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@originalPatientId", originalPatientId);
                    cmd.Parameters.AddWithValue("@newPatientId", appointment.PatientID);
                    cmd.Parameters.AddWithValue("@doctorId", appointment.DoctorID);
                    cmd.Parameters.AddWithValue("@originalDateTime", originalDateTime);
                    cmd.Parameters.AddWithValue("@newDateTime", appointment.AppointmentDateTime);
                    cmd.Parameters.AddWithValue("@reason", appointment.Reason);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }




        public async Task<List<Appointment>> GetListOfAppointmentsByPatientBirthdate(DateTime birthdate)
        {
            List<Appointment> list = new List<Appointment>();
            var bdate = birthdate.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();
                
                string query = "SELECT a.patient_id, a.doctor_id, a.appointment_datetime, a.reason " +
                    "FROM appointment a " +
                    "JOIN patient p ON a.patient_id = p.patient_id " +
                    "WHERE p.bdate = @birthdate;";

                using (var command  = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@birthdate", bdate);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var appointment = new Appointment(
                                reader.GetInt32("patient_id"),
                                reader.GetInt32("doctor_id"),
                                reader.GetDateTime("appointment_datetime"),
                                reader.GetString("reason")
                                );

                            list.Add(appointment);
                        }
                    }
                }
            }
            return list;
        }

        public async Task<List<Appointment>> GetListOfAppointmentsByPatientName(string fname, string lname)
        {
            List<Appointment> list = new List<Appointment>();
            

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "SELECT a.patient_id, a.doctor_id, a.appointment_datetime, a.reason " +
                    "FROM appointment a " +
                    "JOIN patient p ON a.patient_id = p.patient_id " +
                    "WHERE p.fname = @fname AND p.lname = @lname;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var appointment = new Appointment(
                                reader.GetInt32("patient_id"),
                                reader.GetInt32("doctor_id"),
                                reader.GetDateTime("appointment_datetime"),
                                reader.GetString("reason")
                                );

                            list.Add(appointment);
                        }
                    }
                }
            }
            return list;
        }

        public async Task<List<Appointment>> GetListOfAppointmentsByPatientNameAndBirthdate(string fname, string lname, DateTime birthdate)
        {
            List<Appointment> list = new List<Appointment>();
            var bdate = birthdate.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = "SELECT a.patient_id, a.doctor_id, a.appointment_datetime, a.reason " +
                    "FROM appointment a " +
                    "JOIN patient p ON a.patient_id = p.patient_id " +
                    "WHERE p.fname = @fname AND p.lname = @lname AND p.bdate = @birthdate;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@birthdate", bdate);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var appointment = new Appointment(
                                reader.GetInt32("patient_id"),
                                reader.GetInt32("doctor_id"),
                                reader.GetDateTime("appointment_datetime"),
                                reader.GetString("reason")
                                );

                            list.Add(appointment);
                        }
                    }
                }
            }
            return list;
        }
    }
}

