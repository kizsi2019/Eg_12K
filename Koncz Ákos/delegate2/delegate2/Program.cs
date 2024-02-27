using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
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
    class Program
    {
        static void EseményKezelés(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Szám sz = new Szám();
            sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre
            sz.Szam = 21; //kiváltjuk az eseményt;
            Console.ReadKey();
        }
    }

}
