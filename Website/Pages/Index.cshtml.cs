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
        /// Property for the all available entrees on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Entrees 
        { 
            get=> Menu.Entrees();
            
        }
        /// <summary>
        /// Property for all available sides on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Sides
        {
            get => Menu.Sides();
        }
        /// <summary>
        /// Property for all available drinks on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Drinks
        {
            get => Menu.Drinks();
        }
        /// <summary>
        /// Gets an array of all soda flavors available for the sailor soda
        /// </summary>
        public Array SodaFlavors
        {
            get => Enum.GetValues(typeof(BleakwindBuffet.Data.Enums.SodaFlavor));
        }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
