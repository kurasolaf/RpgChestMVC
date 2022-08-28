using Microsoft.AspNetCore.Mvc;
using RpgChestMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
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
            
            // Utworzyć widok dla akcj
            // Utworzyć Tabele z przedmiotami
            // Utworzyć panel do filtrowania
            //// przygotowanie danych wyfiltrowanych
            //// przekazanie filtrów do serwisu
            //// SERWIS: przygotowuje dane
            //// SERWIS: zwraca dane do controlera w odpowiednim formacie

            var model = _itService.GetAllFullArmorsForList(2,1,"",isActive);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo,string searchString, bool isActive = true )
        {

            // Utworzyć widok dla akcj
            // Utworzyć Tabele z przedmiotami
            // Utworzyć panel do filtrowania
            //// przygotowanie danych wyfiltrowanych
            //// przekazanie filtrów do serwisu
            //// SERWIS: przygotowuje dane
            //// SERWIS: zwraca dane do controlera w odpowiednim formacie
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


        [HttpGet]
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
  
    }
}
