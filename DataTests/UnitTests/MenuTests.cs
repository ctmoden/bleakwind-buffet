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
            Assert.Collection(Menu.Entrees(),)

        }
    }
}
