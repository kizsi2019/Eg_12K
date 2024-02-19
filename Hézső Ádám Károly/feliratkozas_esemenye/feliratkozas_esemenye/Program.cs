using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feliratkozas_esemenye
{
    
        class Szám
        {
            public delegate void EseménykezelőDelegate(object o, Esemény e);
            public event EseménykezelőDelegate ÁllapotváltozásEsemény;
            int szam = 0;
            public int Szam
            {
                get { return szam; }
                set
                {
                    szam = value;
                    ÁllapotVáltozás();
                }
            }
            private void ÁllapotVáltozás()
            {
                if (ÁllapotváltozásEsemény != null)
                    ÁllapotváltozásEsemény(this, new Esemény("A szám megváltozott!"));
                //a this-szel átadja az osztály saját magát
            }
        }
        class Program
        {
            static void EseményKezelés(object eseménytkiváltóosztály, Esemény e)
            {
                Console.WriteLine(e.üzenet);
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
