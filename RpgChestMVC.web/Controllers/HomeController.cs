
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
        private readonly IFullArmorService _fullArmorService;

        public HomeController(ILogger<HomeController> logger, IFullArmorService fullArmorService)
        {
            _logger = logger;
            _fullArmorService = fullArmorService;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Im in Home/Index");
            _fullArmorService.GetAllFullArmors();
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Im in Home/Privacy");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {


            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}