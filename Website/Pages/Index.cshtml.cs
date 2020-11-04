using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// String for user search text
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }
        /// <summary>
        /// Full collection of order items
        /// </summary>
        //[BindProperty(SupportsGet = true)]
        public IEnumerable<IOrderItem> Items { get; set; }
        /// <summary>
        /// Max calories in a search
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMax { get; set; }
        /// <summary>
        /// Minimun Calories in a search
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMin { get; set; }
        /// <summary>
        /// Max price in a user search
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }
        /// <summary>
        /// Min price for a search
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }
        /// <summary>
        /// Possible menu categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        private IEnumerable<IOrderItem> entrees = Menu.Entrees();
        /// <summary>
        /// Property for the all available entrees on the menu
        /// </summary>
        
        public IEnumerable<IOrderItem> Entrees 
        { 
            get=> entrees;
            set
            {
                entrees = value;
            }
            
        }
        private IEnumerable<IOrderItem> sides = Menu.Sides();
        /// <summary>
        /// Property for all available sides on the menu
        /// </summary>
        
        public IEnumerable<IOrderItem> Sides
        {
            get => sides;
            set
            {
                sides = value;
            }
        }
        private IEnumerable<IOrderItem> drinks = Menu.Drinks();
        /// <summary>
        /// Property for all available drinks on the menu.
        /// </summary>
        
        public IEnumerable<IOrderItem> Drinks
        {
            get => drinks;
            set
            {
                drinks = value;
            }
        }
        /// <summary>
        /// gets full menu of items
        /// </summary>
        public IEnumerable<IOrderItem> FullMenu
        {
            get => Menu.FullMenu();
        }
        /// <summary>
        /// Gets an array of all soda flavors available for the sailor soda
        /// </summary>
        public Array SodaFlavors => Enum.GetValues(typeof(BleakwindBuffet.Data.Enums.SodaFlavor));
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        
        public void OnGet()
        {
            Entrees = Menu.Search(SearchTerms, Entrees);
            Sides = Menu.Search(SearchTerms,Sides);
            Drinks = Menu.Search(SearchTerms,Drinks);
            Entrees = Menu.FilterByCalories(Entrees, CaloriesMin, CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, CaloriesMin, CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, CaloriesMin, CaloriesMax);
            Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
            Sides = Menu.FilterByPrice(Sides, PriceMin, PriceMax);
            Drinks = Menu.FilterByPrice(Drinks, PriceMin, PriceMax);
            Entrees = Menu.FilterByCategory(Entrees, Categories);
            Drinks = Menu.FilterByCategory(Drinks, Categories);
            Sides = Menu.FilterByCategory(Sides, Categories);
        }
    }
}
