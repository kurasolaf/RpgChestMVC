using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgChestMVC.Application.Interfaces;
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

        private readonly IItemService _itemService;
        
        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index(bool isActive)
        {
            _itemService.GetAllItemsForList(isActive);
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

            items.Add(new Item(1,2, rarity,2) { Id = 1, ItemLvl = 2, Rarity = rarity, Concetration = 2,});
            items.Add(new Item(2,4, rarity2,4) { Id = 2, ItemLvl = 4, Rarity = new StructRarity(), Concetration = 4 });
            items.Add(new Item(3,6, rarity,6) { Id = 3, ItemLvl = 6, Rarity = rarity, Concetration = 6 });
            items.Add(new Item(4,8, rarity2,8) { Id = 4, ItemLvl = 8, Rarity = rarity2, Concetration = 8 });

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
