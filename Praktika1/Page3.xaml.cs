using Praktika1.BookStoreDataSetTableAdapters;
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
using System.Data;

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        OrdersTableAdapter Orders = new OrdersTableAdapter();
        OrdersTableAdapter OrderDate = new OrdersTableAdapter();
        public Page3()
        {
            InitializeComponent();
            OrdersDataGrid.ItemsSource = Orders.GetData();
            ComboBox.ItemsSource = OrderDate.GetData();
            ComboBox.DisplayMemberPath = "OrderDate";
        }

        private void Back_Click3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();

        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.ItemsSource = Orders.SearchBySurName(Search_window.Text);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.ItemsSource = Orders.GetData();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                var Customer_ID = (int)(ComboBox.SelectedItem as DataRowView).Row[0];
                OrdersDataGrid.ItemsSource = Orders.FilterBySurName(Customer_ID);
            }
        }
    }
}
