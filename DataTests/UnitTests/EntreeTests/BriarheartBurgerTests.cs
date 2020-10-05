/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = true;
            });
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = true;
            });
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = true;
            });
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = true;
            });
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = true;
            });
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(burger, "Special Instructions", () =>
            {
                burger.Bun = false;
            });
            Assert.PropertyChanged(burger, "Special Instructions", () =>
            {
                burger.Ketchup = false;
            });
            Assert.PropertyChanged(burger, "Special Instructions", () =>
            {
                burger.Ketchup = false;
            });
            Assert.PropertyChanged(burger, "Special Instructions", () =>
            {
                burger.Mustard = false;
            });
            Assert.PropertyChanged(burger, "Special Instructions", () =>
            {
                burger.Pickle = false;
            });
            Assert.PropertyChanged(burger, "Special Instructions", () =>
            {
                burger.Cheese = false;
            });

        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(b);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(burger);
        }
        /// <summary>
        /// Entree should inherit/implement from base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(burger);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);

        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = true;
            Assert.True(b.Bun);
            b.Bun = false;
            Assert.False(b.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = true;
            Assert.True(b.Ketchup);
            b.Ketchup = false;
            Assert.False(b.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = true;
            Assert.True(b.Mustard);
            b.Mustard = false;
            Assert.False(b.Mustard);

        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = true;
            Assert.True(b.Pickle);
            b.Pickle = false;
            Assert.False(b.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = true;
            Assert.True(b.Cheese);
            b.Cheese = false;
            Assert.False(b.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(743, (double)b.Calories);
            //FIXME why did I have to cast to a double?
            
        }

        [Theory]
        /// <summary>
        /// boolean variables will set respective properties in test to true.
        /// </summary>
        [InlineData(true, true, true, true, true)]
        /// <summary>
        /// boolean variables will set respective properties in test to false.
        /// </summary>
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", b.SpecialInstructions);
            b.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", b.SpecialInstructions);
            b.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", b.SpecialInstructions);
            b.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", b.SpecialInstructions);
            b.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", b.SpecialInstructions);
            if (b.Bun && b.Ketchup && b.Mustard && b.Pickle && b.Cheese) Assert.Empty(b.SpecialInstructions);
            
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString());
        }
    }
}