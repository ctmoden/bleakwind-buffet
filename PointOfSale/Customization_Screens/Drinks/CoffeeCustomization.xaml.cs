using BleakwindBuffet.Data.Drinks;
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
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Customization_Screens.Drinks
{
    /// <summary>
    /// Interaction logic for CoffeeCustomization.xaml
    /// </summary>
    public partial class CoffeeCustomization : UserControl
    {
        CandlehearthCoffee coffee;
        public CoffeeCustomization(CandlehearthCoffee c)
        {
            InitializeComponent();
            coffee = c;
            DataContext = coffee;
        }
        /// <summary>
        /// Sets the size for the selected drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectSize(object sender, RoutedEventArgs e)
        {

            if (DataContext is Drink)
            {
                Size size = SizeSelectionMethod.DrinkSizeSelection(this, sender);
                coffee.Size = size;
            }
            else throw new NotImplementedException("Invalid type");
        }
        /// <summary>
        /// Returns to main menu screen to continue order process
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        void ReturnToMainMenu(object sender, RoutedEventArgs e)
        {
            ReturnToMenu.ReturnToMenuScreen(this);
        }
    }
}
