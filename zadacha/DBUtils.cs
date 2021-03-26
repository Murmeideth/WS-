using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace metodichka
{
    class DBUtils
    {
        public static MySqlConnection GetDbConnection()
        {
            string host = "192.168.70.5";
            int port = 3306;
            string database = "blogtest";
            string user = "appuser";
            string password = "pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
