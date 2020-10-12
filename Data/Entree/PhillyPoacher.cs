/*
 * Author: Christian Moden
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher sandwich and it's properties
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
    {
        
        
        /// <summary>
        /// Price property for the sandwich. 
        /// Uses the shorthand method for a property
        /// </summary>
        public override double Price => 7.23;
        /// <summary>
        /// Property Gets the calories in the sandwich 
        /// </summary>
        public override uint Calories => 784;
        private bool sirloin = true;
        /// <summary>
        /// Property for Sirloin.  What kinda commie wouldn't want sirloin though???
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                InvokePropertyChange("Sirloin");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool onion = true;
        /// <summary>
        /// Property for Onion Presence
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                InvokePropertyChange("Onion");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool roll = true;
        /// <summary>
        /// Property for Roll presence
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                InvokePropertyChange("Roll");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        /// <summary>
        /// List property of special instructions specific to the philly sandwich.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin)
                {
                    specialInstructions.Add("Hold sirloin");
                    
                }
                if (!Onion)
                {
                    specialInstructions.Add("Hold onion");
                    
                }
                if (!Roll)
                {
                    specialInstructions.Add("Hold roll");
                    
                }
                return specialInstructions;
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
