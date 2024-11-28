using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class LabTestDAL
    {
        private readonly DataHelper databaseConnection;

        public LabTestDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        public List<TestType> GetAllTestTypes()
        {
            List<TestType> testTypes = new List<TestType>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT test_code, test_name, low, high, unit_measurement FROM test_type";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int testCode = reader.GetInt32("test_code");
                            string testName = reader.GetString("test_name");
                            decimal? lowValue = reader.IsDBNull(reader.GetOrdinal("low")) ? null : reader.GetDecimal("low");
                            decimal? highValue = reader.IsDBNull(reader.GetOrdinal("high")) ? null : reader.GetDecimal("high");
                            string unitMeasurement = reader.GetString("unit_measurement");

                            testTypes.Add(new TestType(testCode, testName, lowValue, highValue, unitMeasurement));
                        }
                    }
                }
            }

            return testTypes;
        }

        public bool InsertLabTests(List<int> testCodes, int patientId, int nurseId, int doctorId, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var testCode in testCodes)
                        {
                            string query = @"INSERT INTO lab_test (test_code, patient_id, nurse_id, doctor_id, appointment_datetime, test_datetime, abnormal, result)
                            VALUES (@testCode, @patientId, @nurseId, @doctorId, @appointmentDateTime, NULL, NULL, NULL)";

                            using (var cmd = new MySqlCommand(query, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@testCode", testCode);
                                cmd.Parameters.AddWithValue("@patientId", patientId);
                                cmd.Parameters.AddWithValue("@nurseId", nurseId);
                                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                                cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public bool IsTestAlreadyOrderedForPatient(int testCode, int patientId, DateTime appointmentDateTime)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT COUNT(*)
                FROM lab_test
                WHERE test_code = @testCode AND patient_id = @patientId AND appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@testCode", testCode);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        public List<(LabTest, TestType)> GetAllLabTestsForAppointment(int patientId, DateTime appointmentDateTime)
        {
            var labTests = new List<(LabTest, TestType)>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT lt.test_code, tt.test_name, lt.patient_id, lt.nurse_id, lt.doctor_id, lt.appointment_datetime, 
                lt.test_datetime, lt.abnormal, lt.result, tt.low, tt.high, tt.unit_measurement
                FROM lab_test lt JOIN test_type tt ON lt.test_code = tt.test_code
                WHERE lt.patient_id = @patientId AND lt.appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var labTest = new LabTest(
                                reader.GetInt32("test_code"),
                                reader.GetInt32("patient_id"),
                                reader.GetInt32("doctor_id"),
                                reader.GetInt32("nurse_id"),
                                reader.GetDateTime("appointment_datetime"),
                                reader.IsDBNull(reader.GetOrdinal("test_datetime")) ? null : reader.GetDateTime("test_datetime"),
                                reader.IsDBNull(reader.GetOrdinal("abnormal")) ? null : reader.GetBoolean("abnormal"),
                                reader.IsDBNull(reader.GetOrdinal("result")) ? null : reader.GetString("result")
                            );

                            var testType = new TestType(
                                reader.GetInt32("test_code"),
                                reader.GetString("test_name"),
                                reader.IsDBNull(reader.GetOrdinal("low")) ? 0 : reader.GetDecimal("low"),
                                reader.IsDBNull(reader.GetOrdinal("high")) ? 0 : reader.GetDecimal("high"),
                                reader.GetString("unit_measurement")
                            );

                            labTests.Add((labTest, testType));
                        }
                    }
                }
            }

            return labTests;
        }

        public bool SaveTestResult(LabTest labTest)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string queryGetLowHigh = "SELECT low, high FROM test_type WHERE test_code = @testCode";

                decimal? low = null;
                decimal? high = null;

                using (var cmd = new MySqlCommand(queryGetLowHigh, connection))
                {
                    cmd.Parameters.AddWithValue("@testCode", labTest.TestCode);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            low = reader.IsDBNull(reader.GetOrdinal("low")) ? null : reader.GetDecimal("low");
                            high = reader.IsDBNull(reader.GetOrdinal("high")) ? null : reader.GetDecimal("high");
                        }
                    }
                }

                if (low.HasValue && high.HasValue && labTest.Result != null)
                {
                    decimal resultValue = Convert.ToDecimal(labTest.Result);
                    labTest.IsAbnormal = resultValue < low.Value || resultValue > high.Value;
                }

                string querySave = @"UPDATE lab_test 
                SET test_datetime = @testDateTime, 
                abnormal = @abnormal, 
                result = @result 
                WHERE test_code = @testCode AND patient_id = @patientId AND appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(querySave, connection))
                {
                    cmd.Parameters.AddWithValue("@testDateTime", labTest.TestDateTime);
                    cmd.Parameters.AddWithValue("@abnormal", labTest.IsAbnormal);
                    cmd.Parameters.AddWithValue("@result", labTest.Result);
                    cmd.Parameters.AddWithValue("@testCode", labTest.TestCode);
                    cmd.Parameters.AddWithValue("@patientId", labTest.PatientID);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", labTest.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
