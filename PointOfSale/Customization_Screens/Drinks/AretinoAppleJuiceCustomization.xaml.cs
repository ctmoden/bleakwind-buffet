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
    /// Interaction logic for AretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl
    {
        AretinoAppleJuice aj;
        public AretinoAppleJuiceCustomization()
        {
            InitializeComponent();
            aj = new AretinoAppleJuice();
            DataContext = aj;
        }

        public void SelectSize(object sender, RoutedEventArgs e)
        {
            Size size = SizeSelectionMethod.SizeSelection(this, sender);
            aj.Size = size;
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
