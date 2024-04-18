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
using Praktika1.BookStoreDataSetTableAdapters;

namespace Praktika1
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
       
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FirstPage.Content = new Page1(); 
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SecondPage.Content = new Page2();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ThirdPage.Content = new Page3();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
           FourPage.Content = new Page4();
        }

        private void FourPage_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
