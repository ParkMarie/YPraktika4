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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        OrderInfoTableAdapter OrderInfo = new OrderInfoTableAdapter();
        BooksTableAdapter NameOfBook = new BooksTableAdapter();
        public Page4()
        {
            InitializeComponent();
            OrderInfoDataGrid.ItemsSource = OrderInfo.GetData();
            ComboBox.ItemsSource = NameOfBook.GetData();
            ComboBox.DisplayMemberPath = "NameOfBook";
        }

        private void Back_Click4(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();

        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            OrderInfoDataGrid.ItemsSource = OrderInfo.SearchByNBook(Search_window.Text);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            OrderInfoDataGrid.ItemsSource = OrderInfo.GetData();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                var Book_ID = (int)(ComboBox.SelectedItem as DataRowView).Row[0];
                OrderInfoDataGrid.ItemsSource = OrderInfo.FilterByNBook(Book_ID);
            }
        }
    }
}
