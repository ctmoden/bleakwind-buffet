/*
 * Author:  Christian Moden
 * Class: Side.cs
 * Purpose: Super class for all sides 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Base class for all sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        public abstract Size Size { get; set; }
        /// <summary>
        /// Price property
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories property
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions list property
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
