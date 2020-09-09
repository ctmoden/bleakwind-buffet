using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class for all entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Price property
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories property
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Property for special instrctions list 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
