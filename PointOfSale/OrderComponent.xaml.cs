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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        double total = 0.0;
        const double TaxRate = .0837;
        public OrderComponent()
        {
            InitializeComponent();
            UpdateTotal();
            UpdateSubTotal();
        }
        public void SwitchScreens(FrameworkElement element)
        {
            //pass in screen you want to change to
            menuControl.Child = element;
        }
        private void UpdateTotal()
        {
            //add to total based on user selection
            totalPrice.Text = total.ToString();
        }
        private void UpdateSubTotal()
        {
            //add to subtotal based on tax rate and total
            subTotalPrice.Text = ((total * TaxRate) + total).ToString();
        }

        private void UpdateTaxTotal()
        {
            taxPrice.Text = (total * TaxRate).ToString();
        }

    }
}
