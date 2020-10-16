using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MoneyCountBox.xaml
    /// </summary>
    public partial class MoneyCountBox : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(MoneyCountBox),
            new FrameworkPropertyMetadata(0,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        //one way binding by default=data bound to display, gui cannot update, twoway can display and update
        public MoneyCountBox()
        {
            InitializeComponent();
        }
        public int Value
        {
            get => (int)GetValue(ValueProperty);
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
                SetValue(ValueProperty, value);
            }
        }

        void IncrementButton(object sender, RoutedEventArgs e)
        {
            Value++;
            e.Handled = true;
        }
        void DecrementButton(object sender, RoutedEventArgs e)
        {
            if(Value>0) Value--;
            e.Handled = true;
        }
    }
}
