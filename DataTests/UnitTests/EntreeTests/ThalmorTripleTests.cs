/*
 * Author: Zachery Brunner
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
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}