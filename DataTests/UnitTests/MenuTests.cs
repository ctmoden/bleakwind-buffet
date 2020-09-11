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
        public void DrinksMethodShouldReturnIEnumerable()
        {
            
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            Assert.Collection(drinks,
                item=> item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),

                );
            
            
        }
        [Fact]
        public void MenuShouldReturnIEnumerable()
        {

        }
    }
}
