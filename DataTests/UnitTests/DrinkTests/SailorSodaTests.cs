/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeAnIorderable()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(soda);
        }
        /// <summary>
        /// Drink should inherit/implement from base Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(soda);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = true;
            Assert.True(soda.Ice);
            soda.Ice = false;
            Assert.False(soda.Ice);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = true;
            Assert.True(soda.Ice);
            soda.Ice = false;
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, soda.Flavor);
            soda.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, soda.Flavor);
            soda.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, soda.Flavor);
            soda.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, soda.Flavor);
        }
        
        [Theory]
        /// <summary>
        /// Size small should cost 1.42
        /// </summary>
        [InlineData(Size.Small, 1.42)]
        /// <summary>
        /// Size medium should cost 1.74
        /// </summary>
        [InlineData(Size.Medium, 1.74)]
        /// <summary>
        /// Size large should cost 2.07
        /// </summary>
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(price, soda.Price);
        }

        [Theory]
        /// <summary>
        /// Size small should have 117 calories
        /// </summary>
        [InlineData(Size.Small, 117)]
        /// <summary>
        /// Size small should have 153 calories
        /// </summary>
        [InlineData(Size.Medium, 153)]
        /// <summary>
        /// Size small should have 205 calories
        /// </summary>
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(cal, soda.Calories);
        }

        [Theory]
        /// <summary>
        /// ice included
        /// </summary>
        [InlineData(true)]
        /// <summary>
        /// Ice witheld 
        /// </summary>
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", soda.SpecialInstructions);
            if (includeIce) Assert.Empty(soda.SpecialInstructions);
        }
        
        [Theory]
        /// <summary>
        /// All sizes for cherry flavor
        /// </summary>
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]
        /// <summary>
        /// All sizes for blackberry flavor
        /// </summary>
        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]
        /// <summary>
        /// All sizes for grapefruit flavor
        /// </summary>
        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]
        /// <summary>
        /// All sizes for lemon flavor
        /// </summary>
        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]
        /// <summary>
        /// All sizes for peach flavor.  Had to fix this 
        /// </summary>
        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]
        /// <summary>
        /// All sizes for watermelon flavor
        /// </summary>
        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = flavor;
            soda.Size = size;
            Assert.Equal(name, soda.ToString());
        }
    }
}
