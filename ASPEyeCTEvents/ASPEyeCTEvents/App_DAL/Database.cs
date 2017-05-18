﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.App_DAL
{
    public class Database
    {
        private static readonly string connectionString = "Data Source=proftaakserver.database.windows.net;Initial Catalog=Proftaakdb;Integrated Security=False;User ID=Admininistrator;Password=Hosting123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    connection.Close();
                }
                return connection;
            }
        }
    }
}