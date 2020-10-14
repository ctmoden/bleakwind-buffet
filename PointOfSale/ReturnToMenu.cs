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
        //static MenuSelection menu;
        /// <summary>
        /// Finds the elements parent control and switches screens 
        /// </summary>
        /// <param name="element"></param>
        public static void ReturnToMenuScreen(FrameworkElement element, MenuSelection menu)
        {           
            OrderComponent orderControl = element.FindControl<OrderComponent>();
            orderControl.SwitchScreens(menu);//make sure you are only changing uppermost border.
        }
    }
}
