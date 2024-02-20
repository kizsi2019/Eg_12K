using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface
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
    }

    internal class Program
    {
        static void EseményKezelés(string str)
        {
            Console.WriteLine(str);
        }
        interface IKöszönés
        {
            void Reggel();
            void Este();
            void Napközben();
        }
        interface IÜdvözlés
        {
            void Szia(string név);
        }
        class Köszönés_Üdvözlés : IKöszönés, IÜdvözlés
        {
            public void Reggel() { Console.WriteLine("Jó reggelt!"); }
            public void Este() { Console.WriteLine("Jó estét!"); }
            public void Napközben() { Console.WriteLine("Jó napot!"); }
            public void Szia(string név) { Console.WriteLine("Szia {0}!", név); }
        }
        delegate void VoidDelegate(); //a delegate létrehozása
        static void Metódus()
        {
            Console.WriteLine("A metódus lefutott!");
        }

        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            Console.WriteLine("Üdvözzöllek {0}!", név);
        }
        static void Üzenet(string név)
        {
            Console.WriteLine("Kedves {0}, köszönjük a belépésedet a rendszerbe...", név);
        }
        


        static void Main(string[] args)
        {

            Szám sz = new Szám();
            sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre
            sz.Szam = 21; //kiváltjuk az eseményt;
            Console.ReadKey();

            Köszönés_Üdvözlés kosz = new Köszönés_Üdvözlés();
            kosz.Reggel();
            kosz.Este();
            kosz.Napközben();
            kosz.Szia("Dezső");


            VoidDelegate vd = new VoidDelegate(Metódus); //létrejön a hivatkozás
            vd();//meghívja a megadott metódust, amire hivatkozik

            Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üzenet);
            Console.Write("Add meg a nevedet: ");
            string név = Console.ReadLine();
            b(név);


            Console.ReadKey();
        }

    }
}
