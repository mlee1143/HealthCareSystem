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

                string query = "SELECT test_code, test_name FROM test_type";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int testCode = reader.GetInt32("test_code");
                            string testName = reader.GetString("test_name");

                            testTypes.Add(new TestType(testCode, testName));
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

                // Transaction here to ensure all inserts succeed or fail as a group
                // Well implemented?
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var testCode in testCodes)
                        {
                            string query = @"
                        INSERT INTO lab_test 
                        (test_code, patient_id, nurse_id, doctor_id, appointment_datetime, low, high, unit_measurement, test_datetime, abnormal, result)
                        VALUES 
                        (@testCode, @patientId, @nurseId, @doctorId, @appointmentDateTime, NULL, NULL, '', NULL, NULL, NULL)";

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

        public bool IsTestAlreadyOrderedForPatient(int testCode, int patientId)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT COUNT(*) 
            FROM lab_test 
            WHERE test_code = @testCode AND patient_id = @patientId";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@testCode", testCode);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public List<LabTest> GetLabTestsForVisit(int patientId, int doctorId, int nurseId, DateTime appointmentDateTime)
        {
            List<LabTest> labTests = new List<LabTest>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT lt.test_code, tt.test_name, lt.nurse_id, lt.appointment_datetime, lt.low, lt.high, lt.unit_measurement, lt.test_datetime, lt.abnormal, lt.result 
            FROM lab_test lt
            JOIN test_type tt ON lt.test_code = tt.test_code
            WHERE lt.patient_id = @patientId 
              AND lt.doctor_id = @doctorId 
              AND lt.nurse_id = @nurseId 
              AND lt.appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@nurseId", nurseId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTest labTest = new LabTest(
                                testCode: reader.GetInt32("test_code"),
                                patientId: patientId,
                                doctorId: doctorId,
                                nurseId: nurseId,
                                appointmentDateTime: appointmentDateTime,
                                low: reader["low"] != DBNull.Value ? Convert.ToDecimal(reader["low"]) : (decimal?)null,
                                high: reader["high"] != DBNull.Value ? Convert.ToDecimal(reader["high"]) : (decimal?)null,
                                unitMeasurement: reader["unit_measurement"] != DBNull.Value ? reader["unit_measurement"].ToString() : null,
                                testDateTime: reader["test_datetime"] != DBNull.Value ? Convert.ToDateTime(reader["test_datetime"]) : (DateTime?)null,
                                isAbnormal: reader["abnormal"] != DBNull.Value ? Convert.ToBoolean(reader["abnormal"]) : (bool?)null,
                                result: reader["result"] != DBNull.Value ? reader["result"].ToString() : null
                            )
                            {
                                TestName = reader["test_name"].ToString()
                            };

                            labTests.Add(labTest);
                        }
                    }
                }
            }

            return labTests;
        }

        public bool UpdateLabTestResult(int testCode, int patientId, int nurseId, int doctorId, DateTime appointmentDateTime, decimal? low, decimal? high, string unitMeasurement, DateTime testDateTime, bool? isAbnormal, string result)
        {
            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = @"
            UPDATE lab_test
            SET 
                low = @low,
                high = @high,
                unit_measurement = @unitMeasurement,
                test_datetime = @testDateTime,
                abnormal = @isAbnormal,
                result = @result
            WHERE 
                test_code = @testCode AND 
                patient_id = @patientId AND
                nurse_id = @nurseId AND
                doctor_id = @doctorId AND
                appointment_datetime = @appointmentDateTime";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@low", low.HasValue ? (object)low.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@high", high.HasValue ? (object)high.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@unitMeasurement", unitMeasurement);
                    cmd.Parameters.AddWithValue("@testDateTime", testDateTime);
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
