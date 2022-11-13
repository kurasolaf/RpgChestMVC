using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
    [Route("FullArmor")]
    
    public class FullArmorController : Controller
    {
        private readonly ILogger _logger;
        private readonly IFullArmorService _itService;

        public FullArmorController(IFullArmorService itService, ILogger<FullArmorController> logger)
        {
            _logger = logger;
            _itService = itService;
        }

        [HttpGet]
        public IActionResult Index(bool isActive = true)
        {


            _logger.LogInformation("Im in FullArmorController/Index - Get");
            var model = _itService.GetAllFullArmorsForList(2,1,"",isActive);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString, bool isActive = true )
        {

            _logger.LogInformation("Im in FullArmorController/Index - Post");
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }

            var model = _itService.GetAllFullArmorsForList(pageSize, (int)pageNo,searchString,isActive);
            return View(model);
        }

        [HttpGet("Add")]
        [Authorize]
        public IActionResult AddNewFullArmor()
        {
            _logger.LogInformation("Im in FullArmorController/AddNewFullArmor - Get");
            return View(new NewSingleFullArmorWm());
        }

        //tutaj zaimplementować odesłanie do losowania
        [HttpPost("Add")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult AddNewFullArmor(NewSingleFullArmorWm model)
        {
            _logger.LogInformation("Im in FullArmorController/AddNewFullArmor - Post");
            if (ModelState.IsValid)
            {
            _logger.LogInformation("Im in FullArmorController/AddNewFullArmor - Post - ModelState.IsValid");
                var id = _itService.AddNewFullArmor(model);
                return RedirectToAction("index");
            }
            return View(model);

        }

        [HttpGet("ViewArmor/{fullArmorId}")]
        public IActionResult ViewFullArmor(int fullArmorId)
        {
            _logger.LogInformation("Im in FullArmorController/ViewFullArmor - Get");
            var itemModel = _itService.GetFullArmorDetails(fullArmorId);
                return View(itemModel);
                //return view(itemModel);
        }

        [HttpGet("Delete/{fullArmorid}")]
        [Authorize]
        public IActionResult DeleteFullArmor(int fullArmorId)
        {
            _logger.LogInformation("Im in FullArmorController/FeleteFullArmor - Get");
            _itService.DeleteFullArmor(fullArmorId);
            return RedirectToAction("Index");
        }

        [HttpGet("Edit/{fullArmorId}")]
        [Authorize]
        public IActionResult EditFullArmor(int fullArmorId)
        {
            _logger.LogInformation("Im in FullArmorController/EditFullArmor - Get");
            var itemModel = _itService.GetFullArmorDetails(fullArmorId);
            //var listOfBackpacks = _itService.GetPlayerBackpacks(playerBackpacks);
                
            return View(itemModel);
        }

        [HttpPost("Edit/{fullArmorId}")]
        [Authorize]
        public IActionResult EditFullArmor(EditSingleFullArmorVm model, int fullArmorId)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Im in FullArmorController/EditFullArmor - Post");
                _itService.UpdateFullArmor(model, fullArmorId);
                return RedirectToAction("Index");
            }
            return View(model);

            //
            //add saving editionreturn RedirectToAction("Index");
            //
        }

    }
}
