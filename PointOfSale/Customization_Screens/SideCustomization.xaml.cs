using BleakwindBuffet.Data.Sides;
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
//any time size is used, it refers to enum defined in project
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Customization_Screens
{
    /// <summary>
    /// Interaction logic for SideCustomization.xaml
    /// </summary>
    public partial class SideCustomization : UserControl
    {
        
        public SideCustomization(object obj)
        {
            InitializeComponent();
            DataContext = obj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">routed to trace back to ancestor</param>
        private void SelectSize(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                Size size = b.Name switch
                {
                    "smallButton" => Size.Small,
                    "mediumButton" => Size.Medium,
                    "largeButton" => Size.Large,
                    _ => throw new NotImplementedException("Invalid size button selected"),
                };
                if (DataContext is Side side) side.Size = size;
                
                else throw new NotImplementedException("Invalid item type");
                
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
