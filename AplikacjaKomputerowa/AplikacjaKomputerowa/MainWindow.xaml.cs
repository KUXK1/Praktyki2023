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
        private string Tabela = "";
        private string Typ = "";
        private string Nazwa = "";
        public MainWindow()
        {
            InitializeComponent();
            DataTables();



        }


        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            FormularzDodawania();
        }
        private void Usuń_Click(object sender, RoutedEventArgs e)
        {
            FolmularzUsuwania();
        }
        private void DataTables()
        {
            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();
            string query1 = "SELECT * FROM Diodes";
            string query2 = "SELECT * FROM Resistors";
            string query3 = "SELECT * FROM Capacitors";
            using (SqlCommand cmd = new SqlCommand(query1, con))
            {
                DataTable dt = new DataTable("komponenty");
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                Kondesatory.ItemsSource = dt.DefaultView;
            }
            using (SqlCommand cmd = new SqlCommand(query2, con))
            {
                DataTable dt = new DataTable("komponenty");
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                Rezystory.ItemsSource = dt.DefaultView;
            }
            using (SqlCommand cmd = new SqlCommand(query3, con))
            {
                DataTable dt = new DataTable("komponenty");
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                Diody.ItemsSource = dt.DefaultView;
            }
            con.Close();
        }
        private void FolmularzUsuwania()
        {
            Usun_formularz obj = new Usun_formularz();
            if (obj.ShowDialog() == true)
            {
                string input1 = obj.x;
                string input2 = obj.y;
                BazaDanych bazaDanych = new BazaDanych();
                SqlConnection con = bazaDanych.SQL();
                con.Open();
                string sql = $"DELETE FROM {input1} WHERE Part_number = @id";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    // Dodanie parametru do polecenia SQL
                    command.Parameters.AddWithValue("@id", input2);

                    // Wykonanie polecenia SQL
                    int rowsAffected = command.ExecuteNonQuery();

                }
                con.Close();
                DataTables();
            }
        }
        private void FormularzDodawania()
        {
            Dodaj_formularz obj = new Dodaj_formularz();
            if (obj.ShowDialog() == true)
            {
                String Tabela = obj.Tabela;
                String Typ = obj.Typ;
                String Numer = obj.Numer;
                String Stan = obj.Stan;
                String Spec1 = obj.Spec1;
                String Spec2 = obj.Spec2;
                String Spec3 = obj.Spec3;
                String Spec4 = obj.Spec4;
                String querya = obj.Quera;
                BazaDanych bazaDanych = new BazaDanych();
                SqlConnection con = bazaDanych.SQL();
                con.Open();
                string query = $"SELECT COUNT(*) FROM {Tabela} WHERE Part_number = @Value0";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Value0", Numer);
                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    // Dodanie nowego rekordu z podanymi wartościami
                    command = new SqlCommand(querya, con);
                    command.Parameters.AddWithValue("@Value0",Typ );
                    command.Parameters.AddWithValue("@Value1",Numer );
                    command.Parameters.AddWithValue("@Value2",Stan );
                    command.Parameters.AddWithValue("@Value3",Spec1 );
                    command.Parameters.AddWithValue("@Value4",Spec2 );
                    command.Parameters.AddWithValue("@Value5",Spec3 );
                    if (Tabela == "Diodes") {command.Parameters.AddWithValue("@Value6", Spec4); }
                    command.ExecuteNonQuery();
                }
                else
                {
                    // Zwiększenie wartości encji ilość o podaną liczbę
                    query = $"UPDATE {Tabela} SET stan = stan + @Value0 WHERE Part_number = @Value1";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Value1", Numer);
                    command.Parameters.AddWithValue("@Value0", Stan);
                    command.ExecuteNonQuery();
                    
                }
                con.Close();
                DataTables();

            }
                

        }

    }
}
