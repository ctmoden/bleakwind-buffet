using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    public static class SizeSelectionMethod
    {
        public static Size SizeSelection(FrameworkElement element, object sender)
        {
            return Size.Small;
                
        }
    }
}
