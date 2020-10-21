using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    public class CashDrawerViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Order order;//make public to be accessible in static 
        private string paymentType;
        public CashDrawerViewModel(Order o, string payment)
        {
            order = o;
            paymentType = payment;
            
            
        }
        /// <summary>
        /// 
        /// </summary>
        public string CardOperations()
        {
            CardTransactionResult cardTransactionResult = CardReader.RunCard(Total);
            switch (cardTransactionResult)
            {
                case CardTransactionResult.Approved:
                    DateTime orderDate = DateTime.Now;
                    UpdateCashDrawer.UpdateCashDrawerValues(this, paymentType, orderDate);
                    return "Approved";
                    
                case CardTransactionResult.Declined:
                    return "Declnined";
                case CardTransactionResult.IncorrectPin:
                    return "Incorrect Pin";
                case CardTransactionResult.InsufficientFunds:
                    return "Insufficient Funds";
                case CardTransactionResult.ReadError:
                    return "Read Error";
                default:
                    throw new NotImplementedException("Card Operation Not Recognized");
            }
            
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
            DateTime orderDate = DateTime.Now;
            UpdateCashDrawer.UpdateCashDrawerValues(this, "Cash", orderDate);
            //start a new orde back at the order screen
        }
        /// <summary>
        /// Calculates change due to customer
        /// Algorithm structure from: https://stackoverflow.com/questions/31330657/change-calculator-not-calculating-pennies 
        /// </summary>
        public void CalculateChange()
        {
            double change = ChangeOwed;
            HundredsChange = (int)Math.Floor(change / 100);
            change %= 100;
            FiftiesChange = (int)Math.Floor(change / 50);
            change %= 50;
            TwentiesChange = (int)Math.Floor(change / 20);
            change %= 20;
            TensChange = (int)Math.Floor(change / 10);
            change %= 10;
            FivesChange = (int)Math.Floor(change / 5);
            change %= 5;
            TwosChange = (int)Math.Floor(change / 2);
            change = Math.Round(change % 2,2);
            OnesChange = (int)Math.Floor(change / 1);
            change = Math.Round(change % 1, 2);
            HalfDollarChange = (int)Math.Floor(change / .5);
            change = Math.Round(change % .5, 2);
            QuarterChange = (int)Math.Floor(change / .25);
            change = Math.Round(change % .25, 2);
            DimeChange = (int)Math.Floor(change / .1);
            change = Math.Round(change % .1, 2);
            NickelChange = (int)Math.Floor(change / .05);
            change = Math.Round(change % .05, 2);
            PennyChange = (int)Math.Floor(change / .01);
            
            
            
        }
        
        
        /// <summary>
        /// Total amount given my the user
        /// </summary>
        public double AmountTenuered
        {
            get => (Ones * 1) + (Twos * 2) + (Fives * 5) + (Tens * 10) +
                    (Twenties * 20) + (Fifties * 50) + (Hundreds * 100) + (OneCent * .01) +
                    (FiveCent * .05) + (TenCent * .1) + (TwentyFiveCent) * .25 + (FiftyCent * .5);//call the change method here?
            
        }
        //double amountOwed = 0;
        /// <summary>
        /// Running total 
        /// </summary>
        public double AmountOwed
        {
            get
            {               
                return Total-AmountTenuered;  
            }
            
        }
        /// <summary>
        /// Disply property for amount owed
        /// </summary>
        public double AmountOwedDisplay
        {
            get
            {
                if (AmountOwed < 0) return 0;
                else return AmountOwed;
            }
        }
        /// <summary>
        /// Change owed to the user
        /// </summary>
        public double ChangeOwed
        {
            get
            {
                if (paymentType.Equals("Card")) return 0.0;

                else if (AmountOwed < 0)
                {
                    //CalculateChange(Math.Abs(AmountOwed));
                    return Math.Abs(AmountOwed);

                }
                else
                {
                    //if(AmountTenuered > AmountOwed);
                    return AmountTenuered - AmountOwed;
                }
                

            }
            
        }
        /// <summary>
        /// Display property for change owed
        /// </summary>
        public double ChangeOwedDisplay
        {
            get
            {
                if (ChangeOwed > 0) 
                {
                    CalculateChange();
                    return Math.Abs(ChangeOwed);
                } 
                else return 0;
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
                }
            }
        }

        int onesChange = 0;
        /// <summary>
        /// One dollar bills due in change
        /// </summary>
        public int OnesChange
        {
            get => onesChange;
            set
            {
                value = onesChange;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesChange"));
                
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int twosChange = 0;
        /// <summary>
        /// Two dollar bills due in change
        /// </summary>
        public int TwosChange
        {
            get => twosChange;
            set
            {
                twosChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }

        }
        int fivesChange = 0;
        /// <summary>
        /// Five dollar bills in change due to customer
        /// </summary>
        public int FivesChange
        {
            get => fivesChange;
            set
            {
                fivesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int tensChange = 0;
        /// <summary>
        /// Ten dollar bills due in change to customer
        /// </summary>
        public int TensChange
        {
            get => tensChange;
            set
            {
                tensChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int twentiesChange = 0;
        public int TwentiesChange
        {
            get => twentiesChange;
            set
            {
                twentiesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int fiftiesChange = 0;
        /// <summary>
        /// Change in 50 bills due to customer
        /// </summary>
        public int FiftiesChange
        {
            get => fiftiesChange;
            set
            {
                fiftiesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int hundredsChange = 0;
        /// <summary>
        /// Change in $100 buills due to customer
        /// </summary>
        public int HundredsChange
        {
            get => hundredsChange;
            set
            {
                hundredsChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int pennyChange = 0;
        /// <summary>
        /// Pennies of change due to customer
        /// </summary>
        public int PennyChange
        {
            get => pennyChange;
            set
            {
                pennyChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PennyChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int halfDollarChange = 0;
        /// <summary>
        /// half dollar change due to customer
        /// </summary>
        public int HalfDollarChange
        {
            get => halfDollarChange;
            set
            {
                halfDollarChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int quarterChange = 0;
        /// <summary>
        /// Quarters due to customer in change
        /// </summary>
        public int QuarterChange
        {
            get => quarterChange;
            set
            {
                quarterChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuarterChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int dimeChange = 0;
        /// <summary>
        /// dimes in change due to customer
        /// </summary>
        public int DimeChange
        {
            get => dimeChange;
            set
            {
                dimeChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimeChange"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwedDisplay"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwedDisplay"));
            }
        }
        int nickelChange = 0;
        public int NickelChange
        {
            get => nickelChange;
            set
            {
                nickelChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelChange"));
            }
        }
    }
}
