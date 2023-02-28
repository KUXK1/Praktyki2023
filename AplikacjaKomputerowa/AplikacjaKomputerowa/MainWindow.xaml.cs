using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace AplikacjaKomputerowa
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

      


        }
        public class BazaDanych
        {
            public SqlConnection SQL()
            {
                string url = @"Data Source=DESKTOP-DE0MP54\SQLEXPRESS;Initial Catalog=Magazyn;Integrated Security=True;";
                SqlConnection sqlConnection = new SqlConnection(url);
                return sqlConnection;
            }
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();
            string query = "SELECT * FROM komponenty";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                Kondesatory.ItemsSource = dt.DefaultView;
            }
        }
    }
}
