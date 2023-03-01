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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Tabela)
            {
                case "Capacitors":
                    Typ = TypC.Text;
                    Numer = PartC.Text;
                    Stan = Stanc.Text;
                    Spec1 = SpecC1.Text;
                    Spec2 = SpecC2.Text;
                    Spec3 = SpecC3.Text;

                    break;
                case "Diodes":
                    Typ = TypD.Text;
                    Numer = PartD.Text;
                    Stan = StanD.Text;
                    Spec1 = SpecD1.Text;
                    Spec2 = SpecD2.Text;
                    Spec3 = SpecD3.Text;
                    Spec4 = SpecD4.Text;
                    break;
                case "Resistors":
                    Typ = TypR.Text;
                    Numer = PartR.Text;
                    Stan = StanR.Text;
                    Spec1 = SpecR1.Text;
                    Spec2 = SpecR2.Text;
                    Spec3 = SpecR3.Text;
                    break;
                default:

                    break;



            }
            
            


                
                DialogResult = true;
                this.Close();
            
        }

        
    }
}
