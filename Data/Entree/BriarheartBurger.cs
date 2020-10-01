/*
 * Author: Christian Moden
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart burger and it's properties
 * FIXME create a class with all of the sizes with calories defined to help with maintainability 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, INotifyPropertyChanged 
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
        /// Price property for the Briarheart.  Gets price for the burger  
        /// Uses the shorthand method for a property
        /// </summary>
        public override double Price => 6.32;
        /// <summary>
        /// Gets the whopping amount of calories packed in the burger 
        /// </summary>
        public override uint Calories => 743;

        private bool bun = true;
        /// <summary>
        /// getter/setter for Bun Property
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                InvokePropertyChange("Bun");
            }
        }
        private bool ketchup = true;
        /// <summary>
        /// getter/setter for Ketchup property
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                InvokePropertyChange("Ketchup");
            }
        }
        private bool mustard = true;
        /// <summary>
        /// getter/setter for Mustard property
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                InvokePropertyChange("Mustard");
            }
        }
        private bool pickle = true;
        /// <summary>
        /// getter/setter for Pickle property
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                InvokePropertyChange("Pickle");
            }
        }
        private bool cheese = true;
        /// <summary>
        /// getter/setter for Cheese property
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                InvokePropertyChange("Cheese");
            }
        }
        /// <summary>
        ///List of special instructions specific to the Briarheart burger.
        ///Updates the list based on properties, creates a new list with each update.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            { 
                List<string> specialInstructions = new List<string>();
                if (!Bun)
                {
                    specialInstructions.Add("Hold bun");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Ketchup)
                {
                    specialInstructions.Add("Hold ketchup");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Mustard)
                {
                    specialInstructions.Add("Hold mustard");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Pickle)
                {
                    specialInstructions.Add("Hold pickle");
                    InvokePropertyChange("Special Instructions");
                }
                if (!Cheese)
                {
                    specialInstructions.Add("Hold cheese");
                    InvokePropertyChange("Special Instructions");
                }
                return specialInstructions;
            }
            
        }
        /// <summary>
        /// Overrides the standard ToString method and replaces the return value with the burger name.
        /// </summary>
        /// <returns>string "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
