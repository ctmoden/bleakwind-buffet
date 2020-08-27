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
        /// FIXME not complete
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Backing variable for Price property
        /// </summary>
        public double price;
        /// <summary>
        /// Price Property for soda
        /// </summary>
        public double Price 
        {
            get => price;
            
            set
            {
                if(Size == Size.Small)
                {
                    price = 1.42;
                    Calories = 117;
                }
                //FIXME need to finish
            }
        }
        
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice { get; set; } = false;

    }


}
