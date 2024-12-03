using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    /// <summary>
    /// Data Access Layer (DAL) for performing database operations related to lab tests.
    /// Provides methods for retrieving, inserting, updating, and validating lab tests.
    /// </summary>
    public class LabTestDAL
    {

        private readonly DataHelper databaseConnection;

        /// <summary>
        /// Initializes a new instance of the LabTestDAL class.
        /// Establishes a connection helper for database operations.
        /// </summary>
        public LabTestDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        /// <summary>
        /// Retrieves all test types from the database.
        /// </summary>
        /// <returns>A list of TestType objects containing information about each test type.</returns>
        public List<TestType> GetAllTestTypes()
        {
            List<TestType> testTypes = new List<TestType>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("GetTestTypes", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        /// <summary>
        /// Inserts multiple lab tests for a specific appointment into the database.
        /// </summary>
        /// <param name="testCodes">A list of test codes to be inserted.</param>
        /// <param name="patientId">The ID of the patient associated with the tests.</param>
        /// <param name="nurseId">The ID of the nurse who assisted with the tests.</param>
        /// <param name="doctorId">The ID of the doctor who ordered the tests.</param>
        /// <param name="appointmentDateTime">The date and time of the associated appointment.</param>
        /// <returns>True if the insertion was successful; otherwise, false.</returns>
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

        /// <summary>
        /// Checks if a specific lab test has already been ordered for a patient.
        /// </summary>
        /// <param name="testCode">The code of the test to check.</param>
        /// <param name="patientId">The ID of the patient.</param>
        /// <param name="appointmentDateTime">The date and time of the associated appointment.</param>
        /// <returns>True if the test has already been ordered; otherwise, false.</returns>
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

        /// <summary>
        /// Retrieves all lab tests and their associated test types for a specific visit.
        /// </summary>
        /// <param name="patientId">The ID of the patient associated with the visit.</param>
        /// <param name="appointmentDateTime">The date and time of the associated appointment.</param>
        /// <returns>A list of tuples, each containing a LabTest object and a TestType object.</returns>
        public List<(LabTest, TestType)> GetAllLabTestsForVisit(int patientId, DateTime appointmentDateTime)
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

        /// <summary>
        /// Updates the result of a specific lab test in the database.
        /// </summary>
        /// <param name="testCode">The code of the test to update.</param>
        /// <param name="patientId">The ID of the patient associated with the test.</param>
        /// <param name="nurseId">The ID of the nurse who assisted with the test.</param>
        /// <param name="doctorId">The ID of the doctor who ordered the test.</param>
        /// <param name="appointmentDateTime">The date and time of the associated appointment.</param>
        /// <param name="testDateTime">The date and time when the test was conducted.</param>
        /// <param name="isAbnormal">Indicates whether the test result is abnormal. This value can be null.</param>
        /// <param name="result">The result of the test.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public bool UpdateLabTestResult(int testCode, int patientId, int nurseId, int doctorId, DateTime appointmentDateTime, DateTime testDateTime, bool? isAbnormal, decimal result)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"UPDATE lab_test
                SET test_datetime = @testDateTime, 
                abnormal = @isAbnormal,
                result = @result
                WHERE test_code = @testCode AND 
                patient_id = @patientId AND
                nurse_id = @nurseId AND
                doctor_id = @doctorId AND
                appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@testDateTime", testDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@isAbnormal", isAbnormal.HasValue ? (object)isAbnormal.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@result", result);
                    cmd.Parameters.AddWithValue("@testCode", testCode);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@nurseId", nurseId);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
