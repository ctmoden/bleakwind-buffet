
/*
 * Author:  Christian Moden
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Diagnostics.Contracts;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water.Ice);
        }
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater water = new WarriorWater();
            water.Ice = true;
            Assert.True(water.Ice);
            water.Ice = false;
            Assert.False(water.Ice);
        }
        [Fact]
        public void CaloriesShouldBeZero()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(0, (double)water.Calories);
        }
        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Size.Small, water.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater water = new WarriorWater();
            water.Size = Size.Small;
            Assert.Equal(Size.Small, water.Size);
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
        }
        [Fact]
        public void PriceShouldBeZero()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(0, water.Price);
        }
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater water = new WarriorWater();
            water.Lemon = true;
            Assert.True(water.Lemon);
            water.Lemon = false;
            Assert.False(water.Lemon);
        }
        [Theory]
        /// <summary>
        /// ice and lemon included
        /// </summary>
        [InlineData(true, true)]
        /// <summary>
        /// ice included but not lemon
        /// </summary>
        [InlineData(true, false)]
        /// <summary>
        /// ice is not included but lemon is
        /// </summary>
        [InlineData(false, true)]
        /// <summary>
        /// neither ice nor lemon is included
        /// </summary>
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater water = new WarriorWater();
            if (!includeIce) Assert.Contains("Hold ice", water.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", water.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(water.SpecialInstructions);
        }
        [Theory]
        /// <summary>
        /// small size to string return 
        /// </summary>
        [InlineData(Size.Small, "Small Warrior Water")]
        /// <summary>
        /// medium size to string return 
        /// </summary>
        [InlineData(Size.Medium, "Medium Wariror Water")]
        /// <summary>
        /// large size to string return 
        /// </summary>
        [InlineData(Size.Large, "Large Warrior Water")]

        public void ShouldHaveCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater water = new WarriorWater();
            water.Size = size;
            Assert.Equal(name, water.ToString());

        }




    }
}
