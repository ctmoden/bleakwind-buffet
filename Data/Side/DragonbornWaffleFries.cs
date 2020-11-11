/*
 * Author: Christian Moden
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Vokun Salad and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side
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
        /// Calories Property, changes based on side size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    
                    return 77;
                }
                if (Size == Size.Medium)
                {
                    
                    return 89;
                }
                else
                {
                    
                    return 100;
                }
            }
        }
        
        /// <summary>
        /// Price Property for side.  Changes price based on size of side
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    
                    return .42;
                }
                if (Size == Size.Medium)
                {
                    
                    return .76;
                }
                else
                {
                    
                    return .96;
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
        /// Description of fries
        /// </summary>
        public override string Description => "Crispy fried potato waffle fries.";
        /// <summary>
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Dragonborn Waffle Fries");
        }
    }
}
