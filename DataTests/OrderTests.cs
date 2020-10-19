using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldGetCorrectCalories()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            order.Add(new CandlehearthCoffee());
            Assert.Equal(order.Calories, (uint)750);
        }
        [Fact]
        public void ShouldGetCorrectSubTotal()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            order.Add(new AretinoAppleJuice());
            Assert.Equal(6.94,order.SubTotal);
        }

        [Fact]
        public void ShouldGetCorrectTax()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            Assert.Equal(.76, order.Tax);
        }
        [Fact]
        public void ShouldGetCorrectTotal()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            Assert.Equal(7.08, order.Total);
        }

        [Fact]
        public void ShouldGetCorrectSalesTaxRate()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
        }
        [Fact]
        public void AddingOrRemovingItemNotifiesSubTotal()
        {
            Order order = new Order();
            
            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                BriarheartBurger b = new BriarheartBurger();
                order.Add(b);

            });
            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                BriarheartBurger b = new BriarheartBurger();
                order.Add(b);
                order.Remove(b);

            });

        }
        [Fact]
        public void AddingOrRemovingItemNotifiesTaxProperty()
        {
            Order order = new Order();

            Assert.PropertyChanged(order, "Tax", () =>
            {
                BriarheartBurger b = new BriarheartBurger();
                order.Add(b);

            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                BriarheartBurger b = new BriarheartBurger();
                order.Add(b);
                order.Remove(b);

            });
        }
        [Fact]
        public void OrderNumberShouldIncrementWithNewOrder()
        {
            Order order = new Order();
            Order order2 = new Order();
            Assert.Equal(order.Number+1, order2.Number);
            
        }

        [Fact]
        public void ShouldBeAbleToSetSalesTaxRate()
        {
            Order order = new Order();
            order.SalesTaxRate = .13;
            Assert.Equal(.13, order.SalesTaxRate);
        }

        [Fact]
        public void AddingItemNotifiesPriceProperty()
        {
            Order order = new Order();
            FriedMiraak miraak = new FriedMiraak();
            order.Add(miraak);
            Assert.PropertyChanged(miraak, "Price", () =>
            {
                miraak.Size = Data.Enums.Size.Medium;

            });

        }
        [Fact]
        public void AddingItemNotifiesCaloriesProperty()
        {
            Order order = new Order();
            FriedMiraak miraak = new FriedMiraak();
            order.Add(miraak);
            Assert.PropertyChanged(miraak, "Calories", () =>
            {
                miraak.Size = Data.Enums.Size.Medium;

            });
        }
        [Fact]
        public void ChangingItemPriceNotifiesSubTotalProperty()
        {
            Order order = new Order();
            FriedMiraak miraak = new FriedMiraak();
            order.Add(miraak);
            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                miraak.Size = Data.Enums.Size.Medium;

            });
        }
        [Fact]
        public void ChangingItemPriceNotifiesTotalProperty()
        {
            Order order = new Order();
            FriedMiraak miraak = new FriedMiraak();
            order.Add(miraak);
            Assert.PropertyChanged(order, "Total", () =>
            {
                miraak.Size = Data.Enums.Size.Medium;

            });
        }
        [Fact]
        public void ChangingItemPriceNotifiesSubTaxProperty()
        {
            Order order = new Order();
            FriedMiraak miraak = new FriedMiraak();
            order.Add(miraak);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                miraak.Size = Data.Enums.Size.Medium;

            });
        }
    }
}
