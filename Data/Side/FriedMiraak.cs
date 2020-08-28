/*
 * Author: Christian Moden
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Maraak and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Size property for the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Private backing variable for calories
        /// </summary>
        private uint calories;
        /// <summary>
        /// Calories Property, changes based on side size
        /// </summary>
        public uint Calories
        {
            get => calories;
            set
            {
                if (Size == Size.Small) Calories = 151;
                if (Size == Size.Medium) Calories = 236;
                if (Size == Size.Large) Calories = 306;
            }
        }
        /// <summary>
        /// Backing variable for Price property
        /// </summary>
        public double price;
        /// <summary>
        /// Price Property for side.  Changes price based on size of side
        public double Price
        {
            get => price;

            set
            {
                if (Size == Size.Small) price = 1.78;
                if (Size == Size.Medium) price = 2.01;
                if (Size == Size.Large) price = 2.88;
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
            return ($"{Size} Fried Miraak");
        }
    }
}
