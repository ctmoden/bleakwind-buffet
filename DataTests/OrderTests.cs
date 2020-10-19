using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
        public void 
    }
}
