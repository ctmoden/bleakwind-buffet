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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToMainMenu(object sender, RoutedEventArgs e)
        {
            ReturnToMenu.ReturnToMenuScreen(this, menu);
        }
        /// <summary>
        /// switch screen to cash payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CashPayment(object sender, RoutedEventArgs e)
        {
            controllerBorder.Child = new CashPaymentControl(order);
            //switch to cash payment screen
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CardPayment(object sender, RoutedEventArgs e)
        {
            //switch screens, even if it is something simple
            //controllerBorder.Child = new CardPaymentControl(order);
            //dont switch screens, create new cashdrawer view model, 
            //update change given for a car to be explicitly 0

        }
    }
}
