/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Bun);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.True(triple.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Bun = true;
            Assert.True(triple.Bun);
            triple.Bun = false;
            Assert.False(triple.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Ketchup = true;
            Assert.True(triple.Ketchup);
            triple.Ketchup = false;
            Assert.False(triple.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Bun = true;
            Assert.True(triple.Bun);
            triple.Bun = false;
            Assert.False(triple.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Pickle = true;
            Assert.True(triple.Pickle);
            triple.Pickle = false;
            Assert.False(triple.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Cheese = true;
            Assert.True(triple.Cheese);
            triple.Cheese = false;
            Assert.False(triple.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Tomato = true;
            Assert.True(triple.Tomato);
            triple.Tomato = false;
            Assert.False(triple.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Lettuce = true;
            Assert.True(triple.Lettuce);
            triple.Lettuce = false;
            Assert.False(triple.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Mayo = true;
            Assert.True(triple.Mayo);
            triple.Mayo = false;
            Assert.False(triple.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Bacon = true;
            Assert.True(triple.Bacon);
            triple.Bacon = false;
            Assert.False(triple.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Egg = true;
            Assert.True(triple.Egg);
            triple.Egg = false;
            Assert.False(triple.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.Equal(8.32, triple.Price);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.Equal(943, (double)triple.Calories);
        }

        [Theory]
        /// <summary>
        /// Parameters set all respective properties to true
        /// </summary>
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        /// <summary>
        /// Parameters set all respective properties to false
        /// </summary>
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple triple = new ThalmorTriple();
            triple.Bun = includeBun;
            triple.Ketchup = includeKetchup;
            triple.Mustard = includeMustard;
            triple.Pickle = includePickle;
            triple.Cheese = includeCheese;
            triple.Tomato = includeTomato;
            triple.Lettuce = includeLettuce;
            triple.Mayo = includeMayo;
            triple.Bacon = includeBacon;
            triple.Egg = includeEgg;
            if (!includeBun) Assert.Contains("Hold bun", triple.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", triple.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", triple.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", triple.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", triple.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", triple.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", triple.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", triple.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", triple.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", triple.SpecialInstructions);
            if (includeBacon && includeBun && includeCheese && includeEgg && includeKetchup
                && includeLettuce && includeMayo && includeMustard && includePickle && includeTomato)
                Assert.Empty(triple.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple triple = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", triple.ToString());
        }
    }
}