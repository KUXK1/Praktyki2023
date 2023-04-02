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

namespace Naprawa
{
    /// <summary>
    /// Logika interakcji dla klasy Add_folmularz.xaml
    /// </summary>
    public partial class Add_folmularz : Window
    {
        int Add_type;
        string x;
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
                    string selectQuery1 = $"SELECT COUNT(*) FROM resistors WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand1 = new SqlCommand(selectQuery1, con1);
                    int count = (int)selectCommand1.ExecuteScalar();
                    if (count == 0)
                    {
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE resistors SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con1);
                        updateCommand.Parameters.AddWithValue("@Value1", Input8);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con1.Close();

                    break;
                case 2:
                    BazaDanych bazaDanych2 = new BazaDanych();
                    SqlConnection con2 = bazaDanych2.SQL();
                    con2.Open();
                    string selectQuery2 = $"SELECT COUNT(*) FROM Diodes WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand2 = new SqlCommand(selectQuery2, con2);
                    int count2 = (int)selectCommand2.ExecuteScalar();
                    if (count2 == 0)
                    {
                        string sql2 = "INSERT INTO Diodes (Voltage, Curent, Package, Component_Number, Type, Power, Color, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9); ";
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Diodes SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con2);
                        updateCommand.Parameters.AddWithValue("@Value1", Input8);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con2.Close();
                    break;
                case 3:
                    BazaDanych bazaDanych3 = new BazaDanych();
                    SqlConnection con3 = bazaDanych3.SQL();
                    con3.Open();
                    string selectQuery3 = $"SELECT COUNT(*) FROM Capacitors WHERE Component_Number = '{Input5}'";
                    SqlCommand selectCommand3 = new SqlCommand(selectQuery3, con3);
                    int count3 = (int)selectCommand3.ExecuteScalar();
                    if (count3 == 0)
                    {
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Capacitors SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con3);
                        updateCommand.Parameters.AddWithValue("@Value1", Input8);
                        updateCommand.Parameters.AddWithValue("@Value2", Input5);
                        updateCommand.ExecuteNonQuery();
                    }
                    con3.Close();
                    break;
                case 4:
                    BazaDanych bazaDanych4 = new BazaDanych();
                    SqlConnection con4 = bazaDanych4.SQL();
                    con4.Open();
                    string selectQuery4 = $"SELECT COUNT(*) FROM DCDC WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand4 = new SqlCommand(selectQuery4, con4);
                    int count4 = (int)selectCommand4.ExecuteScalar();
                    if (count4 == 0)
                    {
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE DCDC SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con4);
                        updateCommand.Parameters.AddWithValue("@Value1", Input6);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con4.Close();
                    break;
                case 5:
                    BazaDanych bazaDanych5 = new BazaDanych();
                    SqlConnection con5 = bazaDanych5.SQL();
                    con5.Open();
                    string selectQuery5 = $"SELECT COUNT(*) FROM Fuses WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand5 = new SqlCommand(selectQuery5, con5);
                    int count5 = (int)selectCommand5.ExecuteScalar();
                    if (count5 == 0)
                    {
                        string sql5 = "INSERT INTO Fuses (Rating_current, Switched_max_current, Max_voltage, Component_Number, Type, Package, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8); ";
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Fuses SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con5);
                        updateCommand.Parameters.AddWithValue("@Value1", Input7);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con5.Close();
                    break;
                case 6:
                    BazaDanych bazaDanych6 = new BazaDanych();
                    SqlConnection con6 = bazaDanych6.SQL();
                    con6.Open();
                    string selectQuery6 = $"SELECT COUNT(*) FROM Oscilattors WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand6 = new SqlCommand(selectQuery6, con6);
                    int count6 = (int)selectCommand6.ExecuteScalar();
                    if (count6 == 0)
                    {
                        string sql6 = "INSERT INTO Oscilattors (Frequency, Tolerance, Package, Component_Number, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6); ";
                        SqlCommand command6 = new SqlCommand(sql6, con6);
                        command6.Parameters.AddWithValue("@Value1", Input1);
                        command6.Parameters.AddWithValue("@Value2", Input2);
                        command6.Parameters.AddWithValue("@Value3", Input3);
                        command6.Parameters.AddWithValue("@Value4", Input4);
                        command6.Parameters.AddWithValue("@Value5", Input5);
                        command6.Parameters.AddWithValue("@Value6", Input6);
                        command6.ExecuteNonQuery();
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Oscilattors SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con6);
                        updateCommand.Parameters.AddWithValue("@Value1", Input5);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con6.Close();
                    break;
                case 7:
                    BazaDanych bazaDanych7 = new BazaDanych();
                    SqlConnection con7 = bazaDanych7.SQL();
                    con7.Open();
                    string selectQuery7 = $"SELECT COUNT(*) FROM Transistors WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand7 = new SqlCommand(selectQuery7, con7);
                    int count7 = (int)selectCommand7.ExecuteScalar();
                    if (count7 == 0)
                    {
                        string sql7 = "INSERT INTO Transistors (Voltage, Curent, Package, Component_Number, Type, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7 ); ";
                        SqlCommand command7 = new SqlCommand(sql7, con7);
                        command7.Parameters.AddWithValue("@Value1", Input1);
                        command7.Parameters.AddWithValue("@Value2", Input2);
                        command7.Parameters.AddWithValue("@Value3", Input3);
                        command7.Parameters.AddWithValue("@Value4", Input4);
                        command7.Parameters.AddWithValue("@Value5", Input5);
                        command7.Parameters.AddWithValue("@Value6", Input6);
                        command7.Parameters.AddWithValue("@Value7", Input7);
                        command7.ExecuteNonQuery();
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Transistors SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con7);
                        updateCommand.Parameters.AddWithValue("@Value1", Input6);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con7.Close();
                    break;
                case 8:
                    BazaDanych bazaDanych8 = new BazaDanych();
                    SqlConnection con8 = bazaDanych8.SQL();
                    con8.Open();
                    string selectQuery8 = $"SELECT COUNT(*) FROM Ferrite_beads WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand8 = new SqlCommand(selectQuery8, con8);
                    int count8 = (int)selectCommand8.ExecuteScalar();
                    if (count8 == 0)
                    {
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Ferrite_beads SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con8);
                        updateCommand.Parameters.AddWithValue("@Value1", Input6);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con8.Close();
                    break;
                case 9:
                    BazaDanych bazaDanych9 = new BazaDanych();
                    SqlConnection con9 = bazaDanych9.SQL();
                    con9.Open();
                    string selectQuery9 = $"SELECT COUNT(*) FROM Connectors WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand9 = new SqlCommand(selectQuery9, con9);
                    int count9 = (int)selectCommand9.ExecuteScalar();
                    if (count9 == 0)
                    {
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
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Connectors SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con9);
                        updateCommand.Parameters.AddWithValue("@Value1", Input7);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }

                    con9.Close();
                    break;
                case 10:
                    BazaDanych bazaDanych10 = new BazaDanych();
                    SqlConnection con10 = bazaDanych10.SQL();
                    con10.Open();
                    string selectQuery10 = $"SELECT COUNT(*) FROM Modules WHERE Component_Number = '{Input3}'";
                    SqlCommand selectCommand10 = new SqlCommand(selectQuery10, con10);
                    int count10 = (int)selectCommand10.ExecuteScalar();
                    if (count10 == 0)
                    {
                        string sql10 = "INSERT INTO Modules(Supply_voltage, Type, Component_number, Description, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6);";
                        SqlCommand command10 = new SqlCommand(sql10, con10);
                        command10.Parameters.AddWithValue("@Value1", Input1);
                        command10.Parameters.AddWithValue("@Value2", Input2);
                        command10.Parameters.AddWithValue("@Value3", Input3);
                        command10.Parameters.AddWithValue("@Value4", Input4);
                        command10.Parameters.AddWithValue("@Value5", Input5);
                        command10.Parameters.AddWithValue("@Value6", Input6);
                        command10.ExecuteNonQuery();
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Modules SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con10);
                        updateCommand.Parameters.AddWithValue("@Value1", Input5);
                        updateCommand.Parameters.AddWithValue("@Value2", Input3);
                        updateCommand.ExecuteNonQuery();
                    }
                    con10.Close();

                    break;
                case 11:
                    BazaDanych bazaDanych11 = new BazaDanych();
                    SqlConnection con11 = bazaDanych11.SQL();
                    con11.Open();
                    string selectQuery11 = $"SELECT COUNT(*) FROM IC WHERE Component_Number = '{Input4}'";
                    SqlCommand selectCommand11 = new SqlCommand(selectQuery11, con11);
                    int count11 = (int)selectCommand11.ExecuteScalar();
                    if (count11 == 0)
                    {
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
                        
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE IC SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con11);
                        updateCommand.Parameters.AddWithValue("@Value1", Input6);
                        updateCommand.Parameters.AddWithValue("@Value2", Input4);
                        updateCommand.ExecuteNonQuery();
                    }
                    con11.Close();
                    break;
                case 12:
                    BazaDanych bazaDanych12 = new BazaDanych();
                    SqlConnection con12 = bazaDanych12.SQL();
                    con12.Open();
                    string selectQuery12 = $"SELECT COUNT(*) FROM Other WHERE Component_Number = '{Input3}'";
                    SqlCommand selectCommand12 = new SqlCommand(selectQuery12, con12);
                    int count12 = (int)selectCommand12.ExecuteScalar();
                    if (count12 == 0)
                    {
                        string sql12 = "INSERT INTO Other (Type, Package, Component_Number, Description, Quantity, Box_number) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6); ";
                        SqlCommand command12 = new SqlCommand(sql12, con12);
                        command12.Parameters.AddWithValue("@Value1", Input1);
                        command12.Parameters.AddWithValue("@Value2", Input2);
                        command12.Parameters.AddWithValue("@Value3", Input3);
                        command12.Parameters.AddWithValue("@Value4", Input4);
                        command12.Parameters.AddWithValue("@Value5", Input5);
                        command12.Parameters.AddWithValue("@Value6", Input6);
                        command12.ExecuteNonQuery();
                    }
                    else
                    {
                        string updateQuery1 = "UPDATE Other SET Quantity = Quantity + @Value1 WHERE Component_Number = @Value2";
                        SqlCommand updateCommand = new SqlCommand(updateQuery1, con12);
                        updateCommand.Parameters.AddWithValue("@Value1", Input5);
                        updateCommand.Parameters.AddWithValue("@Value2", Input3);
                        updateCommand.ExecuteNonQuery();
                    }
                    con12.Close();
                    break;
                default:

                    break;
            }
            DialogResult = true;
            this.Close();
        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            x = selectedItem.Content.ToString();
            Hide_Form();
            I1.MaxLength = 10;
            I2.MaxLength = 10;
            I3.MaxLength = 10;
            I4.MaxLength = 10;
            I5.MaxLength = 10;
            I6.MaxLength = 10;
            I7.MaxLength = 10;
            I8.MaxLength = 10;
            I9.MaxLength = 10;
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
                    I3.MaxLength = 30;
                    L4.Content = "Component Number:";
                    I4.MaxLength = 30;
                    L5.Content = "Rated voltage:";
                    L6.Content = "Power:";
                    L7.Content = "Type:";
                    I7.MaxLength = 30;
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
                    I3.MaxLength = 30;
                    L4.Content = "Component Number:";
                    I4.MaxLength = 30;
                    L5.Content = "Type:";
                    I5.MaxLength = 30;
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
                    I1.MaxLength = 10;
                    L2.Content = "Dielectric:";
                    I2.MaxLength= 10;
                    L3.Content = "Rated Voltage:";
                    I3.MaxLength = 10;
                    L4.Content = "Package:";
                    I4.MaxLength = 30;
                    L5.Content = "Component Number:";
                    I5.MaxLength = 30;
                    L6.Content = "Tolerance:";
                    I6.MaxLength = 10;
                    L7.Content = "Type:";
                    I7.MaxLength = 30;
                    L8.Content = "Quantity:";
                    L9.Content = "Box number:";
                    I9.MaxLength = 10;
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
                    I4.MaxLength = 30;
                    L5.Content = "Type:";
                    I5.MaxLength = 30;
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
                    I4.MaxLength = 30;
                    L5.Content = "Type:";
                    I5.MaxLength = 30;
                    L6.Content = "Package:";
                    I6.MaxLength = 30;
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
                    I3.MaxLength = 30;
                    L4.Content = "Component number:";
                    I4.MaxLength = 30;
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
                    I3.MaxLength = 30;
                    L4.Content = "Component number:";
                    I4.MaxLength = 30;
                    L5.Content = "Type:";
                    I5.MaxLength = 30;
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
                    I3.MaxLength = 30;
                    L4.Content = "Component number:";
                    I4.MaxLength = 30;
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
                    L1.Content = "Rows/Pin count:";
                    L2.Content = "Pitch:";
                    L3.Content = "Orientation:";
                    I3.MaxLength = 30;
                    L4.Content = "Component number:";
                    I4.MaxLength = 30;
                    L5.Content = "Type:";
                    I5.MaxLength = 30;
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
                    I2.MaxLength = 30;
                    L3.Content = "Component number:";
                    I3.MaxLength = 30;
                    L4.Content = "Description:";
                    I4.MaxLength = 255;
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
                    I1.MaxLength = 30;
                    L2.Content = "Supply voltage:";
                    L3.Content = "Package:";
                    I3.MaxLength = 30;
                    L4.Content = "Component number:";
                    I4.MaxLength = 30;
                    L5.Content = "Description:";
                    I5.MaxLength = 255;
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
                    I1.MaxLength = 30;
                    L2.Content = "Package:";
                    I2.MaxLength = 30;
                    L3.Content = "Component number:";
                    I3.MaxLength = 30;
                    L4.Content = "Description:";
                    I4.MaxLength = 255;
                    L5.Content = "Quantity:";
                    L6.Content = "Box number:";
                    Add_type = 12;
                    break;

                default:

                    break;
            }
            
        }
    }
}
