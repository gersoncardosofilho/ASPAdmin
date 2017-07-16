using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASPAdmin.Connection
{
    public class Connection
    {
        public static SqlConnection conn()
        {
            string cs = ConfigurationManager.ConnectionStrings["ASAPAdminConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }
    }
}