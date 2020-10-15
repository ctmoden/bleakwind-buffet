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
using BleakwindBuffet.Data.Order;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        Order order;
        public OrderComponent()
        {
            InitializeComponent();
            order = new Order();
            DataContext = order;
        }
        public void SwitchScreens(FrameworkElement element)
        {
            //pass in screen you want to change to
            menuControl.Child = element;
        }
        /// <summary>
        /// clears order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClearOrderItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                
                int index = itemsListView.SelectedIndex; 
                order.Remove(order[index]);
                
                //how to find index of one I want to remove?
                //need a reference to the item that needs to be deleted
            }
        }

        public void CancelOrder(object sender, RoutedEventArgs e)
        {
            
            order = new Order();
            DataContext = order;
            
        }
        /// <summary>
        /// Sends user to the payment screen.  Could leave order details in screen 
        /// (as if switching between menu selection and customization screens)
        /// look at SendToScreenSwitcher method in Menu selection for guidance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteOrder(object sender, RoutedEventArgs e)
        {

        }
        

    }
}
