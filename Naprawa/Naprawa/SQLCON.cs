using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Naprawa
{
    public class BazaDanych
    {
        public SqlConnection SQL()
        {
            //string url = @"Data Source=192.168.0.27,2021;Initial Catalog=Magazyn;User ID=Admin;Password=2004;";
            string url = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a95a6c_magazyn;User Id=db_a95a6c_magazyn_admin;Password=Praktyki2023;";

            //string url = @"Data Source=DESKTOP-DE0MP54\SQLEXPRESS;Initial Catalog=Magazyn;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(url);
            return sqlConnection;
        }
    }
}
