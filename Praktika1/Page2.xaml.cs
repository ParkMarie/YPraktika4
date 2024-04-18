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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        BooksTableAdapter Books = new BooksTableAdapter();
        BooksTableAdapter Author = new BooksTableAdapter();
        public Page2()
        {
            InitializeComponent();
            BooksDataGrid.ItemsSource = Books.GetData();
            ComboBox.ItemsSource = Author.GetData();
            ComboBox.DisplayMemberPath = "Author";
        }

        private void Back_Click2(object sender, RoutedEventArgs e)
        {
           MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
            
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            BooksDataGrid.ItemsSource = Books.SearchByAuthor(Search_window.Text);

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            BooksDataGrid.ItemsSource = Books.GetData();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                var ID_Book = (int)(ComboBox.SelectedItem as DataRowView).Row[0];
                BooksDataGrid.ItemsSource = Books.FilterByAuthor(ID_Book);
            }
        }
    }
}
