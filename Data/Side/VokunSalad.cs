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
        /// Private backing variable for calories
        /// </summary>
        private uint calories;
        /// <summary>
        /// Calories Property, changes based on salad size
        /// </summary>
        public uint Calories
        {
            get => calories;
            set
            {
                if (Size == Size.Small) Calories = 41;
                if (Size == Size.Medium) Calories = 52;
                if (Size == Size.Large) Calories = 73;
            }
        }
        /// <summary>
        /// Backing variable for Price property
        /// </summary>
        public double price;
        /// <summary>
        /// Price Property for salad.  Changes price based on size of drinksalad
        public double Price
        {
            get => price;

            set
            {
                if (Size == Size.Small) price = .93;
                if (Size == Size.Medium) price = 1.28;
                if (Size == Size.Large) price = 1.82;
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
