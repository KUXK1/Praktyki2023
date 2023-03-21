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

namespace AplikacjaKomputerowa
{
    /// <summary>
    /// Logika interakcji dla klasy Add_folmularz.xaml
    /// </summary>
    public partial class Add_folmularz : Window
    {
        int Add_type;
        public Add_folmularz()
        {
            InitializeComponent();
            Hide_Form();
        }
        private void Hide_Form()
        {
            L1.Visibility = Visibility.Collapsed;
            I1.Visibility = Visibility.Collapsed;
            L2.Visibility = Visibility.Collapsed;
            I2.Visibility = Visibility.Collapsed;
            L3.Visibility = Visibility.Collapsed;
            I3.Visibility = Visibility.Collapsed;
            L4.Visibility = Visibility.Collapsed;
            I4.Visibility = Visibility.Collapsed;
            L5.Visibility = Visibility.Collapsed;
            I5.Visibility = Visibility.Collapsed;
            L6.Visibility = Visibility.Collapsed;
            I6.Visibility = Visibility.Collapsed;
            L7.Visibility = Visibility.Collapsed;
            I7.Visibility = Visibility.Collapsed;
            L8.Visibility = Visibility.Collapsed;
            I8.Visibility = Visibility.Collapsed;
            L9.Visibility = Visibility.Collapsed;
            I9.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Input1 = I1.Text;
            String Input2 = I2.Text;
            String Input3 = I3.Text;
            String Input4 = I4.Text;
            String Input5 = I5.Text;
            String Input6 = I6.Text;
            String Input7 = I7.Text;
            String Input8 = I8.Text;
            String Input9 = I9.Text;
            switch (Add_type)
            {
                case 1:
                    BazaDanych bazaDanych1 = new BazaDanych();
                    SqlConnection con1 = bazaDanych1.SQL();
                    con1.Open();
                    string sql1 = "INSERT INTO resistors (Resistance, Tolerance, Package, Component_Number, Rated_voltage, Power, Type, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9); ";
                    SqlCommand command1 = new SqlCommand(sql1, con1);
                    command1.Parameters.AddWithValue("@Value1", Input1);
                    command1.Parameters.AddWithValue("@Value2", Input2);
                    command1.Parameters.AddWithValue("@Value3", Input3);
                    command1.Parameters.AddWithValue("@Value4", Input4);
                    command1.Parameters.AddWithValue("@Value5", Input5);
                    command1.Parameters.AddWithValue("@Value6", Input6);
                    command1.Parameters.AddWithValue("@Value7", Input7);
                    command1.Parameters.AddWithValue("@Value8", Input8);
                    command1.Parameters.AddWithValue("@Value9", Input9);
                    command1.ExecuteNonQuery();
                    con1.Close();
                    
                    break;
                case 2:
                    BazaDanych bazaDanych2 = new BazaDanych();
                    SqlConnection con2 = bazaDanych2.SQL();
                    con2.Open();
                    string sql2 = "INSERT INTO Diodes (Voltage, ['Current'], Package, Component_Number, Type, Power, Color, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9); ";
                    SqlCommand command2 = new SqlCommand(sql2, con2);
                    command2.Parameters.AddWithValue("@Value1", Input1);
                    command2.Parameters.AddWithValue("@Value2", Input2);
                    command2.Parameters.AddWithValue("@Value3", Input3);
                    command2.Parameters.AddWithValue("@Value4", Input4);
                    command2.Parameters.AddWithValue("@Value5", Input5);
                    command2.Parameters.AddWithValue("@Value6", Input6);
                    command2.Parameters.AddWithValue("@Value7", Input7);
                    command2.Parameters.AddWithValue("@Value8", Input8);
                    command2.Parameters.AddWithValue("@Value9", Input9);
                    command2.ExecuteNonQuery();
                    con2.Close();
                    break;
                case 3:
                    BazaDanych bazaDanych3 = new BazaDanych();
                    SqlConnection con3 = bazaDanych3.SQL();
                    con3.Open();
                    string sql3 = "INSERT INTO Capacitors (Capacitance, Dielectric, Rated_Voltage, Package, Component_Number, Tolerance, Type, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9); ";
                    SqlCommand command3 = new SqlCommand(sql3, con3);
                    command3.Parameters.AddWithValue("@Value1", Input1);
                    command3.Parameters.AddWithValue("@Value2", Input2);
                    command3.Parameters.AddWithValue("@Value3", Input3);
                    command3.Parameters.AddWithValue("@Value4", Input4);
                    command3.Parameters.AddWithValue("@Value5", Input5);
                    command3.Parameters.AddWithValue("@Value6", Input6);
                    command3.Parameters.AddWithValue("@Value7", Input7);
                    command3.Parameters.AddWithValue("@Value8", Input8);
                    command3.Parameters.AddWithValue("@Value9", Input9);
                    command3.ExecuteNonQuery();
                    con3.Close();
                    break;
                case 4:
                    BazaDanych bazaDanych4 = new BazaDanych();
                    SqlConnection con4 = bazaDanych4.SQL();
                    con4.Open();
                    string sql4 = "INSERT INTO DCDC (IN_voltage, OUT_voltage, Power, Component_Number, Type, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7); ";
                    SqlCommand command4 = new SqlCommand(sql4, con4);
                    command4.Parameters.AddWithValue("@Value1", Input1);
                    command4.Parameters.AddWithValue("@Value2", Input2);
                    command4.Parameters.AddWithValue("@Value3", Input3);
                    command4.Parameters.AddWithValue("@Value4", Input4);
                    command4.Parameters.AddWithValue("@Value5", Input5);
                    command4.Parameters.AddWithValue("@Value6", Input6);
                    command4.Parameters.AddWithValue("@Value7", Input7);

                    command4.ExecuteNonQuery();
                    con4.Close();
                    break;
                case 5:
                    BazaDanych bazaDanych5 = new BazaDanych();
                    SqlConnection con5 = bazaDanych5.SQL();
                    con5.Open();
                    string sql5 = "INSERT INTO Fuses (Rating_current, Switched/max_current, Max_voltage, Component_Number, Type, Package, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8); ";
                    SqlCommand command5 = new SqlCommand(sql5, con5);
                    command5.Parameters.AddWithValue("@Value1", Input1);
                    command5.Parameters.AddWithValue("@Value2", Input2);
                    command5.Parameters.AddWithValue("@Value3", Input3);
                    command5.Parameters.AddWithValue("@Value4", Input4);
                    command5.Parameters.AddWithValue("@Value5", Input5);
                    command5.Parameters.AddWithValue("@Value6", Input6);
                    command5.Parameters.AddWithValue("@Value7", Input7);
                    command5.Parameters.AddWithValue("@Value8", Input8);
                    command5.ExecuteNonQuery();
                    con5.Close();
                    break;
                case 6:
                    BazaDanych bazaDanych6 = new BazaDanych();
                    SqlConnection con6 = bazaDanych6.SQL();
                    con6.Open();
                    string sql6 = "INSERT INTO Oscilattors (Frequency, Tolerance, Package, Component_Number, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6); ";
                    SqlCommand command6 = new SqlCommand(sql6, con6);
                    command6.Parameters.AddWithValue("@Value1", Input1);
                    command6.Parameters.AddWithValue("@Value2", Input2);
                    command6.Parameters.AddWithValue("@Value3", Input3);
                    command6.Parameters.AddWithValue("@Value4", Input4);
                    command6.Parameters.AddWithValue("@Value5", Input5);
                    command6.Parameters.AddWithValue("@Value6", Input6);
                    command6.ExecuteNonQuery();
                    con6.Close();
                    break;
                case 7:
                    BazaDanych bazaDanych7 = new BazaDanych();
                    SqlConnection con7 = bazaDanych7.SQL();
                    con7.Open();
                    string sql7 = "INSERT INTO Transistors (Voltage, Current, Package, Component_Number, Type, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7 ); ";
                    SqlCommand command7 = new SqlCommand(sql7, con7);
                    command7.Parameters.AddWithValue("@Value1", Input1);
                    command7.Parameters.AddWithValue("@Value2", Input2);
                    command7.Parameters.AddWithValue("@Value3", Input3);
                    command7.Parameters.AddWithValue("@Value4", Input4);
                    command7.Parameters.AddWithValue("@Value5", Input5);
                    command7.Parameters.AddWithValue("@Value6", Input6);
                    command7.Parameters.AddWithValue("@Value7", Input7);
                    command7.ExecuteNonQuery();
                    con7.Close();
                    break;
                case 8:
                    BazaDanych bazaDanych8 = new BazaDanych();
                    SqlConnection con8 = bazaDanych8.SQL();
                    con8.Open();
                    string sql8 = "INSERT INTO Ferrite_beads (Impedance_at_HF, Rated_current, Package, Component_Number, Resistance, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7 ); ";
                    SqlCommand command8 = new SqlCommand(sql8, con8);
                    command8.Parameters.AddWithValue("@Value1", Input1);
                    command8.Parameters.AddWithValue("@Value2", Input2);
                    command8.Parameters.AddWithValue("@Value3", Input3);
                    command8.Parameters.AddWithValue("@Value4", Input4);
                    command8.Parameters.AddWithValue("@Value5", Input5);
                    command8.Parameters.AddWithValue("@Value6", Input6);
                    command8.Parameters.AddWithValue("@Value7", Input7);
                    command8.ExecuteNonQuery();
                    con8.Close();
                    break;
                case 9:
                    BazaDanych bazaDanych9 = new BazaDanych();
                    SqlConnection con9 = bazaDanych9.SQL();
                    con9.Open();
                    string sql9 = "INSERT INTO Connectors (Rows, Pitch, Orientation, Component_Number, Type, Mounting, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8 ); ";
                    SqlCommand command9 = new SqlCommand(sql9, con9);
                    command9.Parameters.AddWithValue("@Value1", Input1);
                    command9.Parameters.AddWithValue("@Value2", Input2);
                    command9.Parameters.AddWithValue("@Value3", Input3);
                    command9.Parameters.AddWithValue("@Value4", Input4);
                    command9.Parameters.AddWithValue("@Value5", Input5);
                    command9.Parameters.AddWithValue("@Value6", Input6);
                    command9.Parameters.AddWithValue("@Value7", Input7);
                    command9.Parameters.AddWithValue("@Value8", Input8);
                    command9.ExecuteNonQuery();
                    con9.Close();
                    break;
                case 10:
                    BazaDanych bazaDanych10 = new BazaDanych();
                    SqlConnection con10 = bazaDanych10.SQL();
                    con10.Open();
                    string sql10 = "INSERT INTO Modules(Supply_voltage, Type, Component_number, Description, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6);";
                    SqlCommand command10 = new SqlCommand(sql10, con10);
                    command10.Parameters.AddWithValue("@Value1", Input1);
                    command10.Parameters.AddWithValue("@Value2", Input2);
                    command10.Parameters.AddWithValue("@Value3", Input3);
                    command10.Parameters.AddWithValue("@Value4", Input4);
                    command10.Parameters.AddWithValue("@Value5", Input5);
                    command10.Parameters.AddWithValue("@Value6", Input6);
                    command10.ExecuteNonQuery();
                    con10.Close();

                    break;
                case 11:
                    BazaDanych bazaDanych11 = new BazaDanych();
                    SqlConnection con11 = bazaDanych11.SQL();
                    con11.Open();
                    string sql11 = "INSERT INTO IC (Type, Supply_voltage, Package, Component_Number, Description, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7); ";
                    SqlCommand command11 = new SqlCommand(sql11, con11);
                    command11.Parameters.AddWithValue("@Value1", Input1);
                    command11.Parameters.AddWithValue("@Value2", Input2);
                    command11.Parameters.AddWithValue("@Value3", Input3);
                    command11.Parameters.AddWithValue("@Value4", Input4);
                    command11.Parameters.AddWithValue("@Value5", Input5);
                    command11.Parameters.AddWithValue("@Value6", Input6);
                    command11.Parameters.AddWithValue("@Value7", Input7);
                    command11.ExecuteNonQuery();
                    con11.Close();
                    break;
                case 12:
                    BazaDanych bazaDanych12 = new BazaDanych();
                    SqlConnection con12 = bazaDanych12.SQL();
                    con12.Open();
                    string sql12 = "INSERT INTO Other (Type, Package, Component_Number, Description, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6); ";
                    SqlCommand command12 = new SqlCommand(sql12, con12);
                    command12.Parameters.AddWithValue("@Value1", Input1);
                    command12.Parameters.AddWithValue("@Value2", Input2);
                    command12.Parameters.AddWithValue("@Value3", Input3);
                    command12.Parameters.AddWithValue("@Value4", Input4);
                    command12.Parameters.AddWithValue("@Value5", Input5);
                    command12.Parameters.AddWithValue("@Value6", Input6);
                    command12.ExecuteNonQuery();
                    con12.Close();
                    break;
                default:

                    break;
            }
        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string x = selectedItem.Content.ToString();
            Hide_Form();
            switch (x)
            {
                case "Resistors":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L8.Visibility = Visibility.Visible;
                    I8.Visibility = Visibility.Visible;
                    L9.Visibility = Visibility.Visible;
                    I9.Visibility = Visibility.Visible;
                    L1.Content = "Resistance:";
                    L2.Content = "Tolerance:";
                    L3.Content = "Package:";
                    L4.Content = "Component Number:";
                    L5.Content = "Rated voltage:";
                    L6.Content = "Power:";
                    L7.Content = "Type:";
                    L8.Content = "Quantity:";
                    L9.Content = "Box number:";
                    Add_type = 1;
                    break;
                case "Diodes":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L8.Visibility = Visibility.Visible;
                    I8.Visibility = Visibility.Visible;
                    L9.Visibility = Visibility.Visible;
                    I9.Visibility = Visibility.Visible;
                    L1.Content = "Voltage:";
                    L2.Content = "Current:";
                    L3.Content = "Package:";
                    L4.Content = "Component Number:";
                    L5.Content = "Type:";
                    L6.Content = "Power:";
                    L7.Content = "Color:";
                    L8.Content = "Quantity:";
                    L9.Content = "Box number:";
                    Add_type = 2;
                    break;
                case "Capacitors":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L8.Visibility = Visibility.Visible;
                    I8.Visibility = Visibility.Visible;
                    L9.Visibility = Visibility.Visible;
                    I9.Visibility = Visibility.Visible;
                    L1.Content = "Capacitance:";
                    L2.Content = "Dielectric:";
                    L3.Content = "Rated Voltage:";
                    L4.Content = "Package:";
                    L5.Content = "Component Number:";
                    L6.Content = "Tolerance:";
                    L7.Content = "Type:";
                    L8.Content = "Quantity:";
                    L9.Content = "Box number:";
                    Add_type = 3;
                    break;
                case "DCDC":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L1.Content = "IN voltage:";
                    L2.Content = "OUT voltage:";
                    L3.Content = "Power:";
                    L4.Content = "Component number:";
                    L5.Content = "Type:";
                    L6.Content = "Quantity:";
                    L7.Content = "Box number:";
                    Add_type = 4;
                    break;
                case "Fuses":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L8.Visibility = Visibility.Visible;
                    I8.Visibility = Visibility.Visible;
                    L1.Content = "Rating current:";
                    L2.Content = "Switched/max current:";
                    L3.Content = "Max voltage:";
                    L4.Content = "Component number:";
                    L5.Content = "Type:";
                    L6.Content = "Package:";
                    L7.Content = "Quantity:";
                    L8.Content = "Box number:";
                    Add_type = 5;
                    break;
                case "Oscilattors":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L1.Content = "Frequency:";
                    L2.Content = "Tolerance:";
                    L3.Content = "Package:";
                    L4.Content = "Component number:";
                    L5.Content = "Quantity:";
                    L6.Content = "Box number:";
                    Add_type = 6;
                    break;

                case "Transistors":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L1.Content = "Voltage:";
                    L2.Content = "Current:";
                    L3.Content = "Package:";
                    L4.Content = "Component number:";
                    L5.Content = "Type:";
                    L6.Content = "Quantity:";
                    L7.Content = "Box number:";
                    Add_type = 7;
                    break;
                case "Ferrite_beads":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L1.Content = "Impedance at HF:";
                    L2.Content = "Rated current:";
                    L3.Content = "Package:";
                    L4.Content = "Component number:";
                    L5.Content = "Resistance:";
                    L6.Content = "Quantity:";
                    L7.Content = "Box number:";
                    Add_type = 8;
                    break;
                case "Connectors":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;
                    L8.Visibility = Visibility.Visible;
                    I8.Visibility = Visibility.Visible;
                    L1.Content = "Rows:";
                    L2.Content = "Pitch:";
                    L3.Content = "Orientation:";
                    L4.Content = "Component number:";
                    L5.Content = "Type:";
                    L6.Content = "Mounting:";
                    L7.Content = "Quantity:";
                    L8.Content = "Box number:";
                    Add_type = 9;
                    break;
                case "Modules":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;

                    L1.Content = "Supply voltage:";
                    L2.Content = "Type:";
                    L3.Content = "Component number:";
                    L4.Content = "Description:";
                    L5.Content = "Quantity:";
                    L6.Content = "Box number:";
                    Add_type = 10;
                    break;
                case "IC":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;
                    L7.Visibility = Visibility.Visible;
                    I7.Visibility = Visibility.Visible;

                    L1.Content = "Type:";
                    L2.Content = "Supply voltage:";
                    L3.Content = "Package:";
                    L4.Content = "Component number:";
                    L5.Content = "Description:";
                    L6.Content = "Quantity:";
                    L7.Content = "Box number:";
                    Add_type = 11;
                    break;
                case "Other":
                    L1.Visibility = Visibility.Visible;
                    I1.Visibility = Visibility.Visible;
                    L2.Visibility = Visibility.Visible;
                    I2.Visibility = Visibility.Visible;
                    L3.Visibility = Visibility.Visible;
                    I3.Visibility = Visibility.Visible;
                    L4.Visibility = Visibility.Visible;
                    I4.Visibility = Visibility.Visible;
                    L5.Visibility = Visibility.Visible;
                    I5.Visibility = Visibility.Visible;
                    L6.Visibility = Visibility.Visible;
                    I6.Visibility = Visibility.Visible;

                    L1.Content = "Type:";
                    L2.Content = "Package:";
                    L3.Content = "Component number:";
                    L4.Content = "Description:";
                    L5.Content = "Quantity:";
                    L6.Content = "Box number:";
                    Add_type = 12;
                    break;

                default:

                    break;
            }
            DialogResult = true;
            this.Close();
        }
    }
}
