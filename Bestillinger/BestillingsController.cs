using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAd.Bestillinger
{

    class BestillingsController
    {
        public List<Bestilling> reservation = new List<Bestilling>();

        public static bool CheckValidUser()
        {
            //hvis brugeren er logget ind, returner true
            return true;

            //hvis ikke, returner false
            //return false
        }


        public static bool CheckAvailableFS()
        {
            //hvis der er en forestilling ledig, returner true
            return true;

            //hvis ikke, returner false
            //return false
        }



    }
}
