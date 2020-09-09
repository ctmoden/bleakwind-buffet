using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

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
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries smallFries = new DragonbornWaffleFries();
            smallFries.Size = Size.Small;
            sides.Add(smallFries);
            DragonbornWaffleFries medFries = new DragonbornWaffleFries();
            medFries.Size = Size.Medium;
            sides.Add(medFries);
            DragonbornWaffleFries largeFries = new DragonbornWaffleFries();
            largeFries.Size = Size.Large;
            sides.Add(largeFries);

            FriedMiraak smallMiraak = new FriedMiraak();
            smallMiraak.Size = Size.Small;
            sides.Add(smallMiraak);
            FriedMiraak medMiraak = new FriedMiraak();
            medMiraak.Size = Size.Medium;
            sides.Add(medMiraak);

            return sides;
        }
    }
}
