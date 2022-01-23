using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
    public class WeaponController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
