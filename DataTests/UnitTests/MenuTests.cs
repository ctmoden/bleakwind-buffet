﻿/*
 * Author:  Christian Moden
 * Class: MenuTests.cs
 * Purpose: Tests the Menu.cs class methods 
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using Xunit.Sdk;

namespace BleakwindBuffet.DataTests.MenuTests
{
    /// <summary>
    /// Tests the menu class methods for correct return types
    /// </summary>
    public class MenuTests
    {


        [Fact]
        public void EntreesMethodShouldReturnIEnumerable()
        {
            //create another method for checking list length
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            Assert.Collection(entrees,
                item => item.ToString().Contains("Briarheart Burger"),
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Garden Orc Omelette"),
                item => item.ToString().Contains("Philly Poacher"),
                item => item.ToString().Contains("Smokehouse Skeleton"),
                item => item.ToString().Contains("Thalmor Triple"),
                item => item.ToString().Contains("Thugs T-Bone")

                );



        }
        [Fact]
        public void EntreeListShouldBeCorrectLength()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            Assert.Equal(7, entrees.Count());
        }

        [Fact]
        public void SidesMethodShouldReturnIEnumerable()
        {

            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Collection(sides,
                item => item.ToString().Contains("Small Dragonborn Waffle Fies"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Large Fried Miraak"),
                item => item.ToString().Contains("Small Mad Otar Grits"),
                item => item.ToString().Contains("Medium Mad Otar Grits"),
                item => item.ToString().Contains("Large Mad Otar Grits"),
                item => item.ToString().Contains("Small Vokun Salad"),
                item => item.ToString().Contains("Medium Vokun Salad"),
                item => item.ToString().Contains("Large Vokun Salad")
                );
        }
        [Fact]
        public void SideListShouldBeCorrectLength()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Equal(12, sides.Count());
        }
        [Fact]
        public void DrinksMethodShouldReturnIEnumerable()
        {

            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            Assert.Collection(drinks,
                item => item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),
                item => item.ToString().Contains("Small Candlehearth Coffee"),
                item => item.ToString().Contains("Medium Candlehearth Coffee"),
                item => item.ToString().Contains("Large Candlehearth Coffee"),
                item => item.ToString().Contains("Small Markarth Milk"),
                item => item.ToString().Contains("Medium Markarth Milk"),
                item => item.ToString().Contains("Large Markarth Milk"),
                item => item.ToString().Contains("Small Blackberry Sailor Soda"),
                item => item.ToString().Contains("Medium Blackberry Sailor Soda"),
                item => item.ToString().Contains("Large Blackberry Sailor Soda"),
                item => item.ToString().Contains("Small Cherry Sailor Soda"),
                item => item.ToString().Contains("Medium Cherry Sailor Soda"),
                item => item.ToString().Contains("Large Cherry Sailor Soda"),
                item => item.ToString().Contains("Small Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Medium Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Large Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Small Lemon Sailor Soda"),
                item => item.ToString().Contains("Medium Lemon Sailor Soda"),
                item => item.ToString().Contains("Large Lemon Sailor Soda"),
                item => item.ToString().Contains("Small Peach Sailor Soda"),
                item => item.ToString().Contains("Medium Peach Sailor Soda"),
                item => item.ToString().Contains("Large Peach Sailor Soda"),
                item => item.ToString().Contains("Small Watermelon Sailor Soda"),
                item => item.ToString().Contains("Medium Watermelon Sailor Soda"),
                item => item.ToString().Contains("Large Watermelon Sailor Soda"),
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Warrior Water")
                );


        }
        [Fact]
        public void DrinkListShouldBeCorrectLength()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            Assert.Equal(30, drinks.Count());
        }
        [Fact]
        public void MenuShouldReturnIEnumerable()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            Assert.Collection(fullMenu,
                item => item.ToString().Contains("Briarheart Burger"),
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Garden Orc Omelette"),
                item => item.ToString().Contains("Philly Poacher"),
                item => item.ToString().Contains("Smokehouse Skeleton"),
                item => item.ToString().Contains("Thalmor Triple"),
                item => item.ToString().Contains("Thugs T-Bone"),
                item => item.ToString().Contains("Small Dragonborn Waffle Fies"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Large Fried Miraak"),
                item => item.ToString().Contains("Small Mad Otar Grits"),
                item => item.ToString().Contains("Medium Mad Otar Grits"),
                item => item.ToString().Contains("Large Mad Otar Grits"),
                item => item.ToString().Contains("Small Vokun Salad"),
                item => item.ToString().Contains("Medium Vokun Salad"),
                item => item.ToString().Contains("Large Vokun Salad"),
                item => item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),
                item => item.ToString().Contains("Small Candlehearth Coffee"),
                item => item.ToString().Contains("Medium Candlehearth Coffee"),
                item => item.ToString().Contains("Large Candlehearth Coffee"),
                item => item.ToString().Contains("Small Markarth Milk"),
                item => item.ToString().Contains("Medium Markarth Milk"),
                item => item.ToString().Contains("Large Markarth Milk"),
                item => item.ToString().Contains("Small Blackberry Sailor Soda"),
                item => item.ToString().Contains("Medium Blackberry Sailor Soda"),
                item => item.ToString().Contains("Large Blackberry Sailor Soda"),
                item => item.ToString().Contains("Small Cherry Sailor Soda"),
                item => item.ToString().Contains("Medium Cherry Sailor Soda"),
                item => item.ToString().Contains("Large Cherry Sailor Soda"),
                item => item.ToString().Contains("Small Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Medium Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Large Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Small Lemon Sailor Soda"),
                item => item.ToString().Contains("Medium Lemon Sailor Soda"),
                item => item.ToString().Contains("Large Lemon Sailor Soda"),
                item => item.ToString().Contains("Small Peach Sailor Soda"),
                item => item.ToString().Contains("Medium Peach Sailor Soda"),
                item => item.ToString().Contains("Large Peach Sailor Soda"),
                item => item.ToString().Contains("Small Watermelon Sailor Soda"),
                item => item.ToString().Contains("Medium Watermelon Sailor Soda"),
                item => item.ToString().Contains("Large Watermelon Sailor Soda"),
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Warrior Water")

                );

        }
        [Fact]
        public void FullMenuShouldBeCorrectLength()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            Assert.Equal(49, fullMenu.Count());
        }
        private static readonly IOrderItem[] EntreeItems = new List<IOrderItem> { new BriarheartBurger() }.ToArray();
        
        [Theory]
        [InlineData("Burger", "Briarheart Burger")]
        [InlineData("Thalmor", "Thalmor Triple")]
        [InlineData("Double", "Double Draugr")]
        [InlineData("Skeleton", "Smokehouse Skeleton")]
        [InlineData("Orc", "Garden Orc Omelette")]
        [InlineData("Philly", "Philly Poacher")]
        [InlineData("Thugs", "Thugs T-Bone")]
        public void ShouldReturnCorrectSearchResultsForEntreeSearch(string search, string name)
        {
            IEnumerable<IOrderItem> entreeSearch = Menu.Search(search, Menu.Entrees());
            Assert.Collection(entreeSearch,
                item => item.Name.Equals(name)
                );
        }

        [Fact]//make a theory here
        public void ShouldReturnCorrectSearchResultsForSideSearch()
        {
            IEnumerable<IOrderItem> sideSearch = Menu.Search("Grits", Menu.Sides());
            Assert.Collection(sideSearch,
                item => item.Name.Equals("Small Mad Otar Grits"),
                item => item.Name.Equals("Medium Mad Otar Grits"),
                item => item.Name.Equals("Large Mad Otar Grits")
                );

        }
        [Fact]
        public void ShouldReturnCorrectSearchResultsForDrinkSearch()
        {
            IEnumerable<IOrderItem> drinkSearch = Menu.Search("Warrior", Menu.Drinks());
            Assert.Collection(drinkSearch,
                item => item.Name.Equals("Small Warrior Water"),
                item => item.Name.Equals("Medium Warrior Water"),
                item => item.Name.Equals("Large Warrior Water")
                );

        }
        /// <summary>
        /// Conducts a test on a search where both calorie values are not null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForCalorieRange1()
        {
            IEnumerable<IOrderItem> calorieSearch = Menu.FilterByCalories(Menu.Entrees(), 700, 800);
            Assert.Collection(calorieSearch,
                item => item.Name.Equals("Briarheart Burger"),
                item => item.Name.Equals("Philly Poacher")
                );            
        }
        /// <summary>
        /// Conducts a test on a search where max calorie value is null and the min is not null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForCalorieRange2()
        {
            IEnumerable<IOrderItem> calorieSearch = Menu.FilterByCalories(Menu.Entrees(), 800, null);
            Assert.Collection(calorieSearch,
                item => item.Name.Equals("Double Draugr"),
                item => item.Name.Equals("Thalmor Triple"),
                item => item.Name.Equals("Thugs T-Bone")
                );
        }
        /// <summary>
        /// conducts a test on  a search where the min calorie value is null and max is not null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForCalorieRange3()
        {
            IEnumerable<IOrderItem> calorieSearch = Menu.FilterByCalories(Menu.Entrees(), null, 700);
            Assert.Collection(calorieSearch,
                item => item.Name.Equals("Garden Orc Omelette"),
                item => item.Name.Equals("Smokehouse Skeleton")
                );
        }
        /// <summary>
        /// conducts a calorie search when both min and max are null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForCalorieRange4()
        {
            IEnumerable<IOrderItem> calorieSearch = Menu.FilterByCalories(Menu.Entrees(), null, null);
            Assert.Collection(calorieSearch,
                item => item.Name.Equals("Briarheart Burger"),
                item => item.Name.Equals("Double Draugr"),
                item => item.Name.Equals("Garden Orc Omelette"),
                item => item.Name.Equals("Philly Poacher"),
                item => item.Name.Equals("Smokehouse Skeleton"),
                item => item.Name.Equals("Thalmor Triple"),
                item => item.Name.Equals("Thugs T-Bone")

                );
        }
        /// <summary>
        /// Conducts a test on a search where both price values are not null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForPriceRange1()
        {
            IEnumerable<IOrderItem> priceSearch = Menu.FilterByPrice(Menu.Entrees(), 6.0, 7.0);
            Assert.Collection(priceSearch,
                item=>item.Name.Equals("Briarheart Burger"),
                item => item.Name.Equals("Thugs T-Bone")
                );
        }
        /// <summary>
        /// conducts a test on a search where max price is null and min price is not null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForPriceRange2()
        {
            IEnumerable<IOrderItem> priceSearch = Menu.FilterByPrice(Menu.Entrees(), 8.0, null);
            Assert.Collection(priceSearch,
                item=>item.Name.Equals("Thalmor Triple")

                );
        }
        /// <summary>
        /// conducts a test on a search where min price is null and max price is not null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForPriceRange3()
        {
            IEnumerable<IOrderItem> priceSearch = Menu.FilterByPrice(Menu.Entrees(), null, 6);
            Assert.Collection(priceSearch,
                item => item.Name.Equals("Garden Orc Omelette"),
                item => item.Name.Equals("Smokehouse Skeleton")

                );
        }
        /// <summary>
        /// conducts a test on a search where both min and max are null
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCollectionForPriceRange4()
        {
            IEnumerable<IOrderItem> priceSearch = Menu.FilterByPrice(Menu.Entrees(), null, null);
            Assert.Collection(priceSearch,
                item => item.Name.Equals("Briarheart Burger"),
                item => item.Name.Equals("Double Draugr"),
                item => item.Name.Equals("Garden Orc Omelette"),
                item => item.Name.Equals("Philly Poacher"),
                item => item.Name.Equals("Smokehouse Skeleton"),
                item => item.Name.Equals("Thalmor Triple"),
                item => item.Name.Equals("Thugs T-Bone")
                );
        }
    }
}
