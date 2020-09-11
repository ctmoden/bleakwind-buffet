/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeAnIorderable()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(miraak);
        }
        /// <summary>
        /// Side should inherit/implement from base Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(miraak);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak hash = new FriedMiraak();
            Assert.Equal(Size.Small, hash.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak hash = new FriedMiraak();
            hash.Size = Size.Small;
            Assert.Equal(Size.Small, hash.Size);
            hash.Size = Size.Medium;
            Assert.Equal(Size.Medium, hash.Size);
            hash.Size = Size.Large;
            Assert.Equal(Size.Large, hash.Size);
            hash.Size = Size.Small;
            Assert.Equal(Size.Small, hash.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak hash = new FriedMiraak();
            Assert.Empty(hash.SpecialInstructions);
        }

        [Theory]
        /// <summary>
        /// small should cost 1.78
        /// </summary>
        [InlineData(Size.Small, 1.78)]
        /// <summary>
        /// medium should cost 2.01
        /// </summary>
        [InlineData(Size.Medium, 2.01)]
        /// <summary>
        /// large should cost 2.88
        /// </summary>
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak hash = new FriedMiraak();
            hash.Size = size;
            Assert.Equal(price, hash.Price);
        }

        [Theory]
        /// <summary>
        /// small should have 151 cals
        /// </summary>
        [InlineData(Size.Small, 151)]
        /// <summary>
        /// medium should have 236 cals
        /// </summary>
        [InlineData(Size.Medium, 236)]
        /// <summary>
        /// large should have 306 cals
        /// </summary>
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak hash = new FriedMiraak();
            hash.Size = size;
            Assert.Equal(calories, hash.Calories);
        }

        [Theory]
        /// <summary>
        /// Small to string return
        /// </summary>
        [InlineData(Size.Small, "Small Fried Miraak")]
        /// <summary>
        /// Medium to string return
        /// </summary>
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        /// <summary>
        /// Large to string return
        /// </summary>
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak hash = new FriedMiraak();
            hash.Size = size;
            Assert.Equal(name, hash.ToString());
        }
    }
}