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

namespace Naprawa
{
    /// <summary>
    /// Logika interakcji dla klasy Usun_formularz.xaml
    /// </summary>
    public partial class Usun_formularz : Window
    {
        public string x { get; set; }
        public string y { get; set; }
        public string z { get; set; }
        public Usun_formularz()
        {
            InitializeComponent();
        }

        private void ok_Click_1(object sender, RoutedEventArgs e)
        {
            y = Input2.Text;
            z = Input3.Text;
            DialogResult = true;
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            x = selectedItem.Content.ToString();

        }
    }
}
