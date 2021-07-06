using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgChestMVC.web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewListOfItems()
        {
            List<Item> items = new List<Item>();
            //Rarity określone "na sztywno" //
            StructRarity rarity = new StructRarity();

            rarity.BonusMultiplier = 1;
            rarity.ItemRarity = EnumRarity.Common;

            StructRarity rarity2;
            rarity2.BonusMultiplier = 2;
            rarity2.ItemRarity = EnumRarity.Legendary;

            items.Add(new Item() { Id = 1, ItemLvl = 2,  Rarity = rarity, Concetration = 2,});
                
            items.Add(new Item() { Id = 2, ItemLvl = 4, Rarity = rarity2, Concetration = 4 });
            items.Add(new Item() { Id = 3, ItemLvl = 6, Rarity = rarity, Concetration = 6 });
            items.Add(new Item() { Id = 4, ItemLvl = 8, Rarity = rarity2, Concetration = 8 });

            return View(items);

        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
