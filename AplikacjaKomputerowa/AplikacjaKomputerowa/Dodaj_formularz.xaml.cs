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
        private void Radio1_Checked(object sender, RoutedEventArgs e)
        {
            Tabela = "Capacitors";
            Quera = "INSERT INTO Capacitors (Typ, Part_number, Stan, Pojemnosc, Tolerancja, Napiecie) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5)";
        }
        private void Radio2_Checked(object sender, RoutedEventArgs e)
        {
            Tabela = "Resistors";
            Quera = "INSERT INTO Resistors (Typ, Part_number, Stan, Rezystancja, Tolerancja, Moc) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5)";
        }
        private void Radio3_Checked(object sender, RoutedEventArgs e)
        {
            Tabela = "Diodes";
            Quera = "INSERT INTO Diodes (Typ, Part_number, Stan, Napiecie, Prąd, Kolor, Moc) VALUES (@Value0, @Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
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
                default:

                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Typ = Typx.Text;
            Numer = Partx.Text;
            Stan = Stanx.Text;
            Spec1 = Spec1x.Text;
            Spec2 = Spec2x.Text;
            Spec3 = Spec3x.Text;
            Spec4 = Spec4x.Text;
            DialogResult = true;
            this.Close();
            
        }


    }
}
