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
using System.IO;

namespace AplikacjaKomputerowa
{
    /// <summary>
    /// Logika interakcji dla klasy ExportTable.xaml
    /// </summary>
    public partial class ExportTable : Window
    {
        string query;
        string format;


        public ExportTable()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = I1.Text;


            BazaDanych bazaDanych = new BazaDanych();
            SqlConnection con = bazaDanych.SQL();
            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            StreamWriter writer = new StreamWriter(path);
            while (reader.Read())
            {

                writer.WriteLine(format);
            }

            writer.Close();
            reader.Close();
            con.Close();

            DialogResult = true;
            this.Close();


        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string x = selectedItem.Content.ToString();

            switch (x)
            {
                case "Resistors":
                    query = $"select Resistance, Tolerance, Package, Component_Number, Power, Type, Rated_voltage from Resistors";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, Resistors {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}/{reader[6]}";
                    break;
                case "Diodes":
                    query = $"select Voltage, Current, Package, Component_Number, Type, Power, Color from Diodes";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, Diodes {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}/{reader[6]}";
                    break;
                case "Capacitors":
                    query = $"select Capacitance, Dielectric, Rated Voltage, Package, Component_Number, Tolerance, Type  from Capacitors";
                    format = $"{reader[0]}/{reader[1]}/{reader[2]}-{reader[3]}, Capacitors {reader[4]}, {reader[4]}, {reader[5]}/{reader[6]}";
                    break;
                case "DCDC":
                    query = $"select IN_voltage, OUT_voltage, Power, Component number, Type form DCDC";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, DCDC {reader[3]}, {reader[3]}, {reader[4]}";
                    break;
                case "Fuses":
                    query = $"select Rating_current, Switched/max_current, Max voltage, Component number, Type, Package form Fuses";
                    format = $"{reader[0]}/{reader[1]}/{reader[2]}, Fuses {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}";
                    break;
                case "Oscilattors":
                    query = $"select Frequency, Tolerance, Package, Component_number form Oscilattors";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, Oscilattors {reader[3]}, {reader[3]}";
                    break;
                case "Transistors":
                    query = $"select Voltage, Current, Package, Component_number, type form Transistors";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, Transistors {reader[3]}, {reader[3]}, {reader[4]}";
                    break;
                case "Ferrite_beads":
                    query = $"select Impedance_at_HF, Rated_current, Package, Component_number, Resistance form Ferrite_beads";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, Ferrite_beads {reader[3]}, {reader[3]}, {reader[4]}";
                    break;
                case "Connectors":
                    query = $"select Rows, Pitch, Orientation, Component_number, Mounting, type form Connectors";
                    format = $"{reader[0]}/{reader[1]}-{reader[2]}, Connectors {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}";
                    break;
                case "Modules":
                    query = $"select Supply_voltage, Type, Component_number, Description from Modules";
                    format = $"{reader[0]}/{reader[1]}, Modules {reader[2]}, {reader[2]}, {reader[3]} ";
                    break;
                case "IC":
                    query = $"select Type, Supply_voltage, Component_number, Description from IC";
                    format = $"{reader[0]}/{reader[1]}, IC {reader[2]}, {reader[2]}, {reader[3]} ";
                    break;
                case "Other":
                    query = $"select Type, package, Component_number, Description from other";
                    format = $"{reader[0]}-{reader[1]}, other {reader[2]}, {reader[2]}, {reader[3]} ";
                    break;

                default:

                    break;
            }

        }
    }
}
