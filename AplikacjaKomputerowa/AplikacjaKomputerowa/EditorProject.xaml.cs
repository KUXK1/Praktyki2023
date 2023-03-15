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
    /// Logika interakcji dla klasy EditorProject.xaml
    /// </summary>
    public partial class EditorProject : Window
    {
        public string Q { get; set; }
        public string N { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public string S3 { get; set; }
        public EditorProject()
        {
            InitializeComponent();
            NameB.Visibility = Visibility.Collapsed;
            NameL.Visibility = Visibility.Collapsed;
            ChB1.Visibility = Visibility.Collapsed;
            ChB2.Visibility = Visibility.Collapsed;
            ChL1.Visibility = Visibility.Collapsed;
            ChL2.Visibility = Visibility.Collapsed;
            ChB3.Visibility = Visibility.Collapsed;
            ChL3.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            N = NameB.Text;
            S1 = ChB1.Text;
            S2 = ChB2.Text;
            S3 = ChB3.Text;
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
                case "Rename_Project":
                    NameB.Visibility = Visibility.Visible;
                    NameL.Visibility = Visibility.Visible;
                    ChB1.Visibility = Visibility.Visible;
                    ChB2.Visibility = Visibility.Collapsed;
                    ChL1.Visibility = Visibility.Visible;
                    ChL2.Visibility = Visibility.Collapsed;
                    ChB3.Visibility = Visibility.Collapsed;
                    ChL3.Visibility = Visibility.Collapsed;
                    NameL.Content = "Old Name";
                    ChL1.Content = "New name";
                    Q = "UPDATE Projects SET Project_Name = @Value0 WHERE Project_Name = @Value1";
                    break;
                case "Edit_Conponent":
                    NameB.Visibility = Visibility.Visible;
                    NameL.Visibility = Visibility.Visible;
                    ChB1.Visibility = Visibility.Visible;
                    ChB2.Visibility = Visibility.Visible;
                    ChB3.Visibility = Visibility.Visible;
                    ChL1.Visibility = Visibility.Visible;
                    ChL2.Visibility = Visibility.Visible;
                    ChL3.Visibility = Visibility.Visible;
                    NameL.Content = "Project name";
                    ChL1.Content = "Component number";
                    Q = "";
                    break;
                default:

                    break;
            }
        }
    }
}
