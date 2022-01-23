using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
    public class ArmorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
