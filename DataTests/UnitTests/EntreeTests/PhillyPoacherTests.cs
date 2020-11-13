/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher poacher = new PhillyPoacher();
            Assert.PropertyChanged(poacher, "Sirloin", () =>
            {
                poacher.Sirloin = true;
            });
            Assert.PropertyChanged(poacher, "Sirloin", () =>
            {
                poacher.Sirloin = false;
            });
        }
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher poacher = new PhillyPoacher();
            Assert.PropertyChanged(poacher, "Onion", () =>
            {
                poacher.Onion = true;
            });
            Assert.PropertyChanged(poacher, "Onion", () =>
            {
                poacher.Onion = false;
            });
        }
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher poacher = new PhillyPoacher();
            Assert.PropertyChanged(poacher, "Roll", () =>
            {
                poacher.Roll = true;
            });
            Assert.PropertyChanged(poacher, "Roll", () =>
            {
                poacher.Roll = false;
            });
        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            PhillyPoacher poacher = new PhillyPoacher();
            Assert.PropertyChanged(poacher, "SpecialInstructions", () =>
            {
                poacher.Sirloin = false;
            });
            Assert.PropertyChanged(poacher, "SpecialInstructions", () =>
            {
                poacher.Onion= false;
            });
            Assert.PropertyChanged(poacher, "SpecialInstructions", () =>
            {
                poacher.Roll = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            PhillyPoacher poacher = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(poacher);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(philly);
        }
        /// <summary>
        /// Entree should inherit/implement from base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(philly);
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Sirloin);

        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = true;
            Assert.True(philly.Sirloin);
            philly.Sirloin = false;
            Assert.False(philly.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Onion = true;
            Assert.True(philly.Onion);
            philly.Onion = false;
            Assert.False(philly.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Roll = true;
            Assert.True(philly.Roll);
            philly.Roll = false;
            Assert.False(philly.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal(7.23, philly.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal(784, (double)philly.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = includeSirloin;
            philly.Onion = includeOnion;
            philly.Roll = includeRoll;
            if (!includeSirloin) Assert.Contains("Hold sirloin", philly.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", philly.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", philly.SpecialInstructions);
            if (includeRoll && includeOnion && includeSirloin) Assert.Empty(philly.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal("Philly Poacher", philly.ToString());
        }
        [Fact]
        public void ShouldReturnCorectDescription()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", philly.Description);
        }
    }
}