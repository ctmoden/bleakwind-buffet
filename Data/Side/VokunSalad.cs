/*
 * Author: Christian Moden
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad and it's properties
 *FIXME need to modify properties to throw not implemented exception for size/flavors as needed.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side
    {
        
        private Size size = Size.Small;
        /// <summary>
        /// Size of the drink
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                InvokePropertyChange("Size");
                InvokePropertyChange("Calories");
                InvokePropertyChange("Price");
                InvokePropertyChange("Name");
            }
        }

        /// <summary>
        /// Calories Property, changes based on salad size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    
                    return 41;
                }
                if (Size == Size.Medium)
                {
                    
                    return 52;
                }
                else
                {
                    
                    return 73;
                }
            }
        }
        
        /// <summary>
        /// Price Property for salad.  Changes price based on size of drinksalad
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    
                    return .93;
                }
                if (Size == Size.Medium)
                {
                    
                    return 1.28;
                }
                else
                {
                    
                    return 1.82;
                }
            }
        }
        /// <summary>
        /// List of special instructions for the side.  Always empty
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }
        /// <summary>
        /// Description of vokun salad
        /// </summary>
        public override string Description => "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
        /// <summary>
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Vokun Salad");
        }
    }
}
