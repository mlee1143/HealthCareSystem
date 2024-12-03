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
    /// <summary>
    /// Data Access Layer (DAL) for managing database operations related to appointments.
    /// Provides methods for fetching, inserting, updating, and validating appointment data.
    /// </summary>
    public class AppointmentDAL
    {
        private readonly DataHelper databaseConnection;

        /// <summary>
        /// Initializes a new instance of the AppointmentDAL class.
        /// Establishes a connection helper for database operations.
        /// </summary>
        public AppointmentDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Retrieves all appointments from the database.
        /// </summary>
        /// <returns>A list of Appointment objects containing basic appointment data.</returns>
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

        /// <summary>
        /// Retrieves all appointments with detailed information, including patient and doctor names.
        /// </summary>
        /// <returns>A list of dynamic objects containing detailed appointment data.</returns>
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

        /// <summary>
        /// Retrieves all appointments with detailed information, including patient and doctor names.
        /// </summary>
        /// <returns>A list of dynamic objects containing detailed appointment data.</returns>
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

        /// <summary>
        /// Checks if an appointment already exists in the database.
        /// </summary>
        /// <param name="appointment">The appointment object to check for existence.</param>
        /// <returns>True if the appointment exists; otherwise, false.</returns>
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

        /// <summary>
        /// Checks if a doctor already has an appointment at a specific date and time.
        /// Optionally excludes certain appointments from the check.
        /// </summary>
        /// <param name="doctorId">The ID of the doctor.</param>
        /// <param name="appointmentDateTime">The date and time of the appointment.</param>
        /// <param name="excludePatientId">Optional: The patient ID to exclude from the check.</param>
        /// <param name="excludeDateTime">Optional: The date and time to exclude from the check.</param>
        /// <returns>True if the doctor has a conflicting appointment; otherwise, false.</returns>
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

        /// <summary>
        /// Retrieves a specific appointment by patient ID and appointment date and time.
        /// </summary>
        /// <param name="patientId">The ID of the patient.</param>
        /// <param name="appointmentDateTime">The date and time of the appointment.</param>
        /// <returns>An Appointment object if the appointment exists; otherwise, null.</returns>
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

        /// <summary>
        /// Updates an existing appointment in the database.
        /// </summary>
        /// <param name="originalPatientId">The original patient ID of the appointment to update.</param>
        /// <param name="originalDateTime">The original date and time of the appointment to update.</param>
        /// <param name="appointment">The new appointment object containing updated data.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Asynchronously retrieves a list of appointments by the patient's birthdate.
        /// </summary>
        /// <param name="birthdate">The birthdate of the patient.</param>
        /// <returns>A task that resolves to a list of Appointment objects matching the birthdate.</returns>
        public async Task<List<Appointment>> GetListOfAppointmentsByPatientBirthdate(DateTime birthdate)
        {
            List<Appointment> list = new List<Appointment>();
            var bdate = birthdate.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();
                
                string query = " SELECT " +
                               "a.patient_id, " +
                               "CONCAT(p.fname, ' ', p.lname) AS PatientName, " +
                               "a.doctor_id, " +
                               "CONCAT(d.fname, ' ', d.lname) AS DoctorName, " +
                               "a.appointment_datetime, " +
                               "a.reason " +
                               "FROM " +
                               "appointment a " +
                               "JOIN " +
                               "patient p ON a.patient_id = p.patient_id " +
                               "JOIN " +
                               "doctor d ON a.doctor_id = d.doctor_id " +
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
                                )
                            {
                                PatientName = reader.GetString("PatientName"),
                                DoctorName = reader.GetString("DoctorName")
                            }
                                ;

                            list.Add(appointment);
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Asynchronously retrieves a list of appointments by the patient's first and last name.
        /// </summary>
        /// <param name="fname">The first name of the patient.</param>
        /// <param name="lname">The last name of the patient.</param>
        /// <returns>A task that resolves to a list of Appointment objects matching the patient's name.</returns>

        public async Task<List<Appointment>> GetListOfAppointmentsByPatientName(string fname, string lname)
        {
            List<Appointment> list = new List<Appointment>();
            

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = " SELECT " +
                              "a.patient_id, " +
                              "CONCAT(p.fname, ' ', p.lname) AS PatientName, " +
                              "a.doctor_id, " +
                              "CONCAT(d.fname, ' ', d.lname) AS DoctorName, " +
                              "a.appointment_datetime, " +
                              "a.reason " +
                              "FROM " +
                              "appointment a " +
                              "JOIN " +
                              "patient p ON a.patient_id = p.patient_id " +
                              "JOIN " +
                              "doctor d ON a.doctor_id = d.doctor_id " +
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
                                )
                            {
                                PatientName = reader.GetString("PatientName"),
                                DoctorName = reader.GetString("DoctorName")
                            };


                            list.Add(appointment);
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Asynchronously retrieves a list of appointments by the patient's name and birthdate.
        /// </summary>
        /// <param name="fname">The first name of the patient.</param>
        /// <param name="lname">The last name of the patient.</param>
        /// <param name="birthdate">The birthdate of the patient.</param>
        /// <returns>A task that resolves to a list of Appointment objects matching the name and birthdate.</returns>
        public async Task<List<Appointment>> GetListOfAppointmentsByPatientNameAndBirthdate(string fname, string lname, DateTime birthdate)
        {
            List<Appointment> list = new List<Appointment>();
            var bdate = birthdate.ToString("yyyy-MM-dd");

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                await connection.OpenAsync();

                string query = " SELECT " +
                               "a.patient_id, " +
                               "CONCAT(p.fname, ' ', p.lname) AS PatientName, " +
                               "a.doctor_id, " +
                               "CONCAT(d.fname, ' ', d.lname) AS DoctorName, " +
                               "a.appointment_datetime, " +
                               "a.reason " +
                               "FROM " +
                               "appointment a " +
                               "JOIN " +
                               "patient p ON a.patient_id = p.patient_id " +
                               "JOIN " +
                               "doctor d ON a.doctor_id = d.doctor_id " +
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
                                )
                            {
                                PatientName = reader.GetString("PatientName"),
                                DoctorName = reader.GetString("DoctorName")
                            };

                            list.Add(appointment);
                        }
                    }
                }
            }
            return list;
        }
    }
}

