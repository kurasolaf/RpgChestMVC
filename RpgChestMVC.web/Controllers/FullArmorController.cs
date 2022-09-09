﻿using Microsoft.AspNetCore.Mvc;
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

        private readonly IFullArmorService _itService;

        public FullArmorController(IFullArmorService itService)
        {
            _itService = itService;
        }

        [HttpGet]
        public IActionResult Index(bool isActive = true)
        {
            


            var model = _itService.GetAllFullArmorsForList(2,1,"",isActive);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString, bool isActive = true )
        {


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
        public IActionResult AddNewFullArmor()
        {

            return View(new NewSingleFullArmorWm());
        }


        //tutaj zaimplementować losowanie
        [HttpPost]
        public IActionResult AddNewFullArmor(NewSingleFullArmorWm model)
        {
            var id = _itService.AddNewFullArmor(model);
            return View();

        }

        [HttpGet("viewArmor/{fullArmorId}")]
        public IActionResult ViewFullArmor(int fullArmorId)
        {
            var itemModel = _itService.GetFullArmorDetails(fullArmorId);
                return View(itemModel);
                //return view(itemModel);
        }

        [HttpGet("Delete/{fullArmorid}")]
        public IActionResult DeleteFullArmor(int fullArmorId)
        {
            _itService.DeleteFullArmor(fullArmorId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditFullArmor(int fullArmorId)
        {


        }

        [HttpPut]
        public IActionResult EditFullArmor(int fullArmorId)
        {


        }




    }
}
