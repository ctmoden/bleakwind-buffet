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
    public class Combo: ObservableCollection<IOrderItem>, IOrderItem, INotifyPropertyChanged 
    {
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        public void InvokePropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //FIXME I was having this issue before... how the heck do I resolve it again?
        public new  event PropertyChangedEventHandler PropertyChanged;
        private double price = 0.0;
        /// <summary>
        /// Price property, sum of all selected menu items with a $1 discount
        /// </summary>
        public double Price
        {
            get
            {
               
                foreach (IOrderItem item in this)
                {
                    price += item.Price;
                }
                return price;
            }
        }
        //public MyEnumerator GetEnumerator();
        private uint calories = 0;
        /// <summary>
        /// Sum of calories for the entire combo
        /// </summary>
        public uint Calories
        {
            get
            {
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
            {
                List<string> specialInstructions = new List<string>();
                foreach(IOrderItem item in this)
                {
                    foreach(string instruction in item.SpecialInstructions)
                    {
                        specialInstructions.Add($"{item.SpecialInstructions},");
                    }
                    
                }
                return specialInstructions;
            }
        }
        private Drink drink;
        /// <summary>
        /// Represents a drink in the combo
        /// </summary>
        public Drink Drink
        {
            get => new AretinoAppleJuice();
            set
            {
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
        
        
    }
}
