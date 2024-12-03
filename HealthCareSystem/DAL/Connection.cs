using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    /// <summary>
    /// Provides static database connection details for the Health Care System application.
    /// </summary>
    public static class Connection
    {
        /// <summary>
        /// Gets the full connection string for connecting to the database.
        /// </summary>
        public static readonly string ConnectionString = "server=cs-dblab01.uwg.westga.edu ; port=3306; " + "uid=cs3230f24d; pwd=-6BT.nr2k))@Y*oVYlao ; database=cs3230f24d";

        /// <summary>
        /// Gets the server address for the database.
        /// </summary>
        public static readonly string Server = "cs-dblab01.uwg.westga.edu";

        /// <summary>
        /// Gets the user ID for database authentication.
        /// </summary>
        public static readonly string UserID = "cs3230f24d";

        /// <summary>
        /// Gets the name of the database to connect to.
        /// </summary>
        public static readonly string Database = "cs3230f24d";

        /// <summary>
        /// Gets the password for database authentication.
        /// </summary>
        public static readonly string Password = "-6BT.nr2k))@Y*oVYlao";

        /// <summary>
        /// Gets the port number for connecting to the database.
        /// </summary>
        public static readonly uint Port = 3306;
    }
}
