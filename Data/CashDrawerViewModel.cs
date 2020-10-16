using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;
namespace BleakwindBuffet.Data
{
    public class CashDrawerViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Order order;
        
        public CashDrawerViewModel(Order o)
        {
            order = o;
        }
        /// <summary>
        /// extracts current order's subtotal
        /// </summary>
        public double SubTotal
        {
            get => order.SubTotal;
        }
        /// <summary>
        /// Extracts tax from order 
        /// </summary>
        public double Tax
        {
            get => order.Tax;
        }
        /// <summary>
        /// Extracts total from curretnt order
        /// </summary>
        public double Total
        {
            get => order.Total;
        }
        /// <summary>
        /// prints receipt of the whole order
        /// </summary>
        public void FinalizeOrder()
        {
            CashDrawer.OpenDrawer();
            //add num of bills from customer
            //subtract num of bills from change given
            RecieptPrinter.PrintLine($"Order #{order.Number}");
            //date and time order was finalized
            for(int i = 0; i < order.Count; i++)
            {
                RecieptPrinter.PrintLine(order[i].ToString());
                for(int j = 0; j < order[i].SpecialInstructions.Count; j++)
                {
                    RecieptPrinter.PrintLine($"\t {order[i].SpecialInstructions[j]}");
                }
                
            }
            RecieptPrinter.PrintLine($"Subtotal: {SubTotal}");
            RecieptPrinter.PrintLine($"Tax: {Tax}");
            RecieptPrinter.PrintLine($"Total: {order.Total}");
            //payment method
            //change owed
            RecieptPrinter.CutTape();
        }

        public double CalculateChange()
        {
            //params/varaibles: order total, num of each currenncy from customer.
            //add up all currency bills and coins given from the user
            //
            return 1.1;
        }
        
        
        /// <summary>
        /// Total amount given my the user
        /// </summary>
        public double AmountTenuered
        {
            get => (Ones * 1) + (Twos * 2) + (Fives * 5) + (Tens * 10) +
                    (Twenties * 20) + (Fifties * 50) + (Hundreds * 100) + (OneCent * .01) +
                    (FiveCent * .05) + (TenCent * .1) + (TwentyFiveCent) * .25 + (FiftyCent * .5);
            
        }
        //double amountOwed = 0;
        /// <summary>
        /// Running total 
        /// </summary>
        public double AmountOwed
        {
            get => Total-AmountTenuered;
            
        }
        /// <summary>
        /// Change owed to the user
        /// </summary>
        public double ChangeOwed
        {
            get
            {
                if (AmountTenuered > AmountOwed)
                {
                    return AmountTenuered - AmountOwed;
                }
                else return 0.0;
            }
            
        }
        int ones = 0;
        /// <summary>
        /// number of one dollar bills in cash exchange
        /// </summary>
        public int Ones
        {
            get => ones;
            set
            {
                if (ones != value)
                {
                    ones = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                }
            }
        }
        int twos = 0;
        /// <summary>
        /// number of two dollar bills in cash exchange
        /// </summary>
        public int Twos
        {
            get => twos;
            set
            {
                twos = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
            }
        }

        int fives = 0;
        /// <summary>
        /// number of five dollar bills in cash exchange
        /// </summary>
        public int Fives
        {
            get => fives;
            set
            {
                fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
            }
        }

        int tens = 0;
        /// <summary>
        /// number of ten dollar bills in cash exchange
        /// </summary>
        public int Tens
        {
            get => tens;
            set
            {
                tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
            }
        }

        int twenties = 0;
        /// <summary>
        /// number of twenty dollar bills in cash exchange
        /// </summary>
        public int Twenties
        {
            get => twenties;
            set
            {
                twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
            }
        }
        int fifties = 0;
        /// <summary>
        /// number of fifty dollar bills in cash exchange
        /// </summary>
        public int Fifties
        {
            get => fifties;
            set
            {
                fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
            }
        }

        int hundreds = 0;
        /// <summary>
        /// number of hundred dollar bills in cash exchange
        /// </summary>
        public int Hundreds
        {
            get => hundreds;
            set
            {
                hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
            }
        }
        int oneCent = 0;
        /// <summary>
        /// number of pennies in cash exchange
        /// </summary>
        public int OneCent
        {
            get => oneCent;
            set
            {
                oneCent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCent"));
            }
        }
        int fiftyCent = 0;
        /// <summary>
        /// number of half-dollars in cash exchange
        /// </summary>
        public int FiftyCent
        {
            get => fiftyCent;
            set
            {
                fiftyCent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCent"));
            }
        }
        int twentyFiveCent = 0;
        /// <summary>
        /// number of quarters in cash exchange
        /// </summary>
        public int TwentyFiveCent
        {
            get => twentyFiveCent;
            set
            {
                twentyFiveCent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyFiveCent"));
            }
        }
        int tenCent = 0;
        /// <summary>
        /// number of dimes in cash exchange
        /// </summary>
        public int TenCent
        {
            get => tenCent;
            set
            {
                tenCent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCent"));
            }
        }
        int fiveCent = 0;
        /// <summary>
        /// Number of nickels in cash exchange
        /// </summary>
        public int FiveCent
        {
            get => fiveCent;
            set
            {
                fiveCent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCent"));
            }
        }
    }
}
