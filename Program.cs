using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAd.Bestillinger;
using OOAd.Brugere;

namespace OOAd
{
    class Program
    {
        private BrugerRepo brugerRepo = new BrugerRepo();
        private FilmRepo filmRepo = new FilmRepo();

        private BestillingsController bestillingsController= new BestillingsController();



        static void Main(string[] args)
        {

        }
    }
}