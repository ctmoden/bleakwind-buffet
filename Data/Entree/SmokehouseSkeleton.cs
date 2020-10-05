/*
 * Author: Christian Moden
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton breakfast and it's properties
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
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
        /// Price property for the Smokehouse Skeleton. 
        /// Uses the shorthand method for a property
        /// </summary>
        public override double Price => 5.62;
        /// <summary>
        /// Property Gets the whopping amount of calories packed in the breakfast 
        /// </summary>
        public override uint Calories => 602;
        private bool sausageLink = true;
        /// <summary>
        /// Property for sausage link.  T/F values 
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                InvokePropertyChange("SausageLink");
                if (!sausageLink) InvokePropertyChange("Special Instructions");
            }
        }
        private bool egg = true;
        /// <summary>
        /// Property for the Egg. T/F values
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                InvokePropertyChange("Egg");
                if(!egg) InvokePropertyChange("Special Instructions");
            }
        }
        private bool hashBrowns = true;
        /// <summary>
        /// Property for the HashBrowns.  T/F values.
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                InvokePropertyChange("HashBrowns");
                if(!hashBrowns) InvokePropertyChange("Special Instructions");
            }
        }
        private bool pancake = true;
        /// <summary>
        /// Pancake property.  T/F values
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                InvokePropertyChange("Pancake");
                if(!pancake) InvokePropertyChange("Special Instructions");
            }
        }

        /// <summary>
        ///List of special instructions specific to the Skeleton Smokehouse.
        ///Updates the list based on property states, creates a new list with each update.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!SausageLink)
                {
                    specialInstructions.Add("Hold sausage");
                    
                }
                if (!Egg)
                {
                    specialInstructions.Add("Hold eggs");
                    
                }
                if (!HashBrowns)
                {
                    specialInstructions.Add("Hold hash browns");
                    
                }
                if (!Pancake)
                {
                    specialInstructions.Add("Hold pancakes");
                    
                }
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
