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
    }
}
