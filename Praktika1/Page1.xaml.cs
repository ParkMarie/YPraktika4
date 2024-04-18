using Praktika1.BookStoreDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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


namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        CustomersTableAdapter Customers = new CustomersTableAdapter();
        CustomersTableAdapter CustomerSurname = new CustomersTableAdapter();
        public Page1()
        {
            InitializeComponent();
            CustomersDataGrid.ItemsSource = Customers.GetData();
            ComboBox.ItemsSource = CustomerSurname.GetData();
            ComboBox.DisplayMemberPath = "CustomerSurname";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            CustomersDataGrid.ItemsSource = Customers.SearchBySurname(Search_window.Text);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                var ID_Customer = (int)(ComboBox.SelectedItem as DataRowView).Row[0];
                CustomersDataGrid.ItemsSource = Customers.FilterBySurname(ID_Customer);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CustomersDataGrid.ItemsSource = Customers.GetData();
        }
    }
}
