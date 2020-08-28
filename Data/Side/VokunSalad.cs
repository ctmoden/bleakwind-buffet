/*
 * Author: Christian Moden
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// Size property for the size
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        
        /// <summary>
        /// Calories Property, changes based on salad size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                else return 73;
            }
        }
        
        /// <summary>
        /// Price Property for salad.  Changes price based on size of drinksalad
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .93;
                if (Size == Size.Medium) return 1.28;
                else return 1.82;
            }
        }
        /// <summary>
        /// List of special instructions for the side.  Always empty
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                return list;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Vokun Salad");
        }
    }
}
