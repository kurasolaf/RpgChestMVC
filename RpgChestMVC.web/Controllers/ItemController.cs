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
            return View();
        }
    }
}
