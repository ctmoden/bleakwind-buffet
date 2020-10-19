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
                        //only for one item added
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));//FIXME create a new NoifyCollection Changed Args?
                        
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                        
                        
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        //have to subtract listener when item is removed
                        item.PropertyChanged -= CollectionItemChangedListener;//FIXME need to figure out how to get preoperty changed event into 
                        
                        //OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));//FIXME create a new NoifyCollection Changed Args?
                        OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                        
                        
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
                case "Price":
                    
                    OnPropertyChanged(new PropertyChangedEventArgs("SubTotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    break;
                
                case "Calories":
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                    
                default:
                    break;
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
                return Math.Round(SubTotal * SalesTaxRate,2);//FIXME format to two decimal places
            }
        }
        
        /// <summary>
        /// Price for combo excluding yax
        /// </summary>
        public double Total
        {
            get { return Math.Round((SubTotal + Tax),2); }
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
                return Math.Round(subTotal,2);
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
