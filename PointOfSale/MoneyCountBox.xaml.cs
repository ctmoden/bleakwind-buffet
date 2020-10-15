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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MoneyCountBox.xaml
    /// </summary>
    public partial class MoneyCountBox : UserControl
    {
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(MoneyCountBox));
        public MoneyCountBox()
        {
            InitializeComponent();
        }
        public int Value
        {
            get => (int)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
