﻿/*
 * Author: Christian Moden
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Maraak and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side
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
                    
                    return 151;
                }
                if (Size == Size.Medium)
                {
                    
                    return 236;
                }
                else
                {
                    
                    return 306;
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
                    
                    return 1.78;
                }
                if (Size == Size.Medium)
                {
                    
                    return 2.01;
                }
                else
                {
                    
                    return 2.88;
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
        /// Description of fried miraak
        /// </summary>
        public override string Description => "Perfectly prepared hash brown pancakes.";
        /// <summary>
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Fried Miraak");
        }
    }
}
