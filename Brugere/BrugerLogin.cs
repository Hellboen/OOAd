using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAd.Brugere
{
    class BrugerLogin
    {
        private readonly string brugerNavn = Console.ReadLine();
        private readonly string password = Console.ReadLine();

        public static bool Login(int brugerNavn, string password)
        {
            //hvis brugernavn er det samme som et i databasen
            //og passwordet tilsvarer brugernavnets password

            return true;
            
            //hvis ikke, så return false
        }
    }
}
