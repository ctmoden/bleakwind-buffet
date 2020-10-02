﻿/*
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
    public class VokunSalad : Side, INotifyPropertyChanged
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
        /// Calories Property, changes based on salad size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    InvokePropertyChange("Calories");
                    return 41;
                }
                if (Size == Size.Medium)
                {
                    InvokePropertyChange("Calories");
                    return 52;
                }
                else
                {
                    InvokePropertyChange("Calories");
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
                    InvokePropertyChange("Price");
                    return .93;
                }
                if (Size == Size.Medium)
                {
                    InvokePropertyChange("Price");
                    return 1.28;
                }
                else
                {
                    InvokePropertyChange("Price");
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
        /// Overrides default ToString method with string specific to side size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} Vokun Salad");
        }
    }
}
