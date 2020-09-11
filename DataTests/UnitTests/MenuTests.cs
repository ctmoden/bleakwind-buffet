/*
 * Author:  Christian Moden
 * Class: Menu.cs
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
                item=> item.ToString().Contains("Briarheart Burger"),
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
                item=> item.ToString().Contains("Small Fried Miraak"),
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
                item=> item.ToString().Contains("Small Aretino Apple Juice"),
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
            IEnumerable<IOrderItem> fulMenu = Menu.FullMenu();

        }
    }
}
