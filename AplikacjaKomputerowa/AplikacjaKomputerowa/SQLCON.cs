using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AplikacjaKomputerowa
{
    public class BazaDanych
    {
        public SqlConnection SQL()
        {
            string url = @"Data Source=192.168.0.27,2021;Initial Catalog=Magazyn;User ID=Admin;Password=2004;";
            //string url = @"Data Source=DESKTOP-DE0MP54\SQLEXPRESS;Initial Catalog=Magazyn;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(url);
            return sqlConnection;
        }
    }
}
