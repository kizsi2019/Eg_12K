using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    class Ido
    {
        public Ido(string t)
        {
            string[] temp = t.Split(':');
            ora = Convert.ToInt32(temp[0]);
            perc = Convert.ToInt32(temp[1]);
            masodperc = Convert.ToInt32(temp[2]);
        }

        public int ora { get; set; }
        public int perc { get; set; }
        public int masodperc { get; set; }

        public int Osszido()
        {
            return ora * 3600 + perc * 60 + masodperc;
        }

        public override string ToString()
        {
            return $"{ora}:{perc}:{masodperc}";
        }

    }

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

    class Versenyzo
    {
        public Versenyzo(string line)
        {
            string[] temp = line.Split(';');
            rajtszam = temp[0];
            kategoria = temp[1];
            nev = temp[2];
            egyesulet = temp[3];
            ido = new Ido(temp[4]);
            versenytav = new Versenytav(rajtszam);
        }

        public string rajtszam { get; set; }
        public string kategoria { get; set; }
        public string nev { get; set; }
        public string egyesulet { get; set; }
        public Ido ido { get; set; }
        public Versenytav versenytav { get; set; }

        public bool No()
        {
            return kategoria[kategoria.Length-1] == 'n';
        }
    }

    internal class Program
    {
        static List<Versenyzo> data = new List<Versenyzo>();

        static private string HatPlussz()
        {
            foreach(var item in data)
            {
                if(item.ido.ora >= 6 && (item.ido.perc > 0 || item.ido.masodperc > 0))
                {
                    return "Van ilyen versenyző";
                }
            }
            return "Nincs ilyen versenyző";
        }

        static void Main(string[] args)
        {
            data = System.IO.File.ReadAllLines("bukkm2019.txt")
                        .Skip(1)
                        .Select(x =>  new Versenyzo(x))
                        .ToList();

            Console.Write("4. feladat: Versenytávot nem teljesítők: ");
            Console.WriteLine(((float)(691 - data.Count) / 691) * 100 + "%");

            Console.Write("5. feladat: Női versenyzők száma a rövid távú versenyen ");
            int count = data
                            .Where(x => x.versenytav.Tav == "Rövid" && x.No())
                            .Count();
            Console.WriteLine(count + "fő");

            Console.Write("6. feladat: ");
            Console.WriteLine(HatPlussz());

            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon:");

            Versenyzo temp = data
                                .Where(x => x.versenytav.Tav == "Rövid" && x.kategoria == "ff")
                                .OrderBy(x => x.ido.Osszido())
                                .First();

            Console.WriteLine($"\tRajtszám: {temp.rajtszam}");
            Console.WriteLine($"\tNév: {temp.nev}");
            Console.WriteLine($"\tEgyesület: {temp.egyesulet}");
            Console.WriteLine($"\tIdő: {temp.ido.ToString()}");


            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(var item in data)
            {
                int count1 = 0;
                foreach(var item2 in data)
                {
                    if(item.kategoria == item2.kategoria && !item2.No())
                    {
                        count1++;
                    }
                }
                if(count1 > 0)
                {
                    dict[item.kategoria] = count1;
                }
            }
            Console.WriteLine("8. feladat: Statisztika");
            foreach(KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"\t{item.Key} - {item.Value}fo");
            }

        }
    }
}
