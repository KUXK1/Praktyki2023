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

namespace AplikacjaKomputerowa
{
    /// <summary>
    /// Logika interakcji dla klasy Dodaj_formularz.xaml
    /// </summary>
    public partial class Dodaj_formularz : Window
    {
        public string Tabela { get; set; }
        public string Typ { get; set; }
        public string Numer { get; set; }
        public string Stan { get; set; }
        public string Spec1 { get; set; }
        public string Spec2  { get; set; }
        public string Spec3 { get; set; }
        public string Spec4 { get; set; }
        public string Quera { get; set; }
        public Dodaj_formularz()
        {
            InitializeComponent();
        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string x = selectedItem.Content.ToString();
            switch (x)
            {
                case "Resistors":
                    Tabela = x;
                    Quera = "INSERT INTO Resistors (Typ, Part_number, Stan, Rezystancja, Tolerancja, Moc) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5)";
                    Text_1.Content = "Rezystancja:";
                    Text_2.Content = "Tolerancja:";
                    Text_3.Content = "Moc:";
                    Text_4.Content = "Pozostaw puste:";
                    break;
                case "Diodes":
                    Tabela = x;
                    Quera = "INSERT INTO Diodes (Typ, Part_number, Stan, Napiecie, Prąd, Kolor, Moc) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                    Text_1.Content = "Napiecie:";
                    Text_2.Content = "Prad:";
                    Text_3.Content = "Kolor:";
                    Text_4.Content = "Moc:";
                    break;
                case "Capacitors":
                    Tabela = x;
                    Quera = "INSERT INTO Capacitors (Typ, Part_number, Stan, Pojemnosc, Tolerancja, Napiecie) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5)";
                    Text_1.Content = "Pojemność:";
                    Text_2.Content = "Tolerancja:";
                    Text_3.Content = "Napiecie:";
                    Text_4.Content = "Pozostaw puste:";
                    break;
                case "DCDC":
                    Tabela = x;
                    Quera = "INSERT INTO DCDC (Typ, Part_number, Stan, Obudowa, Napięcie) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4)";
                    Text_1.Content = "Obudowa:";
                    Text_2.Content = "Napięcie:";
                    Text_3.Content = "Pozostaw puste:";
                    Text_4.Content = "Pozostaw puste:";
                    break;
                case "Fuses":
                    Tabela = x;
                    Quera = "INSERT INTO Fuses (Typ, Part_number, Stan, Prąd, Napięcie) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4)";
                    Text_1.Content = "Prąd:";
                    Text_2.Content = "Napięcie:";
                    Text_3.Content = "Pozostaw puste:";
                    Text_4.Content = "Pozostaw puste:";
                    break;
                case "Oscillators":
                    Tabela = x;
                    Quera = "INSERT INTO Oscillators (Typ, Part_number, Stan, Obudowa, Częstotliwość, Pojemność) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5)";
                    Text_1.Content = "Obudowa:";
                    Text_2.Content = "Częstotliwość:";
                    Text_3.Content = "Pojemność:";
                    Text_4.Content = "Pozostaw puste:";
                    break;
                case "Optolsolators":
                    Tabela = x;
                    Quera = "INSERT INTO Optolsolator (Typ, Part_number, Stan, Obudowa, Napięcie, Pasmo, Technologia) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                    Text_1.Content = "Obudowa:";
                    Text_2.Content = "Napięcie:";
                    Text_3.Content = "Pasmo:";
                    Text_4.Content = "Technologia:";
                    break;
                case "Transistors":
                    Tabela = x;
                    Quera = "INSERT INTO Transistors (Typ, Part_number, Stan, Prąd, Napięcie, Technologia) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5)";
                    Text_1.Content = "Prąd:";
                    Text_2.Content = "Napięcie:";
                    Text_4.Content = "Pozostaw puste:";
                    Text_3.Content = "Technologia:";
                    break;
                case "Connectors":
                    Tabela = x;
                    Quera = "INSERT INTO Connectors (Typ, Part_number, Stan) VALUES (@Value0, @Value1, @Value2)";
                    Text_1.Content = "Pozostaw puste:";
                    Text_2.Content = "Pozostaw puste:";
                    Text_4.Content = "Pozostaw puste:";
                    Text_3.Content = "Pozostaw puste:";
                    break;
                case "Modules":
                    Tabela = x;
                    Quera = "INSERT INTO Modules (Typ, Part_number, Stan) VALUES (@Value0, @Value1, @Value2)";
                    Text_1.Content = "Pozostaw puste:";
                    Text_2.Content = "Pozostaw puste:";
                    Text_4.Content = "Pozostaw puste:";
                    Text_3.Content = "Pozostaw puste:";
                    break;
                case "IC":
                    Tabela = x;
                    Quera = "INSERT INTO IC (Typ, Part_number, Stan, Obudowa, Napięcie) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4)";
                    Text_1.Content = "Obudowa:";
                    Text_2.Content = "Napięcie:";
                    Text_4.Content = "Pozostaw puste:";
                    Text_3.Content = "Pozostaw puste:";
                    break;

                default:

                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var x = Type.SelectedItem;
            if (x != null)
            {
                Typ = Typx.Text;
                Numer = Partx.Text;
                Stan = Stanx.Text;
                Spec1 = Spec1x.Text;
                Spec2 = Spec2x.Text;
                Spec3 = Spec3x.Text;
                Spec4 = Spec4x.Text;
                if (Numer == "")
                {
                    string messageBoxText = "Pole numer cześci nie może być pusty";
                    string caption = "Error";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    MessageBoxResult result;
                    result = MessageBox.Show(messageBoxText, caption, button, icon);
                }
                else
                {
                    DialogResult = true;
                    this.Close();
                }
            }
            else
            {
                string messageBoxText = "Musisz wybrać rodzaj";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }


    }
}
