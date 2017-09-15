using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindbgTest.Utils
{
    public class Common
    {
        public static IDbConnection OpenConnection()
        {
            //IDbConnection connection = new SqlConnection("Data Source=139.198.13.12,4124;Initial Catalog=WinDbgDB;Persist Security Info=True;User ID=dbg;Password=dbg123456");            
            //IDbConnection connection = new SqlConnection("Data Source=10.10.26.12,11;Initial Catalog=WinDbgDB;Persist Security Info=True;User ID=dbg;Password=dbg123456");            
            IDbConnection connection = new SqlConnection("Data Source=1.1.2.180;Initial Catalog=DemoDB;Persist Security Info=True;User ID=dbg;Password=dbg123456");
            connection.Open();
            return connection;
        }
    }
}
