﻿/*
 * Author: Christian Moden
 * Class name: GardenOrcOmlettte.cs
 * Purpose: Class used to represent the Garden Orc Omlette breakfast and it's properties
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
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
        /// Price property for the omlette. 
        /// Uses the shorthand method for a property
        /// </summary>
        public override double Price => 4.57;
        /// <summary>
        /// Property Gets the calories in the breakfast 
        /// </summary>
        public override uint Calories => 404;
        private bool broccoli = true; 
        /// <summary>
        /// Property for Broccoli.  T/F values
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                InvokePropertyChange("Broccoli");
            }
        }
        private bool mushrooms = true;
        /// <summary>
        /// Property for Mushrooms.  T/F values
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                InvokePropertyChange("Mushrooms");
            }
        }
        private bool tomato = true;
        /// <summary>
        /// Property for Tomatos.  T/F values
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                InvokePropertyChange("Tomato");
            }
        }
        private bool cheddar = true;
        /// <summary>
        /// Cheddar property.  T/F values.
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                InvokePropertyChange("Cheddar");
            }
        }
        /// <summary>
        /// List property of special instruction specific to omlette.  Creates a new list each time new instruction needs to be added.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Broccoli)
                {
                    specialInstructions.Add("Hold broccoli");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Mushrooms)
                {
                    specialInstructions.Add("Hold mushrooms");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Tomato)
                {
                    specialInstructions.Add("Hold tomato");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Cheddar)
                {
                    specialInstructions.Add("Hold cheddar");
                    InvokePropertyChange("Special Instructions");
                }
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrirdes base ToString method and replaces return string with omlette name.
        /// </summary>
        /// <returns>"Gardern Orc Omlette" string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
