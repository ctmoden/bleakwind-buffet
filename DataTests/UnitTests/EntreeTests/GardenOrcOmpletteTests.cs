﻿/*
 * Author: Zachery Brunner
 * Modifies by: Christian Moden
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = true;
            Assert.True(omelette.Broccoli);
            omelette.Broccoli = false;
            Assert.False(omelette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Mushrooms = true;
            Assert.True(omelette.Mushrooms);
            omelette.Mushrooms = false;
            Assert.False(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Tomato = true;
            Assert.True(omelette.Tomato);
            omelette.Tomato = false;
            Assert.False(omelette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Cheddar = true;
            Assert.True(omelette.Cheddar);
            omelette.Cheddar = false;
            Assert.False(omelette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal(4.57, omelette.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal(404, (double)omelette.Calories);
        }
        
        [Theory]
        /// <summary>
        /// Variables will set respecrive values to true
        /// </summary>
        [InlineData(true, true, true, true)]
        /// <summary>
        /// Variables will set respecrive values to false
        /// </summary>
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = includeBroccoli;
            omelette.Mushrooms = includeMushrooms;
            omelette.Tomato = includeTomato;
            omelette.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", omelette.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", omelette.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", omelette.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", omelette.SpecialInstructions);
            if (includeTomato && includeMushrooms && includeCheddar && includeBroccoli) Assert.Empty(omelette.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", omelette.ToString());
        }
    }
}