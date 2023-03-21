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
                    string sql = $"DELETE FROM {Tabela} WHERE Component_Number = '@Value0'";
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
                    string sql = $"UPDATE {Tabela} SET Quantity = Quantity - @Value0 WHERE Component_Number = '@Value1'";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@Value1", input2);
                    command.Parameters.AddWithValue("@Value0", input3);
                    command.ExecuteNonQuery();
                    string sel = $"select Quantity from {Tabela} where Component_Number = '@Value0'";
                    SqlCommand com = new SqlCommand(sel, con);
                    com.Parameters.AddWithValue("@Value0", input2);
                    int currentAmount = (int)com.ExecuteScalar();
                    if (currentAmount <= 0)
                    {
                        string del = $"delete from {Tabela} where Component_Number = '@Value0'";
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
            Add_folmularz obj = new Add_folmularz();
            if (obj.ShowDialog() == true)
            {

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

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            ExportTable obj = new ExportTable();
            if (obj.ShowDialog() == true)
            {
                DataTables();
            }
        }
    }
}
