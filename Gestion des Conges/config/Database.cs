using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion_des_Conges.config
{
    class Database
    {

        private const string DB_NAME = "gestion_des_conges";
        private const string SERVER_NAME = "localhost\\sqlexpress";

        private static string conString = 
            "Data Source="+ SERVER_NAME + 
            ";Initial Catalog="+ DB_NAME +
            ";Integrated Security=True";

        private static SqlConnection connection;

        public static SqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(conString);
            }
            return connection;
        }
    }
}
