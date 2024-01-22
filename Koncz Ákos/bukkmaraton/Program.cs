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

            Console.WriteLine("7. feladat A felnőtt férfi  (ff) kategória győztese rövid távon:");
            Versenyzo gyoztes = null;

            foreach (var i in versenyzo)
            {
                if (i.Tav == "Rövid" && i.Kategoria == "ff")
                {
                    if (gyoztes == null)
                    {
                        gyoztes = i;
                    }
                    else
                    {
                        if (i.Ido < gyoztes.Ido)
                        {
                            gyoztes = i;
                        }
                    }
                }
            }
            Console.WriteLine($"\tRajtszám: {gyoztes.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztes.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztes.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztes.Ido}");


            Console.WriteLine("8. feladat: Statisztika");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            foreach (var i in versenyzo)
            {
                if (i.NoiVersenyzo)
                {
                    if (dict.ContainsKey(i.Kategoria))
                    {
                        dict[i.Kategoria]++;
                    }
                    else
                    {
                        dict.Add(i.Kategoria, 1);
                    }
                }
            }

            foreach (var i in dict)
            {
                Console.WriteLine($"\t{i.Key} - {i.Value} fő");
            }

            Console.ReadKey();
        }
    }
}
