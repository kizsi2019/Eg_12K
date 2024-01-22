using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bukkmaraton
{
    class Versenytav
    {
        private string Rajtszam;
        public string Tav
        {
            get
            {
                switch (Rajtszam[0])
                {
                    case 'M': return "Mini";
                    case 'R': return "Rövid";
                    case 'K': return "Közép";
                    case 'H': return "Hosszú";
                    case 'E': return "Pedelec";
                }
                return "Hibás rajtszám";
            }
        }
        public Versenytav(string rajtszam)
        {
            Rajtszam = rajtszam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzo = new List<Versenyzo>();

            foreach(var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzo.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1 - versenyzo.Count / 691.0) * 100}");

            int nagyValtozo = 0;
            foreach (var i in versenyzo)
            {
                if (i.NoiVersenyzo && i.Tav == "Rövid")
                {
                    nagyValtozo++;
                }
            }
            Console.WriteLine($"5. feladat: Női versenyzők rövid távú versenyen: {nagyValtozo}fő");

            bool valami = false;
            
            foreach(var i in versenyzo)
            {
                if (i.TobbMintHat)
                {
                    valami = true;
                    break;
                }
            }

            if (valami)
            {
                Console.WriteLine("6. feladat: Volt ilyen versenyzo");
            }
            else
            {
                Console.WriteLine("6. feladat: Nem volt ilyen versenyzo");
            }

            Console.ReadKey();
        }
    }
}
