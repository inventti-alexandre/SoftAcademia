﻿using MySql.Data.MySqlClient;
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
            //Base de dados Local
            string connectionString = "server=localhost;database=blackfitdb;uid=root;password=1234;sslmode=none";

            //Base de dados FREI
            //string connectionString = "server=192.168.0.100;database=blackfitdb;uid=nsf;password=nsf@2018;sslmode=none";

            //Base de dados Azure
            //string connectionString = "server=70.37.57.127;database=blackfitdb;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
