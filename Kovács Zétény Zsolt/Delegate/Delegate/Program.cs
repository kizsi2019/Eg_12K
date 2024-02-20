using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Szám
    {
        public delegate void EseménykezelőDelegate(string str);
        public event EseménykezelőDelegate ÁllapotváltozásEsemény;
        int szam = 0;
        public int Szam
        {
            get { return szam; }
            set
            {
                szam = value; //akkor indul be az esemény, ha megváltozik a szam mező:
                ÁllapotVáltozás();
            }
        }
        private void ÁllapotVáltozás()
        {
            if (ÁllapotváltozásEsemény != null) ÁllapotváltozásEsemény("Megváltozott a szam mező!");
        }
    }s
    internal class Program
    {
        delegate void VoidDelegate(); //a delegate létrehozása
        static void Metódus()
        {
            Console.WriteLine("A metódus lefutott!");
        }

        static void Üzenet(string név)
        {
            Console.WriteLine("Kedves {0}, köszönjük a belépésedet a rendszerbe...", név);
        }


        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            Console.WriteLine("Üdvözzöllek {0}!", név);
        }

        class Program2
        {
            static void EseményKezelés(string str)
            {
                Console.WriteLine(str);
            }


            static void Main(string[] args)
            {


                VoidDelegate vd = new VoidDelegate(Metódus); //létrejön a hivatkozás
                vd();//meghívja a megadott metódust, amire hivatkozik
                Console.ReadKey();

                Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üzenet);
                Console.Write("Add meg a nevedet: ");
                string név = Console.ReadLine();
                b(név);


                Szám sz = new Szám();
                sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre
                sz.Szam = 21; //kiváltjuk az eseményt;
                Console.ReadKey();
            }
        }
    }
}
