﻿/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden 
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();

            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });

            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = false;
            });
        }
        [Fact]
        public void ChangingCreamNotifiesCreamProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();

            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });

            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = false;
            });
        }
        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();

            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });

            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = false;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();

            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Small;
            });

            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();

            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();

            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = false;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = false;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = false;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });

        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(coffee);
        }
        /// <summary>
        /// Drink should inherit/implement from base Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(coffee);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.Equal(Size.Small, coffee.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Ice = true;
            Assert.True(coffee.Ice);
            coffee.Ice = false;
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Decaf = true;
            Assert.True(coffee.Decaf);
            coffee.Decaf = false;
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.RoomForCream = true;
            Assert.True(coffee.RoomForCream);
            coffee.RoomForCream = false;
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Size = Size.Small;
            Assert.Equal(Size.Small, coffee.Size);
            coffee.Size = Size.Medium;
            Assert.Equal(Size.Medium, coffee.Size);
            coffee.Size = Size.Large;
            Assert.Equal(Size.Large, coffee.Size);
            coffee.Size = Size.Small;
            Assert.Equal(Size.Small, coffee.Size);

        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Size = size;
            Assert.Equal(price, coffee.Price);

        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Size = size;
            Assert.Equal(cal, coffee.Calories);
        }

        [Theory]
        /// <summary>
        /// both ice and cream included
        /// </summary>
        [InlineData(true, true)]
        /// <summary>
        /// ice is included, cream is not
        /// </summary>
        [InlineData(true, false)]
        /// <summary>
        /// ice is not included, cream is
        /// </summary>
        [InlineData(false, true)]
        /// <summary>
        /// neither ice nor cream is included
        /// </summary>
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Ice = includeIce;
            coffee.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", coffee.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", coffee.SpecialInstructions);
            if (!(includeIce || includeCream)) Assert.Empty(coffee.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            coffee.Decaf = decaf;
            coffee.Size = size;
            Assert.Equal(name, coffee.ToString());
        }
        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", coffee.Description);
        }
    }
}
