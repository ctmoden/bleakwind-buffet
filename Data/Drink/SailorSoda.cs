﻿/*
 * Author: Christian Moden
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink and it's properties
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, INotifyPropertyChanged
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
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Flavor property, default flavor is cherry.  Accesses Flavor enum
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                InvokePropertyChange("Flavor");
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
                    InvokePropertyChange("Calories");
                    return 117;
                }
                if (Size == Size.Medium) return 153;
                else return 205;
            }
        }

        
        /// <summary>
        /// Price Property for soda.  Changes price based on size of drink
        /// </summary>
        public override double Price 
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                else return 2.07;
            }
        }
        /// <summary>
        /// Ice property for the drink
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Special instructions list property tailored for this specific drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Hold ice");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides default ToString method with string specific to drink size, flavor, and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ($"{Size} {Flavor} Sailor Soda"); 
        }

    }


}
