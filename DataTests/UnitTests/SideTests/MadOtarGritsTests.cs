﻿/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.PropertyChanged(grits, "Size", () =>
            {
                grits.Size = Size.Small;
            });
            Assert.PropertyChanged(grits, "Size", () =>
            {
                grits.Size = Size.Medium;
            });
            Assert.PropertyChanged(grits, "Size", () =>
            {
                grits.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.PropertyChanged(grits, "Calories", () =>
            {
                grits.Size = Size.Small;
            });
            Assert.PropertyChanged(grits, "Calories", () =>
            {
                grits.Size = Size.Medium;
            });
            Assert.PropertyChanged(grits, "Calories", () =>
            {
                grits.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.PropertyChanged(grits, "Price", () =>
            {
                grits.Size = Size.Small;
            });
            Assert.PropertyChanged(grits, "Price", () =>
            {
                grits.Size = Size.Medium;
            });
            Assert.PropertyChanged(grits, "Price", () =>
            {
                grits.Size = Size.Large;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(grits);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(grits);
        }
        /// <summary>
        /// Side should inherit/implement from base Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(grits);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Equal(Size.Small, grits.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = Size.Small;
            Assert.Equal(Size.Small, grits.Size);
            grits.Size = Size.Medium;
            Assert.Equal(Size.Medium, grits.Size);
            grits.Size = Size.Large;
            Assert.Equal(Size.Large, grits.Size);
            grits.Size = Size.Small;
            Assert.Equal(Size.Small, grits.Size);

        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Empty(grits.SpecialInstructions);
        }

        [Theory]
        /// <summary>
        /// small should cost 1.22
        /// </summary>
        [InlineData(Size.Small, 1.22)]
        /// <summary>
        /// medium should cost 1.58
        /// </summary>
        [InlineData(Size.Medium, 1.58)]
        /// <summary>
        /// large should cost 1.93
        /// </summary>
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(price, grits.Price);
        }

        [Theory]
        /// <summary>
        /// small should have 105 cals
        /// </summary>
        [InlineData(Size.Small, 105)]
        /// <summary>
        /// medium should have 142 cals
        /// </summary>
        [InlineData(Size.Medium, 142)]
        /// <summary>
        /// large should have 179 cals
        /// </summary>
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(calories, grits.Calories);
        }

        [Theory]
        /// <summary>
        /// Small to string return
        /// </summary>
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        /// <summary>
        /// Medium to string return
        /// </summary>
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        /// <summary>
        /// Large to string return
        /// </summary>
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(name, grits.ToString());
        }
        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Equal("Cheesy Grits.", grits.Description);
        }
    }
}