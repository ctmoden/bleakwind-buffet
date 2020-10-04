using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Drinks;
using System.Windows.Controls;

namespace PointOfSale
{
    public static class SizeSelectionMethod
    {
        /// <summary>
        /// Returns appropriate size based on which size button is selected
        /// </summary>
        /// <param name="element">current customization screen</param>
        /// <param name="sender">object that sent event we are handling, in this case a button</param>
        /// <returns></returns>
        public static Size DrinkSizeSelection(FrameworkElement element, object sender)
        {
            if (sender is Button b)
            {
                switch (b.Name)
                {
                    case "smallButton":
                        return Size.Small;
                    case "mediumButton":
                        return Size.Medium;
                    case "largeButton":
                        return Size.Large;
                    default:
                        throw new NotImplementedException("Invalid size");
                }   
            }
            else throw new NotImplementedException("Invalid button");
                
            
        }
    }
}
