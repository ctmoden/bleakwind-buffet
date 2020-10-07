using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data.Enums;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Represents a combination of menu items in an order 
    /// </summary>
    public class Combo: IOrderItem, INotifyPropertyChanged 
    {
        public Combo()
        {
            drink.PropertyChanged += PropertyChangedListener;
            //same process for entree and side 
        }
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        public void InvokePropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
        //FIXME I was having this issue before... how the heck do I resolve it again?
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Price property, sum of all selected menu items with a $1 discount
        /// </summary>
        public double Price
        {
            get
            {
                
                return Drink.Price + Entree.Price + Side.Price;
            }
        }
        //public MyEnumerator GetEnumerator();
        
        /// <summary>
        /// Sum of calories for the entire combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                //FIXME need to attach event listener
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
            
        }
        /// <summary>
        /// list of special instructions for each of the added items to the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {//list add range 
                List<string> specialInstructions = new List<string>();
                foreach(IOrderItem item in this)
                {
                    foreach(string instruction in item.SpecialInstructions)
                    {
                        specialInstructions.Add($"{instruction},");
                    }
                    
                }
                return specialInstructions;
            }
        }
        private Drink drink = new AretinoAppleJuice();
        /// <summary>
        /// Represents a drink in the combo
        /// </summary>
        public Drink Drink
        {
            //FIXME just a filler for now
            get => drink;
            set
            {
                drink.PropertyChanged -= PropertyChangedListener;//replacing old drink with new drink
                //will create a memory link if the old 
                drink = value;
                //this.Add
                drink.PropertyChanged += PropertyChangedListener;
                InvokePropertyChange("Drink");
                InvokePropertyChange("Price");
                InvokePropertyChange("Calories");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        /// <summary>
        /// Represents an entree in the combo
        /// </summary>
        public Entree Entree
        {
            //how do I know what to set it to?  Use a switch statement?
            get => new BriarheartBurger();
            set
            {
                InvokePropertyChange("Entree");
                InvokePropertyChange("Price");
                InvokePropertyChange("Calories");
                InvokePropertyChange("SpecialInstructions");
            }
        }
        /// <summary>
        /// Represents a side in the combo
        /// </summary>
        public Side Side
        {
            //FIXME just implementing this as a filler
            get => new DragonbornWaffleFries();
            
            set
            {
                InvokePropertyChange("Side");
                InvokePropertyChange("Price");
                InvokePropertyChange("Calories");
                InvokePropertyChange("SpecialInstructions");
            } 
        }
        /// <summary>
        /// Event listener for price and calories properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price") InvokePropertyChange("Price");
            if (e.PropertyName == "Calories") InvokePropertyChange("Calories");
        }
        
        
    }
}
