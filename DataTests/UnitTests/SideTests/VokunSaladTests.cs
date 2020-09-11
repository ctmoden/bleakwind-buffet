/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeAnIorderable()
        {
            VokunSalad salad = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(salad);
        }
        /// <summary>
        /// Side should inherit/implement from base Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad salad = new VokunSalad();
            Assert.IsAssignableFrom<Side>(salad);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad salad = new VokunSalad();
            Assert.Equal(Size.Small, salad.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = Size.Small;
            Assert.Equal(Size.Small, salad.Size);
            salad.Size = Size.Medium;
            Assert.Equal(Size.Medium, salad.Size);
            salad.Size = Size.Large;
            Assert.Equal(Size.Large, salad.Size);
            salad.Size = Size.Small;
            Assert.Equal(Size.Small, salad.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad salad = new VokunSalad();
            Assert.Empty(salad.SpecialInstructions);
        }

        [Theory]
        /// <summary>
        /// small should cost 0.93
        /// </summary>
        [InlineData(Size.Small, 0.93)]
        /// <summary>
        /// medium should cost 1.28
        /// </summary>
        [InlineData(Size.Medium, 1.28)]
        /// <summary>
        /// large should cost 1.82
        /// </summary>
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = size;
            Assert.Equal(price, salad.Price);
        }

        [Theory]
        /// <summary>
        /// small should have 41 cals
        /// </summary>
        [InlineData(Size.Small, 41)]
        /// <summary>
        /// medium should have 52 cals
        /// </summary>
        [InlineData(Size.Medium, 52)]
        /// <summary>
        /// large should have 73 cals
        /// </summary>
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = size;
            Assert.Equal(calories, salad.Calories);
        }

        [Theory]
        /// <summary>
        /// Small to string return
        /// </summary>
        [InlineData(Size.Small, "Small Vokun Salad")]
        /// <summary>
        /// Medium to string return
        /// </summary>
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        /// <summary>
        /// Large to string return
        /// </summary>
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad salad = new VokunSalad();
            salad.Size = size;
            Assert.Equal(name, salad.ToString());
        }
    }
}