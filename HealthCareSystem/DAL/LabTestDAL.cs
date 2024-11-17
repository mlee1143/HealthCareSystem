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
    }
}
