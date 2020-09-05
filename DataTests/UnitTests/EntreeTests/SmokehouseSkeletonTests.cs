/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.SausageLink = true;
            Assert.True(smoke.SausageLink);
            smoke.SausageLink = false;
            Assert.False(smoke.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.Egg = true;
            Assert.True(smoke.Egg);
            smoke.Egg = false;
            Assert.False(smoke.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.HashBrowns = true;
            Assert.True(smoke.HashBrowns);
            smoke.HashBrowns = false;
            Assert.False(smoke.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.Pancake = true;
            Assert.True(smoke.Pancake);
            smoke.Pancake = false;
            Assert.False(smoke.Pancake);
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
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}