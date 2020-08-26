/*
 * Author: Christian Moden
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart burger and it's properties
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Price property for the Briarheart.  Gets price for the burger  
        /// Uses the shorthand method for a property
        /// </summary>
        private double Price => 6.32;
        /// <summary>
        /// Gets the whopping amount of calories packed in the burger 
        /// </summary>
        private uint Calories => 743;
        /// <summary>
        /// getter/setter for Bun Property
        /// </summary>
        private bool Bun { get; set; } = true;
        /// <summary>
        /// getter/setter for Ketchup property
        /// </summary>
        private bool Ketchup { get; set; } = true;
        /// <summary>
        /// getter/setter for Mustard property
        /// </summary>
        private bool Mustard { get; set; } = true;
        /// <summary>
        /// getter/setter for Pickle property
        /// </summary>
        private bool Pickle { get; set; } = true;
        /// <summary>
        /// getter/setter for Cheese property
        /// </summary>
        private bool Cheese { get; set; } = true;
        /// <summary>
        ///List of special instructions specific to the Briarheart burger 
        /// </summary>
        private List<string> SpecialInstructions = new List<string>();

    }
}
