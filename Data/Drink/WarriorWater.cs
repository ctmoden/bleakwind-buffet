/*
 * Author: Christian Moden
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink
    {
        
        private Size size = Size.Small;
        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size Size
        {
            get => size;
            set
            {
                size = value;
                InvokePropertyChange("Size");
                InvokePropertyChange("Name");
            }
        }
        
        /// <summary>
        /// Calories Property, 0 for all water sizes
        /// </summary>
        public override uint Calories => 0;
        /// <summary>
        /// Price Property for water, 0 for all sizes
        /// </summary>
        public override double Price => 0.00;
        private bool ice = true;
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                InvokePropertyChange("Ice");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool lemon = false;
        /// <summary>
        /// Lemon property
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                InvokePropertyChange("Lemon");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        /// <summary>
        /// Special instructions list property for water.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice)
                {
                    
                    specialInstructions.Add("Hold ice");
                }
                if (Lemon)
                {
                    
                    specialInstructions.Add("Add lemon");
                }
                return specialInstructions;
            }
        }
        /// <summary>
        /// Description of water
        /// </summary>
        public override string Description => "It's water.  Just water.";
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
