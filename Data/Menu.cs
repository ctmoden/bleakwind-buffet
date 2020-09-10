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
            return drinks;
        }
    }
}
