﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class CashDrawerViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int ones = 0;
        /// <summary>
        /// number of one dollar bills in cash exchange
        /// </summary>
        public int Ones
        {
            get => ones;
            set
            {
                ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
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
