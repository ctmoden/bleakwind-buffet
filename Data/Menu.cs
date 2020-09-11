using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// static class representing the menu of bleakwind buffett
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates an instance of every available entree and returns that collection
        /// </summary>
        /// <returns>list of all available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            
            List<IOrderItem> entrees = new List<IOrderItem>();           
            BriarheartBurger burger = new BriarheartBurger();
            entrees.Add(burger);
            DoubleDraugr dd = new DoubleDraugr();
            entrees.Add(dd);
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            entrees.Add(omelette);
            PhillyPoacher philly = new PhillyPoacher();
            entrees.Add(philly);
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            entrees.Add(skeleton);
            ThalmorTriple triple = new ThalmorTriple();
            entrees.Add(triple);
            ThugsTBone tBone = new ThugsTBone();
            entrees.Add(tBone);
            return entrees;
        }
        /// <summary>
        /// Creates an instance of every available side (in all sizes) and returns a collection of those objects
        /// </summary>
        /// <returns>list of all available sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries smallFries = new DragonbornWaffleFries
            {
                Size = Size.Small
            };
            sides.Add(smallFries);
            DragonbornWaffleFries medFries = new DragonbornWaffleFries
            {
                Size = Size.Medium
            };
            sides.Add(medFries);
            DragonbornWaffleFries largeFries = new DragonbornWaffleFries
            {
                Size = Size.Large
            };
            sides.Add(largeFries);

            FriedMiraak smallMiraak = new FriedMiraak
            {
                Size = Size.Small
            };
            sides.Add(smallMiraak);
            FriedMiraak medMiraak = new FriedMiraak
            {
                Size = Size.Medium
            };
            sides.Add(medMiraak);

            FriedMiraak largeMiraak = new FriedMiraak
            {
                Size = Size.Large
            
            };
            sides.Add(largeMiraak);

            MadOtarGrits smallGrits = new MadOtarGrits
            {
                Size = Size.Small
            };
            sides.Add(smallGrits);
            MadOtarGrits medGrits = new MadOtarGrits
            {
                Size = Size.Medium
            };
            sides.Add(medGrits);

            MadOtarGrits largeGrits = new MadOtarGrits
            {
                Size = Size.Large
            };

            sides.Add(largeGrits);

            VokunSalad smallSalad = new VokunSalad()
            {
                Size = Size.Small
            };
            sides.Add(smallSalad);
            VokunSalad medSalad = new VokunSalad
            {
                Size = Size.Medium
            };
            sides.Add(medSalad);
            VokunSalad largeSalad = new VokunSalad
            {
                Size = Size.Large
            };
            sides.Add(largeSalad);
            return sides;
        }
        /// <summary>
        /// Creates an instance of every available drink and stores results in a list
        /// </summary>
        /// <returns>List of all available drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            //TODO: is it a problem if list is immutable as opposed to an instantiated IEnumerable?
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice smallAj = new AretinoAppleJuice
            {
                Size = Size.Small
            };
            drinks.Add(smallAj);
            AretinoAppleJuice medAj = new AretinoAppleJuice
            {
                Size = Size.Medium
            };
            drinks.Add(medAj);
            AretinoAppleJuice largeAj = new AretinoAppleJuice
            {
                Size = Size.Large
            };
            drinks.Add(largeAj);


            CandlehearthCoffee smallCoffee = new CandlehearthCoffee
            {
                Size = Size.Small
            };
            drinks.Add(smallCoffee);
            CandlehearthCoffee medCoffee = new CandlehearthCoffee
            {
                Size = Size.Medium
            };
            drinks.Add(medCoffee);
            CandlehearthCoffee largeCoffee = new CandlehearthCoffee
            {
                Size = Size.Large
            };
            drinks.Add(largeCoffee);

            MarkarthMilk smallMilk = new MarkarthMilk()
            {
                Size = Size.Small
            };
            drinks.Add(smallMilk);
            MarkarthMilk medMilk = new MarkarthMilk()
            {
                Size = Size.Medium
            };
            drinks.Add(medMilk);
            MarkarthMilk largeMilk = new MarkarthMilk()
            {
                Size = Size.Large
            };
            drinks.Add(largeMilk);

            SailorSoda smallBlackberrySoda = new SailorSoda()
            {
                Size = Size.Small
            
            };
            smallBlackberrySoda.Flavor = SodaFlavor.Blackberry;
            drinks.Add(smallBlackberrySoda);
            SailorSoda medBlackberrySoda = new SailorSoda()
            {
                Size = Size.Medium
            };
            medBlackberrySoda.Flavor = SodaFlavor.Blackberry;
            drinks.Add(medBlackberrySoda);
            SailorSoda largeBlackberrySoda = new SailorSoda()
            {
                Size = Size.Large
            };
            largeBlackberrySoda.Flavor = SodaFlavor.Blackberry;
            drinks.Add(largeBlackberrySoda);
            SailorSoda smallCherrySoda = new SailorSoda()
            {
                Size = Size.Small
            };
            smallCherrySoda.Flavor = SodaFlavor.Cherry;
            drinks.Add(smallCherrySoda);
            SailorSoda medCherrySoda = new SailorSoda()
            {
                Size = Size.Medium
            };
            medCherrySoda.Flavor = SodaFlavor.Cherry;
            drinks.Add(medCherrySoda);
            SailorSoda largeCherrySoda = new SailorSoda()
            {
                Size = Size.Large
            };
            largeCherrySoda.Flavor = SodaFlavor.Cherry;
            drinks.Add(largeCherrySoda);

            SailorSoda smallGrapefruitSoda = new SailorSoda()
            {
                Size = Size.Small
            };
            smallGrapefruitSoda.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(smallGrapefruitSoda);
            SailorSoda medGrapefruitSoda = new SailorSoda()
            {
                Size = Size.Medium
            };
            medGrapefruitSoda.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(medGrapefruitSoda);
            SailorSoda largeGrapefruitSoda = new SailorSoda()
            {
                Size = Size.Large
            };
            largeGrapefruitSoda.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(largeGrapefruitSoda);

            SailorSoda smallLemonSoda = new SailorSoda()
            {
                Size = Size.Small
            };
            smallLemonSoda.Flavor = SodaFlavor.Lemon;
            drinks.Add(smallLemonSoda);
            SailorSoda medLemonSoda = new SailorSoda()
            {
                Size = Size.Medium
            };
            medLemonSoda.Flavor = SodaFlavor.Lemon;
            drinks.Add(medLemonSoda);
            SailorSoda largeLemonSoda = new SailorSoda()
            {
                Size = Size.Large
            };
            largeLemonSoda.Flavor = SodaFlavor.Lemon;
            drinks.Add(largeLemonSoda);

            SailorSoda smallPeachSoda = new SailorSoda()
            {
                Size = Size.Small
            };
            smallPeachSoda.Flavor = SodaFlavor.Peach;
            drinks.Add(smallPeachSoda);
            SailorSoda medPeachSoda = new SailorSoda()
            {
                Size = Size.Medium
            };
            medPeachSoda.Flavor = SodaFlavor.Peach;
            drinks.Add(medPeachSoda);
            SailorSoda largePeachSoda = new SailorSoda()
            {
                Size = Size.Large
            };
            largePeachSoda.Flavor = SodaFlavor.Peach;
            drinks.Add(largePeachSoda);

            SailorSoda smallWatermelonSoda = new SailorSoda()
            {
                Size = Size.Small
            };
            smallWatermelonSoda.Flavor = SodaFlavor.Watermelon;
            drinks.Add(smallWatermelonSoda);
            SailorSoda medWatermelonSoda = new SailorSoda()
            {
                Size = Size.Medium
            };
            medWatermelonSoda.Flavor = SodaFlavor.Watermelon;
            drinks.Add(medWatermelonSoda);
            SailorSoda largeWatermelonSoda = new SailorSoda()
            {
                Size = Size.Large
            };
            largeWatermelonSoda.Flavor = SodaFlavor.Watermelon;
            drinks.Add(largeWatermelonSoda);

            WarriorWater smallWater = new WarriorWater()
            {
                Size = Size.Small
            };
            drinks.Add(smallWater);
            WarriorWater medWater = new WarriorWater()
            {
                Size = Size.Medium
            };
            drinks.Add(medWater);
            WarriorWater largeWater = new WarriorWater()
            {
                Size = Size.Large
            };
            drinks.Add(largeWater);
            return drinks;
            
        }
        /// <summary>
        /// Collects a full menu from all available items on the menu
        /// </summary>
        /// <returns>Dictionary containing all entrees, sides, and drinks, with keys associating each type of item with all available versions</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();
            menuList.AddRange(Entrees());
            menuList.AddRange(Sides());
            menuList.AddRange(Drinks());
            return menuList;
                //menuList [[list], [list], [list]]
            

            /*
            Dictionary<string, IEnumerable<IOrderItem>> menuDictionary= new Dictionary<string, IEnumerable<IOrderItem>>();
            IEnumerable<IOrderItem> entrees = Entrees();
            menuDictionary.Add("Entrees",entrees);
            IEnumerable<IOrderItem> sides = Sides();
            menuDictionary.Add("Sides", sides);
            IEnumerable<IOrderItem> drinks = Drinks();
            menuDictionary.Add("Drinks", drinks);
            //FIXME will this cast actually work?
            return (IEnumerable<IOrderItem>) menuDictionary;
            */

        }
    }
}
