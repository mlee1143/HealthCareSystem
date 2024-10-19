using HealthCareSystem.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class NurseDAL
    {

        public async Task<Nurse> GetNurseAsync(string username)
        {
            var dbConnection = new DataHelper();
            using (var connection = new MySqlConnection(dbConnection.GetConnectionString()))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM nurse WHERE username = @username";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Nurse( // Check why there is a warning
                                reader["first_name"].ToString(),
                                reader["last_name"].ToString(),
                                reader["username"].ToString(),
                                reader["password"].ToString()
                            )
                            {
                                NurseId = Convert.ToInt32(reader["employee_id"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
