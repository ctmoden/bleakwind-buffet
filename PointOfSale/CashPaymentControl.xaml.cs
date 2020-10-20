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
        CashDrawerViewModel viewModel;
        public CashPaymentControl(Order o)
        {
            InitializeComponent();
            order = o;
            viewModel = new CashDrawerViewModel(order, "Cash");
            DataContext = viewModel;
            
        }
        /// <summary>
        /// return to menu to make any corrections before payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            //bubble back up tree to find control I want to display
            OrderComponent orderController = this.FindControl<OrderComponent>();
            orderController.DataContext = order;
            ReturnToMenu.ReturnToMenuScreen(this, new MenuSelection());

        }
        /// <summary>
        /// Prints receipt, starts a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FinalizeSale(object sender, RoutedEventArgs e)
        {
            viewModel.FinalizeOrder();
            OrderComponent orderController = this.FindControl<OrderComponent>();
            orderController.DataContext = new Order();
            ReturnToMenu.ReturnToMenuScreen(this, new MenuSelection());
            
        }
    }
}
