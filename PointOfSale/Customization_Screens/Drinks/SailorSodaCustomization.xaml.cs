using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        SailorSoda soda;
        public SailorSodaCustomization(SailorSoda s)
        {
            InitializeComponent();
            soda = s;
            DataContext = soda;
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
                soda.Size = size;
            }
            else throw new NotImplementedException("Invalid type");
        }

        public void ChangeFlavor(object sender, RoutedEventArgs e)
        {
            if(DataContext is Drink)
            {
                
                if(sender is RadioButton rb)
                {
                    switch (rb.Name)
                    {
                        case "blackberry":
                            soda.Flavor = SodaFlavor.Blackberry;
                            break;
                        case "cherry":
                            soda.Flavor = SodaFlavor.Cherry;
                            break;
                        case "grapefruit":
                            soda.Flavor = SodaFlavor.Grapefruit;
                            break;
                        case "lemon":
                            soda.Flavor = SodaFlavor.Lemon;
                            break;
                        case "peach":
                            soda.Flavor = SodaFlavor.Peach;
                            break;
                        case "watermelon":
                            soda.Flavor = SodaFlavor.Watermelon;
                            break;
                        default:
                            throw new NotImplementedException("Invalid flavor");
                    }
                }
            }
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
