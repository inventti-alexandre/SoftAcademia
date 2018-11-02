using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo3.App.DB.Base
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=blackfitdb;uid=root;password=1234;sslmode=none";
            //string connectionString = "server=104.214.59.125;database=blackfitdb;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
