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
    public class WarriorWater
    {
        /// <summary>
        /// Size property for the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;      
        /// <summary>
        /// Calories Property, 0 for all water sizes
        /// </summary>
        public uint Calories => 0;
        /// <summary>
        /// Price Property for water, 0 for all sizes
        /// </summary>
        public double Price => 0.00;
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruct = new List<string>();
                if (!Ice) instruct.Add("Hold ice");
                if (Lemon) instruct.Add("Add lemon");
                return instruct;
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
