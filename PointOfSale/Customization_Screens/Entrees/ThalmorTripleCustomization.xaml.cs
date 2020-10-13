using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ThalmorTripleCustomization.xaml
    /// </summary>
    public partial class ThalmorTripleCustomization : UserControl
    {
        ThalmorTriple triple;
        MenuSelection menu;
        public ThalmorTripleCustomization(MenuSelection m, ThalmorTriple t)
        {
            InitializeComponent();
            triple = t;
            menu = m;
            DataContext = triple;
        }
        /// <summary>
        /// Returns to main menu screen to continue order process
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        void ReturnToMainMenu(object sender, RoutedEventArgs e)
        {
            ReturnToMenu.ReturnToMenuScreen(this,menu);
        }
    }
}
