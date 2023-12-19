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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace control19._12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frameClick.Content = new Buyer();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frameClick.Content = new stamps();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frameClick.Content = new staff();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frameClick.Content = new avto();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frameClick.Content = new sales();
        }
    }
}
