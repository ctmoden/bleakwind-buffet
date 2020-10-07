using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data
{
    public class Order: ObservableCollection<IOrderItem>, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Order()
        {
            Number = nextOrderNum;
            nextOrderNum++;
        }
        private static int nextOrderNum = 1;
        /// <summary>
        /// Invokes the property changed event handler for a property
        /// </summary>
        /// <param name="propertyName">name of property that just changed</param>
        public void InvokePropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //FIXME I was having this issue before... how the heck do I resolve it again?
        public new event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
        /// <summary>
        /// Sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;
        /// <summary>
        /// Total tax for combo
        /// </summary>
        public double Tax
        {
            get
            {
                return SubTotal * SalesTaxRate;
            }
        }
        /// <summary>
        /// Price for combo excluding yax
        /// </summary>
        public double Total
        {
            get { return SubTotal + Tax; }
        }
        /// <summary>
        /// Total Price of combo with a $1 discount
        /// </summary>
        public double SubTotal
        {
            get
            {
                return Total + Tax;
            }
        }
        /// <summary>
        /// Order number
        /// </summary>
        public int Number { get; }

        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

    }
}
