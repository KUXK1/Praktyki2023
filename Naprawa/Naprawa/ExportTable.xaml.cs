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

namespace Naprawa
{
    /// <summary>
    /// Logika interakcji dla klasy ExportTable.xaml
    /// </summary>
    public partial class ExportTable : Window
    {
        string query;
        int SwitchFormat;


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
            String format;
            StreamWriter writer = new StreamWriter(path);
            while (reader.Read())
            {
                switch (SwitchFormat)
                {
                    case 1:
                        format = $"{reader[0]}/{reader[1]}-{reader[2]}, Resistors {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}/{reader[6]}";
                        writer.WriteLine(format);
                        break;
                    case 2:
                        format = $"{reader[0]}/{reader[1]}-{reader[2]}, Diodes {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}/{reader[6]}";
                        writer.WriteLine(format);
                        break;
                    case 3:
                        format = $"{reader[0]}/{reader[1]}/{reader[2]}-{reader[3]}, Capacitors {reader[4]}, {reader[4]}, {reader[5]}/{reader[6]}";
                        writer.WriteLine(format);
                        break;
                    case 4:
                        format = $"{reader[0]}/{reader[1]}/{reader[2]}-{reader[3]}, Capacitors {reader[4]}, {reader[4]}, {reader[5]}/{reader[6]}";
                        writer.WriteLine(format);
                        break;
                    case 5:
                        format = $"{reader[0]}/{reader[1]}/{reader[2]}, Fuses {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}";
                        writer.WriteLine(format);
                        break;
                    case 6:
                        format = $"{reader[0]}/{reader[1]}-{reader[2]}, Oscilattors {reader[3]}, {reader[3]}";
                        writer.WriteLine(format);
                        break;
                    case 7:
                        format = $"{reader[0]}/{reader[1]}-{reader[2]}, Transistors {reader[3]}, {reader[3]}, {reader[4]}";
                        writer.WriteLine(format);
                        break;
                    case 8:
                        format = $"{reader[0]}/{reader[1]}-{reader[2]}, Ferrite_beads {reader[3]}, {reader[3]}, {reader[4]}";
                        writer.WriteLine(format);
                        break;
                    case 9:
                        format = $"{reader[0]}/{reader[1]}-{reader[2]}, Connectors {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}";
                        writer.WriteLine(format);
                        break;
                    case 10:
                        format = $"{reader[0]}/{reader[1]}, Modules {reader[2]}, {reader[2]}, {reader[3]}";
                        writer.WriteLine(format);
                        break;
                    case 11:
                        format = $"{reader[0]}/{reader[1]}, IC {reader[2]}, {reader[2]}, {reader[3]}";
                        writer.WriteLine(format);
                        break;
                    case 12:
                        format = $"{reader[0]}-{reader[1]}, other {reader[2]}, {reader[2]}, {reader[3]}";
                        writer.WriteLine(format);
                        break;
                    default:
                        break;
                }
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
                    SwitchFormat = 1;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, Resistors {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}/{reader[6]}";
                    break;
                case "Diodes":
                    query = $"select Voltage, Curent, Package, Component_Number, Type, Power, Color from Diodes";
                    SwitchFormat = 2;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, Diodes {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}/{reader[6]}";
                    break;
                case "Capacitors":
                    query = $"select Capacitance, Dielectric, Rated Voltage, Package, Component_Number, Tolerance, Type  from Capacitors";
                    SwitchFormat = 3;
                    //format = $"{reader[0]}/{reader[1]}/{reader[2]}-{reader[3]}, Capacitors {reader[4]}, {reader[4]}, {reader[5]}/{reader[6]}";
                    break;
                case "DCDC":
                    query = $"select IN_voltage, OUT_voltage, Power, Component number, Type form DCDC";
                    SwitchFormat = 4;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, DCDC {reader[3]}, {reader[3]}, {reader[4]}";
                    break;
                case "Fuses":
                    query = $"select Rating_current, Switched_max_current, Max voltage, Component number, Type, Package form Fuses";
                    SwitchFormat = 5;
                    //format = $"{reader[0]}/{reader[1]}/{reader[2]}, Fuses {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}";
                    break;
                case "Oscilattors":
                    query = $"select Frequency, Tolerance, Package, Component_number form Oscilattors";
                    SwitchFormat = 6;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, Oscilattors {reader[3]}, {reader[3]}";
                    break;
                case "Transistors":
                    query = $"select Voltage, Curent, Package, Component_number, type form Transistors";
                    SwitchFormat = 7;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, Transistors {reader[3]}, {reader[3]}, {reader[4]}";
                    break;
                case "Ferrite_beads":
                    query = $"select Impedance_at_HF, Rated_current, Package, Component_number, Resistance form Ferrite_beads";
                    SwitchFormat = 8;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, Ferrite_beads {reader[3]}, {reader[3]}, {reader[4]}";
                    break;
                case "Connectors":
                    query = $"select Rows, Pitch, Orientation, Component_number, Mounting, type form Connectors";
                    SwitchFormat = 9;
                    //format = $"{reader[0]}/{reader[1]}-{reader[2]}, Connectors {reader[3]}, {reader[3]}, {reader[4]}/{reader[5]}";
                    break;
                case "Modules":
                    query = $"select Supply_voltage, Type, Component_number, Description from Modules";
                    SwitchFormat = 10;
                    //format = $"{reader[0]}/{reader[1]}, Modules {reader[2]}, {reader[2]}, {reader[3]} ";
                    break;
                case "IC":
                    query = $"select Type, Supply_voltage, Component_number, Description from IC";
                    SwitchFormat = 11;
                    //format = $"{reader[0]}/{reader[1]}, IC {reader[2]}, {reader[2]}, {reader[3]} ";
                    break;
                case "Other":
                    query = $"select Type, package, Component_number, Description from other";
                    SwitchFormat = 12;
                    //format = $"{reader[0]}-{reader[1]}, other {reader[2]}, {reader[2]}, {reader[3]} ";
                    break;

                default:

                    break;
            }
            

        }
    }
}
