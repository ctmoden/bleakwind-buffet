/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = Size.Small;
            Assert.Equal(Size.Small, fries.Size);
            fries.Size = Size.Medium;
            Assert.Equal(Size.Medium, fries.Size);
            fries.Size = Size.Large;
            Assert.Equal(Size.Large, fries.Size);
            fries.Size = Size.Small;
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Empty(fries.SpecialInstructions);
        }

        [Theory]
        /// <summary>
        /// small should cost .42
        /// </summary>
        [InlineData(Size.Small, 0.42)]
        /// <summary>
        /// medium should cost .96
        /// </summary>
        [InlineData(Size.Medium, 0.76)]
        /// <summary>
        /// large should cost .96
        /// </summary>
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(price, fries.Price);
        }

        [Theory]
        /// <summary>
        /// small should have 77 calories
        /// </summary>
        [InlineData(Size.Small, 77)]
        /// <summary>
        /// medium should have 89 calories
        /// </summary>
        [InlineData(Size.Medium, 89)]
        /// <summary>
        /// large should have 100 calories
        /// </summary>
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(calories, fries.Calories);
        }

        [Theory]
        /// <summary>
        /// Small to string return
        /// </summary>
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        /// <summary>
        /// medium to string return
        /// </summary>
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        /// <summary>
        /// Large to string return
        /// </summary>
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(name, fries.ToString());

        }
    }
}