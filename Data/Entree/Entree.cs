/*
 * Author:  Christian Moden
 * Class: Entree.cs
 * Purpose: Super class for all entrees 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class for all entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
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
        /// <summary>
        /// Price property
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories property
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Property for special instrctions list 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// Entree description
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Name 
        /// </summary>
        public virtual string Name{ get => ToString(); }
    }
}
