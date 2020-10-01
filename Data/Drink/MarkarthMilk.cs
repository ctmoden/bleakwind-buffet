/*
 * Author: Christian Moden
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth milk drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        public void InvokePropertyChange(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                    InvokePropertyChange("Calories");
                    return 56;
                }
                if (Size == Size.Medium)
                {
                    InvokePropertyChange("Calories");
                    return 72;
                }
                else
                {
                    InvokePropertyChange("Calories");
                    return 93;
                }
            }
        }
        /// <summary>
        /// Price Property for milk.  Changes price based on size of drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    InvokePropertyChange("Price");
                    return 1.05;
                }
                if (Size == Size.Medium)
                {
                    InvokePropertyChange("Price");
                    return 1.11;
                }
                else
                {
                    InvokePropertyChange("Price");
                    return 1.22;
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
            return ($"{Size} Markarth Milk");
        }

    }
}
