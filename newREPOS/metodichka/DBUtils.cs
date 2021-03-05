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
            string host = "localhost";
            int port = 3306;
            string database = "met";
            string user = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
