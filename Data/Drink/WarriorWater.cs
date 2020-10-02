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
    public class WarriorWater : Drink, INotifyPropertyChanged
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        public void InvokePropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                    InvokePropertyChange("Special Instructions");
                    specialInstructions.Add("Hold ice");
                }
                if (Lemon)
                {
                    InvokePropertyChange("Special Instructions");
                    specialInstructions.Add("Add lemon");
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
            return ($"{Size} Warrior Water");
        }

    }
}
