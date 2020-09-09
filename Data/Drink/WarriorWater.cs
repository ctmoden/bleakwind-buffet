/*
 * Author: Christian Moden
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink
    {
           
        /// <summary>
        /// Calories Property, 0 for all water sizes
        /// </summary>
        public override uint Calories => 0;
        /// <summary>
        /// Price Property for water, 0 for all sizes
        /// </summary>
        public override double Price => 0.00;
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Lemon property
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Special instructions list property for water.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Hold ice");
                if (Lemon) specialInstructions.Add("Add lemon");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Warrior Water");
        }

    }
}
