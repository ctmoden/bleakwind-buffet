/*
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
        /// Calories Property, changes based on drink size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                else return 205;
            }
        }

        
        /// <summary>
        /// Price Property for soda.  Changes price based on size of drink
        /// </summary>
        public double Price 
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                else return 2.07;
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
