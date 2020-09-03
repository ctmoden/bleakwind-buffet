/*
 * Author: Christian Moden
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Apple juice drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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
                if (Size == Size.Small) return 7;
                if (Size == Size.Medium) return 10;
                else return 20;
            }
        }
        /// <summary>
        /// Backing variable for Price property
        /// </summary>
        public double price;
        /// <summary>
        /// Price Property for juice.  Changes price based on size of drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .75;
                if (Size == Size.Medium) return 1.25;
                else return 1.75;
            }
        }
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Cream property for coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Decaf property for coffee
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// Special instructions list property tailored for this specific drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) specialInstructions.Add("Add ice");
                if (RoomForCream) specialInstructions.Add("Add cream");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size, caffination, andname
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if (!Decaf) return ($"{Size} Candlehearth Coffee");
            else return ($"{Size} Decaf Candlehearth Coffee");

        }
    }
}
