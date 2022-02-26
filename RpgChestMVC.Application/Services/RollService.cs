using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.Services
{
    class RollService
    {
        

        public int Roll8()
        {
                       
            Random rnd = new Random();

            int RolledNumber8 = rnd.Next(1, 9);     

            return RolledNumber8;

        }


        public int Roll10()
        {
            Random rnd = new Random();

            int RolledNumber10 = rnd.Next(1, 11);

            return RolledNumber10;



        }

        public int Roll21()
        {
            Random rnd = new Random();

            int RolledNumber21 = rnd.Next(1, 22);

            return RolledNumber21;
        }

        public int Roll500()
        {
            Random rnd = new Random();

            int RolledNumber500 = rnd.Next(1, 501);

            return RolledNumber500;


        }









    }
}
