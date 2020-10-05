/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();

            Assert.PropertyChanged(milk, "Ice", () =>
            {
                milk.Ice = true;
            });

            Assert.PropertyChanged(milk, "Ice", () =>
            {
                milk.Ice = false;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();

            Assert.PropertyChanged(milk, "Size", () =>
            {
                milk.Size = Size.Small;
            });

            Assert.PropertyChanged(milk, "Size", () =>
            {
                milk.Size = Size.Medium;
            });
            Assert.PropertyChanged(milk, "Size", () =>
            {
                milk.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();

            Assert.PropertyChanged(milk, "Price", () =>
            {
                milk.Size = Size.Small;
            });
            Assert.PropertyChanged(milk, "Price", () =>
            {
                milk.Size = Size.Medium;
            });
            Assert.PropertyChanged(milk, "Price", () =>
            {
                milk.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();

            Assert.PropertyChanged(milk, "Calories", () =>
            {
                milk.Size = Size.Small;
            });
            Assert.PropertyChanged(milk, "Calories", () =>
            {
                milk.Size = Size.Medium;
            });
            Assert.PropertyChanged(milk, "Calories", () =>
            {
                milk.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.PropertyChanged(milk, "Special Instructions", () =>
            {
                milk.Ice = true;
            });
            Assert.PropertyChanged(milk, "Special Instructions", () =>
            {
                milk.Ice = false;
            });

        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(milk);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(milk);
        }
        /// <summary>
        /// Drink should inherit/implement from base Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(milk);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.False(milk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.Equal(Size.Small, milk.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = true;
            Assert.True(milk.Ice);
            milk.Ice = false;
            Assert.False(milk.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = Size.Small;
            Assert.Equal(Size.Small, milk.Size);
            milk.Size = Size.Medium;
            Assert.Equal(Size.Medium, milk.Size);
            milk.Size = Size.Large;
            Assert.Equal(Size.Large, milk.Size);
            milk.Size = Size.Small;
            Assert.Equal(Size.Small, milk.Size);

        }
        
        [Theory]
        /// <summary>
        /// Small milk should cost 1.05
        /// </summary>
        [InlineData(Size.Small, 1.05)]
        /// <summary>
        /// Medium milk should cost 1.11
        /// </summary>
        [InlineData(Size.Medium, 1.11)]
        /// <summary>
        /// Large milk should cost 1.22
        /// </summary>
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(price, milk.Price);
        }

        [Theory]
        /// <summary>
        /// Small milk should have 56 calories
        /// </summary>
        [InlineData(Size.Small, 56)]
        /// <summary>
        /// Medium milk should have 72 calories
        /// </summary>
        [InlineData(Size.Medium, 72)]
        /// <summary>
        /// Large milk should have 93 calories
        /// </summary>
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(cal, milk.Calories);
        }

        [Theory]
        /// <summary>
        /// ice is included
        /// </summary>
        [InlineData(true)]
        /// <summary>
        /// ice is not included
        /// </summary>
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", milk.SpecialInstructions);
            if (!includeIce) Assert.Empty(milk.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(name, milk.ToString());
        }
    }
}