/*
 * Author: Christian Moden
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Apple juice drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Size property for the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        
        /// <summary>
        /// Calories Property, changes based on drink size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                else return 132;
            }
        }
        
        /// <summary>
        /// Price Property for juice.  Changes price based on size of drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .62;
                if (Size == Size.Medium) return .87;
                else return 1.01;
            }
        }
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Special instructions list property tailored for this specific drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruct = new List<string>();
                if (Ice) instruct.Add("Add ice");
                return instruct;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Aretino Apple Juice");
        }
    }
}
