using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAd.Brugere
{
    class BrugerRepo
    {
        public BrugerLogin brugerLogin = new BrugerLogin();
        public string BrugerNavn;
        public int BrugerID;



        public static void CreateUser()
        {
            //Opretter BrugerID
            //
        }

        public static void UpdateUser(int brugerID)
        {
            //Opdaterer brugeren med nye data
        }

        public static void DeleteUser(int brugerID)
        {
            //Sletter en bruger efter ID
        }
    }
}
