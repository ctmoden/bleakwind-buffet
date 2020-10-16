using BleakwindBuffet.Data;
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
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {
        
        Order order;
        public CashPaymentControl(Order o)
        {
            InitializeComponent();
            order = o;
            DataContext = new CashDrawerViewModel(order);//do I send order details here too?  I am thinking yes
            
        }

        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            //bubble back up tree to find control I want to display

        }

        void FinalizeSale(object sender, RoutedEventArgs e)
        {
            //invoke receipt method defined in 
        }
    }
}
