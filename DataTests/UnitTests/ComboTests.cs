using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = aj;

            });
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = coffee;

            });
        }
        [Fact]
        public void ChangingDrinkPriceChangesPriceProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = aj;

            });
        }
        [Fact]
        public void ChangingDrinkCaloriesChanhgesCaloriesProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = aj;

            });
        }
        [Fact]
        public void ChangingDrinkInstructionsChangesInstructionsProprty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = aj;

            });
        }
        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = b;

            });
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = dd;

            });
        }
        [Fact]
        public void ChangingEntreePriceChangesPriceProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger b = new BriarheartBurger();

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = b;

            });
        }
        [Fact]
        public void ChangingEntreeCaloriesChanhgesCaloriesProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = b;

            });
        }
        [Fact]
        public void ChangingEntreeInstructionsChangesInstructionsProprty()
        {
            Combo combo = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = b;

            });
        }
        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            DragonbornWaffleFries f = new DragonbornWaffleFries();
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = f;

            });
            FriedMiraak miraak = new FriedMiraak();
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = miraak;

            });
        }
        [Fact]
        public void ChangingSideCaloriesChanhgesCaloriesProperty()
        {
            Combo combo = new Combo();
            DragonbornWaffleFries f = new DragonbornWaffleFries();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = f;

            });
        }
        [Fact]
        public void ChangingSidePriceChangesPriceProperty()
        {
            Combo combo = new Combo();
            DragonbornWaffleFries f = new DragonbornWaffleFries();

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side= f;

            });
        }
        [Fact]
        public void ChangingSideCaloriesChangesCaloriesProperty()
        {
            Combo combo = new Combo();
            FriedMiraak f = new FriedMiraak();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = f; ;

            });
        }
        [Fact]
        public void ChangingSideInstructionsChangesInstructionsProprty()
        {
            Combo combo = new Combo();
            FriedMiraak f = new FriedMiraak();
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = f;

            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ShouldGetCorrectPrice()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();
            Assert.Equal(6.36, c.Price);
        }
        [Fact] 
        public void ShouldGetCorrectCalories()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();
            Assert.Equal((uint)864, c.Calories);
        }
        [Fact]
        public void ShouldGetCorrectInstructions()
        {

        }
    }
}
