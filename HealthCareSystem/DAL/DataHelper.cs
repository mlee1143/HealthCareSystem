using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace HealthCareSystem.DAL
{
    /// <summary>
    /// Provides helper methods for database operations in the Health Care System.
    /// </summary>
    public class DataHelper
    {
        /// <summary>
        /// Constructs and retrieves the connection string for connecting to the database.
        /// </summary>
        /// <returns>A connection string built from static connection details.</returns>
        public string GetConnectionString() 
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = Connection.Server,
                Port = Connection.Port,
                UserID = Connection.UserID,
                Password = Connection.Password,
                Database = Connection.Database
            };

            return builder.ConnectionString;
        }
    }
}
