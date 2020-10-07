/*
 * Author:  Christian Moden
 * Class: Drink.cs
 * Purpose: Super class for all drinks 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Abstract class for all drinks, cannot create an instance of this class alone.
    /// Base class representing common properties for drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        protected void InvokePropertyChange(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //protected abstract void InvokePropertyChange(string propertyName);

        /// <summary>
        /// price of the drink
        /// </summary>
        /// <value>
        /// US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// list of special instruction for particular drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
