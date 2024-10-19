using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace HealthCareSystem.DAL
{
    public class DataHelper
    {
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
