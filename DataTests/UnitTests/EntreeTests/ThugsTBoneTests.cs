/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Entree should inherit/implement from base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tBone);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Equal(6.44, tBone.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Equal(982, (double)tBone.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Empty(tBone.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tBone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tBone.ToString());
        }
    }
}