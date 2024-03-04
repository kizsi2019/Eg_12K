using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BukkMaraton2019
{
    public class Program
    {
        static public List<Versenyzo> versenyzok = Import();

        static public List<Versenyzo> Import()
        {
            return System.IO.File.ReadAllLines("bukkm2019.txt")
                .Skip(1)
                .Select(x => new Versenyzo(x))
                .ToList();
        }

        static public float Negyedik(List<Versenyzo> versenyzok)
        {
            return ((691 - (float)versenyzok.Count) / 691) * 100;
        }

        static public int Otodik(List<Versenyzo> versenyzok)
        {
            return versenyzok
                .Where(x => x.Kategoria.Last() == 'n' && new Versenytav(x.Rajtszam).Tav == "Rövid")
                .ToList()
                .Count();
        }

        static public bool Hatodik(List<Versenyzo> versenyzok)
        {
            return versenyzok.Where(
                x => (Convert.ToInt32(x.Ido.Split(':')[0]) > 6) ||
                (Convert.ToInt32(x.Ido.Split(':')[0]) == 6 &&
                (Convert.ToInt32(x.Ido.Split(':')[1]) > 0 ||
                Convert.ToInt32(x.Ido.Split(':')[2]) > 0)))
                .ToList()
                .Count() > 0;
        }

        static public Versenyzo Hetedik(List<Versenyzo> versenyzok)
        {
            return versenyzok
                .Where(x => new Versenytav(x.Rajtszam).Tav == "Rövid" && x.Kategoria == "ff")
                .OrderBy(x => x.Osszido())
                .First();

        }

        static public Dictionary<string, int> Nyolcadik(List<Versenyzo> versenyzok)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in versenyzok
                .Where(x => x.Kategoria.Last() == 'f')
                .GroupBy(x => x.Kategoria)
                .ToDictionary(x => x.Key, x => x.Count()))
            {
                dict[item.Key] = item.Value;
            }

            return dict;
        }

        static void Main(string[] args)
        {
            Import();
        }
    }
}
