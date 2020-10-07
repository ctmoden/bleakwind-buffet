/*
 * Author:  Christian Moden
 * Class: IOrderItem.cs.cs
 * Purpose: Interface for all items available to order 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for all items available to order
    /// </summary>
    public interface IOrderItem
    {
         
        /// <summary>
        /// Price property
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Calories Property
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Special instructions property
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
