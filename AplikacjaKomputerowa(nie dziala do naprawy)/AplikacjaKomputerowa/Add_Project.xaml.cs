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
    
    public partial class Add_Project : Window
    {
        public string Prj_name { get; set; }
        public string Prj_type { get; set; }
        public string Prj_comp  { get; set; }
        public string Prj_q { get; set; }
        public string Prj_c { get; set; }
    
        public Add_Project()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Prj_name = Prj_Name.Text;
            Prj_comp = Part.Text;
            Prj_q = Quantity.Text;
            Prj_c = Comment.Text;

            DialogResult = true;
            this.Close();
        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            Prj_type = selectedItem.Content.ToString();
        }
    }
}
