/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = true;
            });

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = false;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            AretinoAppleJuice AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Small;
            });

            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Medium;
            });
            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            AretinoAppleJuice AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Small;
            });
            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Medium;
            });
            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            AretinoAppleJuice AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Small;
            });
            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Medium;
            });
            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            AretinoAppleJuice AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.Ice = true;
            });
            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.Ice = false;
            });

        }


        [Fact]
        public void ShouldBeAnIorderable()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        /// <summary>
        /// Drink should inherit/implement from base Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        /// <summary>
        /// Ice should be set to false by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);//FIXME double check
            //.Equal(expected, actual)
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
            

        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}