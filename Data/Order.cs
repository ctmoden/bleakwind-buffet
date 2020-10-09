using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data
{
    public class Order: ObservableCollection<IOrderItem>, INotifyPropertyChanged
    {
        private List<IOrderItem> itemList = new List<IOrderItem>();
        /// <summary>
        /// Constructor
        /// </summary>
        public Order()
        {
            CollectionChanged += CollectionChangedListener;
            Number = nextOrderNum;
            nextOrderNum++;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public List<IOrderItem> List
        {
            get
            {
                foreach (IOrderItem item in this)
                {
                    itemList.Add(item);
                }
                return itemList;
            }
        }
        /// <summary>
        /// Event handler for when the collection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;//FIXME need to figure out how to get preoperty changed event into 
                        /*
                        OnCollectionChanged(e);//FIXME create a new NoifyCollection Changed Args?
                        
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                        */
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;//FIXME need to figure out how to get preoperty changed event into 
                        /*
                        OnCollectionChanged(e);//FIXME create a new NoifyCollection Changed Args?
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                        */
                    }
                    break;
            }

        }
        /// <summary>
        /// listening for individual property changed events
        /// </summary>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SubTotal":
                    OnPropertyChanged(new PropertyChangedEventArgs("SubTotal"));
                    break;
                case "Tax":
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    break;
                case "Total":
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    break;
                case "Calories":
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                default:
                    throw new NotImplementedException("Field does not exist");
            }
        }

        //gives the order a unique number
        private static int nextOrderNum = 1;
        
        
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
                double subTotal = 0.0;
                foreach(IOrderItem item in this)
                {
                    subTotal += item.Price;
                }
                return subTotal;
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
