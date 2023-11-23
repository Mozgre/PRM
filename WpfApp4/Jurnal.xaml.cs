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

namespace WpfApp4
{
    /// <summary> 
    /// Логика взаимодействия для Window4.xaml 
    /// </summary> 
    public partial class Jurnal : Window
    {
        public Jurnal()
        {
            InitializeComponent();
        }

        private void GroupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group chosegroup = GroupComboBox.SelectedItem as Group;
            peoplegroup.ItemsSource = chosegroup.Student;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GroupComboBox.ItemsSource = Singletone.DB.Group.ToList();


        }
    }
}
