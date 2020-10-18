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
            CashDrawerViewModel viewModel = new CashDrawerViewModel(order, "Card");
            string cardResult = viewModel.CardOperations();
            switch (cardResult)
            {
                case "Approved":
                    OrderComponent orderController = this.FindControl<OrderComponent>();
                    orderController.DataContext = new Order();
                    ReturnToMenu.ReturnToMenuScreen(this, new MenuSelection());
                    break;
                case "Declined":
                    MessageBox.Show(cardResult);
                    break;
                case "Insufficient Funds":
                    MessageBox.Show(cardResult);
                    break;
                case "Incorrect Pin":
                    MessageBox.Show(cardResult);
                    break;
                case "Read Error":
                    MessageBox.Show(cardResult);
                    break;
                default:
                    throw new NotImplementedException("Card Operation Not Recognized")

            }
                


        }
    }
}
