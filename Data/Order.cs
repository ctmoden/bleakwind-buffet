using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Order: ObservableCollection<IOrderItem>, INotifyPropertyChanged
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
        /// Total price for combo
        /// </summary>
        public double Total
        {
            get { return SubTotal + Tax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double SubTotal { get; }

    }
}
