using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.Services
{
    class RollService
    {
        //stworzenie Losowości 1-8/1-10/1-21/1-500 / RollService


        public int Roll8()
        {
                       
            Random rnd = new Random();

            int RolledNumber8 = rnd.Next(1, 8);     

            return RolledNumber8;

        }











    }
}
