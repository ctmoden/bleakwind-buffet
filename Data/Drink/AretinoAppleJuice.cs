/*
 * Author: Christian Moden
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Apple juice drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// Calories Property, changes based on drink size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    InvokePropertyChange("Calories");
                    return 44;
                }
                if (Size == Size.Medium)
                {
                    InvokePropertyChange("Calories");
                    return 88;
                }
                else 
                {
                    InvokePropertyChange("Calories");
                    return 132;
                } 
            }
            
                
            
        }
        
        
        /// <summary>
        /// Price Property for juice.  Changes price based on size of drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    InvokePropertyChange("Price");
                    return .62;
                }
                if (Size == Size.Medium)
                {
                    InvokePropertyChange("Price");
                    return .87;
                }
                else
                {
                    InvokePropertyChange("Price");
                    return 1.01;
                }
            }
        }
        private bool ice = false;
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
            }
        }
        /// <summary>
        /// Special instructions list property tailored for this specific drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) 
                {
                    InvokePropertyChange("Special Instructions");
                    specialInstructions.Add("Add ice");
                } 
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Aretino Apple Juice");
        }
    }
}
