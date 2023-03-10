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
    /// Logika interakcji dla klasy Remove_Project.xaml
    /// </summary>
    public partial class Remove_Project : Window
    {
        public string Q { get; set; }
        public string P { get; set; }
        public string C { get; set; }
        public Remove_Project()
        {
            InitializeComponent();
            
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            P = Prj.Text;
            C = Prj.Text;

            DialogResult = true;
            this.Close();
        }

        private void Option_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string Ch = selectedItem.Content.ToString();
            switch (Ch)
            {
                case "Project":
                    Prj.Visibility = Visibility.Visible;
                    PRJ_NAME.Visibility = Visibility.Visible;
                    Comp.Visibility = Visibility.Collapsed;
                    Comp_Name.Visibility = Visibility.Collapsed;
                    Q = "DELETE FROM Projects WHERE Project_Name = @Value0";
                    break;
                case "Component":
                    Prj.Visibility = Visibility.Visible;
                    PRJ_NAME.Visibility = Visibility.Visible;
                    Comp.Visibility = Visibility.Visible;
                    Comp_Name.Visibility = Visibility.Visible;
                    Q = "DELETE FROM Projects WHERE Project_Name = @Value0 AND Part_number = @Value1";
                    break;
                default:

                    break;

            }
        }
    }
}
