﻿/*
 * Author: Christian Moden
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Flavor property, default flavor is cherry.  Accesses Flavor enum
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        /// <summary>
        /// Size property for drink, accesses Size enum 
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Private backing variable for calories
        /// </summary>
        private uint calories;
        /// <summary>
        /// Calories Property, changes based on drink size
        /// </summary>
        public uint Calories
        {
            get => calories;
            set
            {
                if (Size == Size.Small) Calories = 117;
                if (Size == Size.Medium) Calories = 153;
                if (Size == Size.Large) Calories = 205;
            }
        }

        /// <summary>
        /// Backing variable for Price property
        /// </summary>
        public double price;
        /// <summary>
        /// Price Property for soda.  Changes price based on size of drink
        /// </summary>
        public double Price 
        {
            get => price;
            
            set
            {
                if (Size == Size.Small) price = 1.42;
                if (Size == Size.Medium) price = 1.74;
                if (Size == Size.Large) price = 2.07;
            }
        }
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Special instructions list property tailored for this specific drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruct = new List<string>();
                if (!Ice) instruct.Add("Hold ice");
                return instruct;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size, flavor, and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} {Flavor} Sailor Soda"); 
        }

    }


}
