using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    public static class UpdateCashDrawer
    {
        /// <summary>
        /// Updates cash register and prints receipt 
        /// </summary>
        /// <param name="viewModel">current view model</param>
        /// <param name="payment">type of payment</param>
        /// <param name="orderDate">date in which order was created</param>
        public static void UpdateCashDrawerValues(CashDrawerViewModel viewModel, string payment, DateTime orderDate)
        {
            CashDrawer.OpenDrawer();
            AddTenured(viewModel);
            SubtractChange(viewModel);
            RecieptPrinter.PrintLine($"Order #{viewModel.order.Number}");
            RecieptPrinter.PrintLine($"{orderDate}");
            for (int i = 0; i < viewModel.order.Count; i++)
            {
                RecieptPrinter.PrintLine(viewModel.order[i].ToString());
                for (int j = 0; j < viewModel.order[i].SpecialInstructions.Count; j++)
                {
                    RecieptPrinter.PrintLine($"\t {viewModel.order[i].SpecialInstructions[j]}");
                }
            }
            RecieptPrinter.PrintLine($"Subtotal: {viewModel.SubTotal}");
            RecieptPrinter.PrintLine($"Tax: {viewModel.Tax}");
            RecieptPrinter.PrintLine($"Total: {viewModel.Total}");
            RecieptPrinter.PrintLine($"{payment}");
            RecieptPrinter.PrintLine($"Change Due: {viewModel.ChangeOwed}"); //FIXME make sure using right prop here
            RecieptPrinter.CutTape();
        }
        /// <summary>
        /// Adds tenured bills and coins to the register 
        /// </summary>
        /// <param name="viewModel"></param>
        private static void AddTenured(CashDrawerViewModel viewModel)
        {
            CashDrawer.Dimes += viewModel.TenCent;
            CashDrawer.Ones += viewModel.Ones;
            CashDrawer.Fifties += viewModel.Fifties;
            CashDrawer.Fives += viewModel.Fives;
            CashDrawer.HalfDollars += viewModel.FiftyCent;
            CashDrawer.Hundreds += viewModel.Hundreds;
            CashDrawer.Nickels += viewModel.FiveCent;
            CashDrawer.Pennies += viewModel.OneCent;
            CashDrawer.Quarters += viewModel.TwentyFiveCent;
            CashDrawer.Tens += viewModel.Tens;
            CashDrawer.Twenties += viewModel.Twenties;
            CashDrawer.Twos += viewModel.Twos;
        }
        /// <summary>
        /// Subtracts change due to the customer form the cash register
        /// </summary>
        /// <param name="viewModel"></param>
        private static void SubtractChange(CashDrawerViewModel viewModel)
        {
            CashDrawer.Dimes -= viewModel.TensChange;
            CashDrawer.Ones -= viewModel.OnesChange;
            CashDrawer.Fifties -= viewModel.FiftiesChange;
            CashDrawer.Fives -= viewModel.FivesChange;
            CashDrawer.HalfDollars -= viewModel.HalfDollarChange;
            CashDrawer.Hundreds -= viewModel.HundredsChange;
            CashDrawer.Nickels -= viewModel.NickelChange;
            CashDrawer.Pennies -= viewModel.PennyChange;
            CashDrawer.Quarters -= viewModel.QuarterChange;
            CashDrawer.Tens -= viewModel.TensChange;
            CashDrawer.Twenties -= viewModel.TwentiesChange;
            CashDrawer.Twos -= viewModel.TwosChange;
        }
    }
}
