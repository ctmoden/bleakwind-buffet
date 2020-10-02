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

namespace PointOfSale.Customization_Screens.Drinks
{
    /// <summary>
    /// Interaction logic for CoffeeCustomization.xaml
    /// </summary>
    public partial class CoffeeCustomization : UserControl
    {
        CandlehearthCoffee coffee;
        public CoffeeCustomization()
        {
            InitializeComponent();
            coffee = new CandlehearthCoffee();
            DataContext = coffee;
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
