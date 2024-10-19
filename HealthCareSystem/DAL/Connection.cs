using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public static class Connection
    {
        public static readonly string ConnectionString = "server= ; port=3306; " + "uid=cs3230f24d; pwd= ; database=cs3230f24d";

        public static readonly string Server = "";
        public static readonly string UserID = "cs3230f24d";
        public static readonly string Database = "cs3230f24d";
        public static readonly string Password = "";
        public static readonly uint Port = 3306;
    }
}
