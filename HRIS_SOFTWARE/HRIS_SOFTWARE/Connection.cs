using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRIS_SOFTWARE
{
    static class Connection
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public const String SERVER = "127.0.0.1";
        public const String DATABASE = "payroll_system";
        public const String UID = "root";
        public const String PASSWORD = "admin";
        public static MySqlConnection dbConn;

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String ConnString = builder.ToString();

            builder = null;

            Console.WriteLine(ConnString);

            dbConn = new MySqlConnection(ConnString);

        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
