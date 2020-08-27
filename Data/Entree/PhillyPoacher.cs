/*
 * Author: Christian Moden
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher sandwich and it's properties
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Price property for the sandwich. 
        /// Uses the shorthand method for a property
        /// </summary>
        public double Price => 7.23;
        /// <summary>
        /// Property Gets the calories in the sandwich 
        /// </summary>
        public uint Calories => 784;
        /// <summary>
        /// Property for Sirloin presence.
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Property for Onion Presence
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Property for Roll presence
        /// </summary>
        public bool Roll { get; set; } = true;
        /// <summary>
        /// List property of special instructions specific to the philly sandwich.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruct = new List<string>();
                if (!Sirloin) instruct.Add("Hold sirloin");
                if (!Onion) instruct.Add("Hold onion");
                if (!Roll) instruct.Add("Hold roll");
                return instruct;
            }
        }
        /// <summary>
        /// Overrirdes default ToString method to return string specific to class
        /// </summary>
        /// <returns>"Philly Poacher" string</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
