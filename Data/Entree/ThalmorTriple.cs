/*
 * Author: Christian Moden
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent Thalmor Triple burger and it's properties
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree
    {
        
        /// <summary>
        /// Price property for the Thalmor Triple.  Gets price for the burger  
        /// Uses the shorthand method for a property
        /// </summary>
        public override double Price => 8.32;
        /// <summary>
        /// Property Gets the whopping amount of calories packed in the burger 
        /// </summary>
        public override uint Calories => 943;
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
                InvokePropertyChange("SpecialInstructions");
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
                InvokePropertyChange("SpecialInstructions");
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
                InvokePropertyChange("SpecialInstructions");
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
                InvokePropertyChange("SpecialInstructions");
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
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool tomato = true;
        /// <summary>
        /// property with a getter/setter for Tomato.
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                InvokePropertyChange("Tomato");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// property with a bool getter/setter for the Lettuce.
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                InvokePropertyChange("Lettuce");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool mayo = true;
        /// <summary>
        /// property with a getter/setter for Mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                InvokePropertyChange("Mayo");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        private bool bacon = true;
        /// <summary>
        /// property with a getter/setter for Bacon
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                InvokePropertyChange("Bacon");
                InvokePropertyChange("SpecialInstructions");
            }

        }
        private bool egg = true;
        /// <summary>
        /// property with a getter/setter for Egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                InvokePropertyChange("Egg");
                InvokePropertyChange("SpecialInstructions"); 
            }
        }
        /// <summary>
        ///List of special instructions specific to the Thalmor Triple burger.
        ///Updates the list based on property states, creates a new list with each update.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun)
                {
                    specialInstructions.Add("Hold bun");
                    
                }
                if (!Ketchup)
                {
                    specialInstructions.Add("Hold ketchup");
                    
                }
                if (!Mustard)
                {
                    specialInstructions.Add("Hold mustard");
                    
                }
                if (!Pickle)
                {
                    specialInstructions.Add("Hold pickle");
                   
                }
                if (!Cheese)
                {
                    specialInstructions.Add("Hold cheese");
                    
                }
                if (!Tomato)
                {
                    specialInstructions.Add("Hold tomato");
                    
                }
                if (!Lettuce)
                {
                    specialInstructions.Add("Hold lettuce");
                    
                }
                if (!Mayo)
                {
                    specialInstructions.Add("Hold mayo");
                    
                }
                if (!Bacon)
                {
                    specialInstructions.Add("Hold bacon");
                    
                }
                if (!Egg)
                {
                    specialInstructions.Add("Hold egg");
                    
                }
                return specialInstructions;
            }
            //FIXME do we need a setter?  I think it is fine on first guess.
        }
        /// <summary>
        /// Overrides the standard ToString method and replaces the return value with the burger name.
        /// </summary>
        /// <returns>string "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
