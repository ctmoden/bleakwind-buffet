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
    /// Interaction logic for PaymentSelectionControl.xaml
    /// </summary>
    public partial class PaymentSelectionControl : UserControl
    {
        MenuSelection menu;
        Order order;
        public PaymentSelectionControl(MenuSelection m, Order o)
        {

            InitializeComponent();
            menu = m;
            order = o;
        }

        void ReturnToMainMenu(object sender, RoutedEventArgs e)
        {
            ReturnToMenu.ReturnToMenuScreen(this, menu);
        }
    }
}
