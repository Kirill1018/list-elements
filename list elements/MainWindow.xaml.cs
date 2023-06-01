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

namespace list_elements
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListView.ItemsSource = products;
        }

        private void editing_Click(object sender, RoutedEventArgs e)
        {
            Editing edit = new Editing();
            edit.Show();
        }

        List<Product> products = new List<Product>();
        private void addendum_Click(object sender, RoutedEventArgs e)
        {
            Product Product = new Product();
            Product.Name = name.Text;
            Product.Amount = Convert.ToInt32(amount.Text);
            Product.Meas_unit = meas_unit.ToString();
            products.Add(new Product() { Name = Product.Name, Amount = Product.Amount, Meas_unit = Product.Meas_unit });
        }
    }
}