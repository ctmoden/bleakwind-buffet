/*
 * Author:  Christian Moden
 * Class: Index.cshtml.cs
 * Purpose: Data manager for the website 
 */

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
        
        public string[] Categories { get; set; } = Menu.Categories;

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
        /// Gets an array of all soda flavors available for the sailor soda
        /// </summary>
        public Array SodaFlavors => Enum.GetValues(typeof(SodaFlavor));
        
        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// On get method
        /// </summary>
        /// <param name="Categories"></param>
        public void OnGet(string[] Categories)
        {
            /*
            Entrees = Menu.Search(SearchTerms, Entrees);
            Sides = Menu.Search(SearchTerms,Sides);
            Drinks = Menu.Search(SearchTerms,Drinks);
            */

            if(SearchTerms!=null) SearchTermsQuery();
            if(CaloriesMin != null)
            {
                Entrees = Entrees.Where(entree =>
                entree.Calories >= CaloriesMin);
                Sides = Sides.Where(side =>
                side.Calories >= CaloriesMin);
                Drinks = Drinks.Where(drink =>
                drink.Calories >= CaloriesMin);
            }
            if(CaloriesMax != null)
            {
                Entrees = Entrees.Where(entree =>
                entree.Calories <= CaloriesMax);
                Sides = Sides.Where(side =>
                side.Calories <= CaloriesMax);
                Drinks = Drinks.Where(drink =>
                drink.Calories <= CaloriesMax);
            }
            if(PriceMin != null)
            {
                Entrees = Entrees.Where(entree =>
                entree.Price >= PriceMin);
                Sides = Sides.Where(side =>
                side.Price >= PriceMin);
                Drinks = Drinks.Where(drink =>
                drink.Price >= PriceMin);
            }
            if(PriceMax != null)
            {
                Entrees = Entrees.Where(entree =>
                entree.Price <= PriceMax);
                Sides = Sides.Where(side =>
                side.Price <= PriceMax);
                Drinks = Drinks.Where(drink =>
                drink.Price <= PriceMax);
            }
            /*
            Entrees = Menu.FilterByCalories(Entrees, CaloriesMin, CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, CaloriesMin, CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, CaloriesMin, CaloriesMax);
            
            Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
            Sides = Menu.FilterByPrice(Sides, PriceMin, PriceMax);
            Drinks = Menu.FilterByPrice(Drinks, PriceMin, PriceMax);
            */
            this.Categories = Categories;
        }
        /// <summary>
        /// Uses LINQ queries to filter Entrees, sides, and drinks based on user input search terms
        /// </summary>
        private void SearchTermsQuery()
        {

            Entrees = Entrees.Where(entree =>
            {
                foreach (string term in SearchTerms.Split(' '))
                {
                    
                    if (entree.Name.Contains(term, StringComparison.OrdinalIgnoreCase) || entree.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                return false;
            });
            Sides = Sides.Where(side =>
            {
                foreach (string term in SearchTerms.Split(' '))
                {
                    if (side.Name.Contains(term, StringComparison.OrdinalIgnoreCase) || side.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                return false;
            });

            Drinks = Drinks.Where(drink =>
            {
                foreach(string term in SearchTerms.Split(' '))
                {
                    if (drink.Name.Contains(term, StringComparison.OrdinalIgnoreCase) || drink.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                return false;
            });
        }
    }
}
