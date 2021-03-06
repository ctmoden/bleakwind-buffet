﻿/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Bun = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mustard = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Pickle = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Cheese = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Tomato = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Lettuce = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () =>
            {
                dd.Mayo = false;
            });
            
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }
        /// <summary>
        /// Entree should inherit/implement from base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843, (double)dd.Calories);
        }
        
        
        [Theory]
        /// <summary>
        /// boolean variables will set respective properties in test to true
        /// </summary>
        [InlineData(true, true, true, true, true, true, true, true)]
        /// <summary>
        /// Variables will set respective properties to false 
        /// </summary>
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            dd.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            dd.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            dd.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            dd.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            dd.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            dd.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            dd.Mayo = includeMayo;
            if (!dd.Mayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            if (includeBun && includeCheese && includeKetchup && includeLettuce && includeMayo
                && includeMustard && includePickle && includeTomato) Assert.Empty(dd.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
        [Fact]
        public void ShouldReturnCorectDescription()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", dd.Description);
        }
    }
}