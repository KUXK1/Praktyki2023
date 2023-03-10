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
            this.SizeToContent = SizeToContent.WidthAndHeight;
            InitializeComponent();
            DataTables();
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddCom();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DeleteCom();
        }
        private void DataTables()
        {
            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();
            string query1 = "SELECT * FROM Diodes";
            using (SqlCommand cmd = new SqlCommand(query1, con))
            {
                DataTable dt = new DataTable("komponenty");
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                DataPanel.ItemsSource = dt.DefaultView;
            }
            con.Close();
        }
        private void DeleteCom()
        {
            Usun_formularz obj = new Usun_formularz();
            if (obj.ShowDialog() == true)
            {
                string Tabela = obj.x;
                string input2 = obj.y;
                string input3 = obj.z;
                if (input3 == "")
                {
                    BazaDanych bazaDanych = new BazaDanych();
                    SqlConnection con = bazaDanych.SQL();
                    con.Open();
                    string sql = $"DELETE FROM {Tabela} WHERE Part_number = @Value0";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@Value0", input2);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    BazaDanych bazaDanych = new BazaDanych();
                    SqlConnection con = bazaDanych.SQL();
                    con.Open();
                    string sql = $"UPDATE {Tabela} SET Quantity = Quantity - @Value0 WHERE Part_number = @Value1";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@Value1", input2);
                    command.Parameters.AddWithValue("@Value0", input3);
                    command.ExecuteNonQuery();
                    string sel = $"select Quantity from {Tabela} where Part_number = @Value0";
                    SqlCommand com = new SqlCommand(sel, con);
                    com.Parameters.AddWithValue("@Value0", input2);
                    int currentAmount = (int)com.ExecuteScalar();
                    if (currentAmount <= 0)
                    {
                        string del = $"delete from {Tabela} where Part_number = @Value0";
                        command = new SqlCommand(del, con);
                        command.Parameters.AddWithValue("@Value0", input2);
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
                
                DataTables();
            }
        }
        private void AddCom()
        {
            Dodaj_formularz obj = new Dodaj_formularz();
            if (obj.ShowDialog() == true)
            {
                String Tabela = obj.Tabela;
                String Type = obj.Typ;
                String Number = obj.Number;
                String Quantity = obj.Quantity;
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
                command.Parameters.AddWithValue("@Value0", Number);
                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    command = new SqlCommand(querya, con);
                    command.Parameters.AddWithValue("@Value0", Type);
                    command.Parameters.AddWithValue("@Value1", Number);
                    command.Parameters.AddWithValue("@Value2", Quantity);
                    if (Tabela != "Connectors" || Tabela != "Modules")
                    {
                        command.Parameters.AddWithValue("@Value3", Spec1);
                        command.Parameters.AddWithValue("@Value4", Spec2);
                        if (Tabela != "Fuses" || Tabela != "DCDC" || Tabela !="IC")
                        {
                            command.Parameters.AddWithValue("@Value5", Spec3);
                            if (Tabela == "Diodes" || Tabela == "Optolsolators") { command.Parameters.AddWithValue("@Value6", Spec4); }
                        }
                    }
                    command.ExecuteNonQuery();
                }
                else
                {
                    query = $"UPDATE {Tabela} SET Quantity = Quantity + @Value0 WHERE Part_number = @Value1";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Value1", Number);
                    command.Parameters.AddWithValue("@Value0", Quantity);
                    command.ExecuteNonQuery();
                }
                con.Close();
                DataTables();

            }


        }

       

        private void Sel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

                ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string lef_sele = selectedItem.Content.ToString();
            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();
            string query1 = $"SELECT * FROM {lef_sele}";
                SqlCommand cmd = new SqlCommand(query1, con);

                DataTable dt = new DataTable("komponenty");
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                DataPanel.ItemsSource = dt.DefaultView;
        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {
            ProjectList projectwindow = new ProjectList();
            projectwindow.Show();


        }
    }
}
