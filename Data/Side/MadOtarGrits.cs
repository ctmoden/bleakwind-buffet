/*
 * Author: Christian Moden
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
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
                    
                    return 105;
                }
                if (Size == Size.Medium)
                {
                    
                    return 142;
                }
                else
                {
                    
                    return 179;
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
                    
                    return 1.22;
                }
                if (Size == Size.Medium)
                {
                    
                    return 1.58;
                }
                else
                {
                    
                    return 1.93;
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
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Mad Otar Grits");
        }
    }
}
