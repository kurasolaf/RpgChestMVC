using Microsoft.AspNetCore.Mvc;
using RpgChestMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
    public class ItemController : Controller
    {

        private readonly IItemService _itService;

        public ItemController(IItemService itService)
        {
            _itService = itService;


        }
       
        
      

         
        public IActionResult Index()
        {

            // Utworzyć widok dla akcj
            // Utworzyć Tabele z przedmiotami
            // Utworzyć panel do filtrowania
            //// przygotowanie danych wyfiltrowanych
            //// przekazanie filtrów do serwisu
            //// SERWIS: przygotowuje dane
            //// SERWIS: zwraca dane do controlera w odpowiednim formacie
            

            var model = _itService.GetListItemForList();
            return View(model);

        }
        /*
        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddItem(ItemModel model)
        {
            var id = itemService.AddItem(model);
            return View();

        }

        public IActionResult ViewItem(int itemId)
        {
            var itemModel = itemService.GetItemDetails(itemId);
            return View(itemModel);


        }
        */
        

    }
}
