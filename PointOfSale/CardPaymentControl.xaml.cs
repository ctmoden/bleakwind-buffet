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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CardPaymentControl.xaml
    /// </summary>
    public partial class CardPaymentControl : UserControl
    {
        Order order;
        public CardPaymentControl(Order o)
        {
            InitializeComponent();
            order = o;

            DataContext = new CashDrawerViewModel(order, "Card");
        }
    }
}
