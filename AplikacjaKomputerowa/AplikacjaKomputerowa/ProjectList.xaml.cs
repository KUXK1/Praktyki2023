using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace AplikacjaKomputerowa
{ 
    public partial class ProjectList : Window
    {
        public ProjectList()
        {
            InitializeComponent();
            GetProjectslist();
        }

        private void ProjectsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRefresh();
        }
        private void GetProjectslist()
        {
            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();
            string query = "SELECT DISTINCT Project_Name FROM Projects";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nazwa = reader.GetString(0);
                ProjectsList.Items.Add(nazwa); 
            }
            reader.Close();
            con.Close();
        }

        private void AddPrj_Click(object sender, RoutedEventArgs e)
        {
            Add_Project obj = new Add_Project();
            if (obj.ShowDialog() == true)
            {
                String Prj_name = obj.Prj_name;
                String Prj_Part = obj.Prj_comp;
                String Prj_q = obj.Prj_q;
                String Prj_c = obj.Prj_c;
                String Prj_Type = obj.Prj_type;
                String Q = "INSERT INTO Projects (Project_Name, Type, Part_number, Quantity, Comment) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4)";
                BazaDanych bazaDanych = new BazaDanych();
                SqlConnection con = bazaDanych.SQL();
                con.Open();
                SqlCommand command = new SqlCommand(Q, con);
                command.Parameters.AddWithValue("@Value0", Prj_name);
                command.Parameters.AddWithValue("@Value1", Prj_Type);
                command.Parameters.AddWithValue("@Value2", Prj_Part);
                command.Parameters.AddWithValue("@Value3", Prj_q);
                command.Parameters.AddWithValue("@Value4", Prj_c);
                command.ExecuteNonQuery();
                con.Close();
                DataRefresh();

            }
        }
        private void DataRefresh()
        {
            string Selected = ProjectsList.SelectedItem.ToString();
            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();
            string query = $"SELECT Type, Part_Number, Quantity, Comment FROM Projects where Project_name = @value0";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Value0", Selected);
            DataTable dt = new DataTable("Projects");
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            ProjectView.ItemsSource = dt.DefaultView;
            con.Close();
        }
    }
}
