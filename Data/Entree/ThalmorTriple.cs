/*
 * Author: Christian Moden
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent Thalmor Triple burger and it's properties
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Price property for the Thalmor Triple.  Gets price for the burger  
        /// Uses the shorthand method for a property
        /// </summary>
        public double Price => 8.32;
        /// <summary>
        /// Property Gets the whopping amount of calories packed in the burger 
        /// </summary>
        public uint Calories => 943;
        /// <summary>
        /// getter/setter for Bun Property
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// getter/setter for Ketchup property
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// getter/setter for Mustard property
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// getter/setter for Pickle property
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// getter/setter for Cheese property
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// property with a getter/setter for Tomato.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// property with a bool getter/setter for the Lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// property with a getter/setter for Mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// property with a getter/setter for Bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// property with a getter/setter for Egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        ///List of special instructions specific to the Thalmor Triple burger.
        ///Updates the list based on property states, creates a new list with each update.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructionList = new List<string>();
                if (!Bun) instructionList.Add("Hold bun");
                if (!Ketchup) instructionList.Add("Hold ketchup");
                if (!Mustard) instructionList.Add("Hold mustard");
                if (!Pickle) instructionList.Add("Hold pickle");
                if (!Cheese) instructionList.Add("Hold cheese");
                if (!Tomato) instructionList.Add("Hold tomato");
                if (!Lettuce) instructionList.Add("Hold lettuce");
                if (!Mayo) instructionList.Add("Hold mayo");
                if (!Bacon) instructionList.Add("Hold Egg");
                return instructionList;
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
