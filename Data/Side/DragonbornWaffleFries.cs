/*
 * Author: Christian Moden
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Vokun Salad and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Size property for the size
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Calories Property, changes based on side size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                if (Size == Size.Medium) return 89;
                else return 100;               
            }
        }
        
        /// <summary>
        /// Price Property for side.  Changes price based on size of side
        public double Price
        {
            get
            {
                if (Size == Size.Small) return.42;
                if (Size == Size.Medium) return .76;
                else return .96;
            }
        }
        /// <summary>
        /// List of special instructions for the side.  Always empty
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Dragonborn Waffle Fries");
        }
    }
}
