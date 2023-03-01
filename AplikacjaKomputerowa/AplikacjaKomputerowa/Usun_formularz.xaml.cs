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
    public partial class Usun_formularz : Window
    {
        public string x { get; set; }
        public string y { get; set; }
        public Usun_formularz()
        {
            InitializeComponent();
        }
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ok_Click_1(object sender, RoutedEventArgs e)
        {

            
            y = Input2.Text;
            

            // Zamykanie okna dialogowego z wartością true, jeśli OK zostało kliknięte
            DialogResult = true;
            this.Close();
        }

        private void Radio1_Checked(object sender, RoutedEventArgs e)
        {
            x = "capacitors";
        }
        private void Radio2_Checked(object sender, RoutedEventArgs e)
        {
            x = "Diodes";
        }
        private void Radio3_Checked(object sender, RoutedEventArgs e)
        {
            x = " resistors";
        }
    }
}
