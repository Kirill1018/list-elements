using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace list_elements
{
    public enum Unit { gram, milliliter, thing }
    public class Product : INotifyPropertyChanged, IValueConverter
    {
        private string name_text, text_of_meas_unit;//название и единица измерения
        private int amount_text;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Product()
        {
            this.Name = string.Empty;
            this.Amount = 0;//исходное значение количества
            this.Meas_unit = string.Empty;
        }
        public string Name
        {
            get
            {
                return this.name_text;
            }
            set
            {
                this.name_text = value;
                this.On_prop_chang();
            }
        }
        public int Amount
        {
            get
            {
                return this.amount_text;
            }
            set
            {
                this.amount_text = value;
                this.On_prop_chang();
            }
        }
        public string Meas_unit
        {
            get
            {
                return this.text_of_meas_unit;
            }
            set
            {
                this.text_of_meas_unit = value;
                this.On_prop_chang();
            }
        }
        public void On_prop_chang([CallerMemberName]string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Unit[] units = { Unit.gram, Unit.thing, Unit.milliliter };
            Name = units[0].ToString();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}