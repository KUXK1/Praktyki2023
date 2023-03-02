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
    /// Logika interakcji dla klasy Wydaj_formularz.xaml
    /// </summary>
    public partial class Wydaj_formularz : Window
    {
        public string project { get; set; }
        public string Hm { get; set; }
        public Wydaj_formularz()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            project = Projekt_name.Text;
            Hm = Projekt_hm.Text;
            DialogResult = true;
            this.Close();
        }
    }
}
