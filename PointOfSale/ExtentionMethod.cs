using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;
namespace PointOfSale
{
    /// <summary>
    /// Implements a method to find the parent control when user is in a nested 
    /// </summary>
    public static class ExtentionMethod
    {
        /// <summary>
        /// Finds Ancestor control desired to be switched to 
        /// </summary>
        /// <typeparam name="T">Template Type </typeparam>
        /// <param name="element">framework element</param>
        /// <returns></returns>
        public static T FindControl<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            if (parent == null) return null;
            if (parent is T) return parent as T;
            return parent.FindControl<T>();
        }
    }
}
