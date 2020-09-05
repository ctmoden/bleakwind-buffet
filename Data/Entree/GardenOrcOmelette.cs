/*
 * Author: Christian Moden
 * Class name: GardenOrcOmlettte.cs
 * Purpose: Class used to represent the Garden Orc Omlette breakfast and it's properties
 */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Price property for the omlette. 
        /// Uses the shorthand method for a property
        /// </summary>
        public double Price => 4.57;
        /// <summary>
        /// Property Gets the calories in the breakfast 
        /// </summary>
        public uint Calories => 404;
        /// <summary>
        /// Property for Broccoli.  T/F values
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Property for Mushrooms.  T/F values
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// Property for Tomatos.  T/F values
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Cheddar property.  T/F values.
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// List property of special instruction specific to omlette.  Creates a new list each time new instruction needs to be added.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrirdes base ToString method and replaces return string with omlette name.
        /// </summary>
        /// <returns>"Gardern Orc Omlette" string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
