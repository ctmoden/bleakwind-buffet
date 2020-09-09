/*
 * Author: Christian Moden
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart burger and it's properties
 * FIXME create a class with all of the sizes with calories defined to help with maintainability 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree 
    {
        /// <summary>
        /// Price property for the Briarheart.  Gets price for the burger  
        /// Uses the shorthand method for a property
        /// </summary>
        public override double Price => 6.32;
        /// <summary>
        /// Gets the whopping amount of calories packed in the burger 
        /// </summary>
        public override uint Calories => 743;
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
        ///List of special instructions specific to the Briarheart burger.
        ///Updates the list based on properties, creates a new list with each update.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            { 
                List<string> specialInstructions = new List<string>();
                if(!Bun) specialInstructions.Add("Hold bun");
                if(!Ketchup) specialInstructions.Add("Hold ketchup");
                if(!Mustard) specialInstructions.Add("Hold mustard");
                if(!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                return specialInstructions;
            }
            //FIXME do we need a setter?  I think it is fine on first guess.
            //setter: change property from outside of the class, we just want to have object 
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
