using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Controllers
{
    public class ItemController : Controller
    {
        
         
        public IActionResult Index()
        {

            // Utworzyć widok dla akcj
            // Utworzyć Tabele z przedmiotami
            // Utworzyć panel do filtrowania
            //// przygotowanie danych wyfiltrowanych
            //// przekazanie filtrów do serwisu
            //// SERWIS: przygotowuje dane
            //// SERWIS: zwraca dane do controlera w odpowiednim formacie
            

            var model = itemService.GetAllItemsForList();
            return View(model);

        }

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
            var itemModel = itemService.GetItemById(itemId);
            return View(itemModel);


        }

        

    }
}
