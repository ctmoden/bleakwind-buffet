/*
 * Author: Christian Moden
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton breakfast and it's properties
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Price property for the Smokehouse Skeleton. 
        /// Uses the shorthand method for a property
        /// </summary>
        public double Price => 5.62;
        /// <summary>
        /// Property Gets the whopping amount of calories packed in the breakfast 
        /// </summary>
        public uint Calories => 602;
        /// <summary>
        /// Property for sausage link.  T/F values 
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// Property for the Egg. T/F values
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Property for the HashBrowns.  T/F values.
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// Pancake property.  T/F values
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        ///List of special instructions specific to the Skeleton Smokehouse.
        ///Updates the list based on property states, creates a new list with each update.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!SausageLink) specialInstructions.Add("Hold sausage");
                if (!Egg) specialInstructions.Add("Hold eggs");
                if (!HashBrowns) specialInstructions.Add("Hold hash browns");
                if (!Pancake) specialInstructions.Add("Hold pancakes");
                return specialInstructions;
            }
        }
        /// <summary>
        /// Overrides defualt ToString method and returns string specific to Smokehouse Skeleton.
        /// </summary>
        /// <returns>"Smokehouse Skeleton" string</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
