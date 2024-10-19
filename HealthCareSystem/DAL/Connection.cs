using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public static class Connection
    {
        public static readonly string ConnectionString = "server=cs-dblab01.uwg.westga.edu ; port=3306; " + "uid=cs3230f24d; pwd=-6BT.nr2k))@Y*oVYlao ; database=cs3230f24d";

        public static readonly string Server = "cs-dblab01.uwg.westga.edu";
        public static readonly string UserID = "cs3230f24d";
        public static readonly string Database = "cs3230f24d";
        public static readonly string Password = "-6BT.nr2k))@Y*oVYlao";
        public static readonly uint Port = 3306;
    }
}
