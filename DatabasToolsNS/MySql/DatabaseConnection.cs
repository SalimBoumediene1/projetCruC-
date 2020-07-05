using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseToolsNS.MariaDb
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _Instance;
        private MySqlConnection con;

        public MySqlConnection SqlConnection { get => con; set => con = value; }

        public static DatabaseConnection GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new DatabaseConnection();
            }
            return _Instance;
        }

        public DatabaseConnection()
        {
            con = new MySqlConnection();

        }
    }
}
