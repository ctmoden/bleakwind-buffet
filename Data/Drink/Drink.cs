using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Abstract class for all drinks, cannot create an instance of this class alone.
    /// Base class representing common properties for drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Size of the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// price of the drink
        /// </summary>
        /// <value>
        /// US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// list of special instruction for particular drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
