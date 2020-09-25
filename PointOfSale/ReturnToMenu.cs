using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PointOfSale
{
    public static class ReturnToMenu
    {
        public static void ReturnToMenuScreen(FrameworkElement element)
        {
            MenuSelection menu = new MenuSelection();
            OrderComponent orderControl = element.FindControl<OrderComponent>();
            orderControl.SwitchScreens(menu);
        }
    }
}
