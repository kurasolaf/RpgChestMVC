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
            List<Item> Items = new List<Item>();
            Items.Add(new Item(){Id = 1, Concentration = 6, ItemLvl = 5 });
            Items.Add(new Item() { Id = 2, BonusWill = 4, ItemLvl = 3 });
            Items.Add(new Item() { Id = 3, CritBonusDmg = 9, ItemLvl = 2 });

            return View(Items);
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
