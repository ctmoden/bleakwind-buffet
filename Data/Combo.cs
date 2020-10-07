using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Represents a combination of menu items in an order 
    /// </summary>
    public class Combo: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        public void InvokePropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price property, sum of all selected menu items with a $1 discount
        /// </summary>
        public double Price { get; }
        /// <summary>
        /// Sum of calories for the entire combo
        /// </summary>
        public uint Calories { get; }
        /// <summary>
        /// list of special instructions for each of the added items to the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get;
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
