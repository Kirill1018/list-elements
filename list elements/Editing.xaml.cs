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

namespace list_elements
{
    /// <summary>
    /// Логика взаимодействия для Editing.xaml
    /// </summary>
    public partial class Editing : Window
    {
        public Editing()
        {
            InitializeComponent();
        }
        Product goods;
        private void proofreading_Click(object sender, RoutedEventArgs e)
        {
            goods = new Product();
            goods.Name = title.Text;
            goods.Amount = Convert.ToInt32(quantity.Text);
            goods.Meas_unit = unit.Text;
        }
    }
}