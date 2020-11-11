/*
 * Author: Christian Moden
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Apple juice drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the coffee drink and it's properties
    /// </summary>
    public class CandlehearthCoffee : Drink
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
                InvokePropertyChange("Calories");
                InvokePropertyChange("Price");
                InvokePropertyChange("Name");
            }
        }
        

        /// <summary>
        /// Calories Property, changes based on drink size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    
                    return 7;
                }
                if (Size == Size.Medium)
                {
                    
                    return 10;
                }
                else 
                {
                    
                    return 20;
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
                    
                    return .75;
                }
                if (Size == Size.Medium)
                {
                    
                    return 1.25;
                }
                else
                {
                    
                    return 1.75;
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
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool roomForCream = false;
        /// <summary>
        /// Cream property for coffee
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                InvokePropertyChange("RoomForCream");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool decaf = false;
        /// <summary>
        /// Decaf property for coffee
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                InvokePropertyChange("Decaf");
                InvokePropertyChange("SpecialInstructions");
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
                    
                    specialInstructions.Add("Add ice");
                }
                if (RoomForCream)
                {
                    
                    specialInstructions.Add("Add cream");
                }
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size, caffination, andname
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if (!Decaf) return ($"{Size} Candlehearth Coffee");
            else return ($"{Size} Decaf Candlehearth Coffee");

        }

        /// <summary>
        /// Description of coffee
        /// </summary>
        public override string Description => "Fair trade, fresh ground dark roast coffee.";
    }
}
