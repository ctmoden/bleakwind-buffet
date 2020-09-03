/*
 * Author: Christian Moden
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth milk drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
                if (Size == Size.Small) return 56;
                if (Size == Size.Medium) return 72;
                else return 93;
            }
        }
        /// <summary>
        /// Backing variable for Price property
        /// </summary>
        public double price;
        /// <summary>
        /// Price Property for milk.  Changes price based on size of drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                if (Size == Size.Medium) return 1.11;
                else return 1.22;
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
                List<string> specialInstructions = new List<string>();
                if (Ice) specialInstructions.Add("Add ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides default ToString method with string specific to drink size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Markarth Milk");
        }

    }
}
