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

        public List<string> GetAllTestTypes()
        {
            List<string> testTypes = new List<string>();

            using (var connection = new MySqlConnection(databaseConnection.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT test_name FROM test_type";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            testTypes.Add(reader.GetString("test_name"));
                        }
                    }
                }
            }

            return testTypes;
        }

    }
}
