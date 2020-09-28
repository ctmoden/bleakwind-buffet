using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PointOfSale
{
    /// <summary>
    /// returns to the menu screen from a customization screen
    /// </summary>
    public static class ReturnToMenu
    {
        /// <summary>
        /// Finds the elements parent control and switches screens 
        /// </summary>
        /// <param name="element"></param>
        public static void ReturnToMenuScreen(FrameworkElement element)
        {
            MenuSelection menu = new MenuSelection();
            OrderComponent orderControl = element.FindControl<OrderComponent>();
            orderControl.SwitchScreens(menu);
        }
    }
}
