using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = aj;

            });
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = coffee;

            });
        }
        [Fact]
        public void ChangingPriceChangesPriceProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = aj;

            });
        }
    }
}
