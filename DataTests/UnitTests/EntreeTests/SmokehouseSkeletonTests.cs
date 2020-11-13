/*
 * Author: Zachery Brunner
 * Modified by: Christian Moden
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ChangingSausageNotifiesSausageProperty()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "SausageLink", () =>
            {
                skeleton.SausageLink = true;
            });
            Assert.PropertyChanged(skeleton, "SausageLink", () =>
            {
                skeleton.SausageLink = false;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "Egg", () =>
            {
                skeleton.Egg = true;
            });
            Assert.PropertyChanged(skeleton, "Egg", () =>
            {
                skeleton.Egg = false;
            });
        }
        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "HashBrowns", () =>
            {
                skeleton.HashBrowns = true;
            });
            Assert.PropertyChanged(skeleton, "HashBrowns", () =>
            {
                skeleton.HashBrowns = false;
            });
        }
        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "Pancake", () =>
            {
                skeleton.Pancake = true;
            });
            Assert.PropertyChanged(skeleton, "Pancake", () =>
            {
                skeleton.Pancake = false;
            });
        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () =>
            {
                skeleton.SausageLink = false;
            });
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () =>
            {
                skeleton.Egg = false;
            });
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () =>
            {
                skeleton.HashBrowns = false;
            });
            Assert.PropertyChanged(skeleton, "SpecialInstructions", () =>
            {
                skeleton.Pancake = false;
            });

        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(skeleton);
        }
        [Fact]
        public void ShouldBeAnIorderable()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(skeleton);
        }
        /// <summary>
        /// Entree should inherit/implement from base Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(skeleton);
        }
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
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.Equal(5.62, smoke.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.Equal(602, (double)smoke.Calories);
        }
        
        [Theory]
        /// <summary>
        /// Parameters set all respective properties to true
        /// </summary>
        [InlineData(true, true, true, true)]
        /// <summary>
        /// Parameters set all respective properties to false
        /// </summary>
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.SausageLink = includeSausage;
            smoke.Egg = includeEgg;
            smoke.HashBrowns = includeHashbrowns;
            smoke.Pancake = includePancake;
            if (!includePancake) Assert.Contains("Hold pancakes", smoke.SpecialInstructions);
            if (!includeSausage) Assert.Contains("Hold sausage", smoke.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", smoke.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", smoke.SpecialInstructions);
            if (includeEgg && includeHashbrowns && includePancake && includeSausage) Assert.Empty(smoke.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", smoke.ToString());

        }
        [Fact]
        public void ShouldReturnCorectDescription()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", 
                smoke.Description);
        }
    }
}