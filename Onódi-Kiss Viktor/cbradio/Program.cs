using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    internal class Program
    {
        static List<Bejegyzes> bejegyzesek = new List<Bejegyzes>();
        
        //1.Készítsen programot a következő feladatok megoldására, amelynek a forráskódját cbradio néven mentse el!

        //2.Olvassa be a cb.txt állományban lévő adatokat és tárolja el egy olyan adatszerkezetben, ami a további feladatok megoldására alkalmas! Az állományban legfeljebb 500 sor lehet.

        static void Import(string filename)
        {
            bejegyzesek = System.IO.File.ReadAllLines(filename)
                                        .Skip(1)
                                        .Select( x => new Bejegyzes(x))
                                        .ToList();
        }

        //3.Határozza meg és írja ki a képernyőre a minta szerint, hogy hány bejegyzés található a forrásállományban!

        static string Third()
        {
            return bejegyzesek.Count().ToString();
        }

        //4.Döntse el és írja ki a képernyőre a minta szerint, hogy található-e a naplóban olyan bejegyzés, amely szerint a sofőr egy percen belül pontosan 4 adást indított!A keresést ne folytassa, ha az eredményt meg tudja határozni!

        static string Fourth()
        {
            foreach(Bejegyzes bej in bejegyzesek)
            {
                if(bej.AdasDb >= 4)
                {
                    return "Volt négy adást indító sofőr";
                }
            }
            return "Nem volt négy adást indító sofőr";
        }

        //5.Kérje be a felhasználótól egy sofőr nevét, majd határozza meg a sofőr által indított hívások számát a napló bejegyzéseiből! Az eredményt a minta szerint írja ki a képernyőre! Ha olyan sofőr nevét adja meg a felhasználó, aki nem szerepel a naplóban, akkor a „Nincs ilyen nevű sofőr!” mondat jelenjen meg!

        static string Fifth(string name)
        {
            if(!bejegyzesek.Select(x => x.Nev).Contains(name))
            {
                return "\tNincs ilyen nevű sofőr!";
            }
            return $"\t{name} {bejegyzesek.Where(x => x.Nev == name).Sum(x => x.AdasDb)}x használta a CB rádiót.";
        }

        //6.Készítsen AtszamolPercre azonosítóval egész típusú értékkel visszatérő metódust vagy függvényt, ami a paraméterként megadott óra - és percértéket percekre számolja át!Egy óra 60 percből áll. Például: 8 óra 5 perc esetén a visszatérési érték: 485(perc).""

        static public int AtszamolPercre(int ora, int perc)
        {
            return (int) (ora * 60 + perc);
        }

        //7. Készítsen szöveges állományt cb2.txt néven, melybe a forrásállományban található bejegyzéseket írja ki új formátumban! Az órákat és a perceket percekre számolja át az előző feladatban elkészített metódus (függvény) hívásával! Az új állomány első sorát és az adatsorokat a minta szerint alakítsa ki!

        static public void Seventh()
        {
            using(System.IO.StreamWriter sw = new System.IO.StreamWriter("cb2.txt"))
            {
                sw.WriteLine("Kezdes;Nev;AdasDb");
                foreach(Bejegyzes bej in bejegyzesek)
                {
                    string temp = $"{AtszamolPercre(bej.Ora, bej.Perc)};{bej.Nev};{bej.AdasDb}";
                    sw.WriteLine(temp);
                }
            }
        }

        //8. Határozza meg és írja ki a minta szerint a sofőrök számát a forrásállományban található becenevek alapján! Feltételezheti, hogy nincs két azonos becenév.

        static public string Eight()
        {
            return $"{bejegyzesek.Select(x => x.Nev).Distinct().Count()}";
        }

        //9. Határozza meg a legtöbb adást indító sofőr nevét! A sofőr neve és az általa indított hívások száma a minta szerint jelenen meg a képernyőn!
        
        static string Ninth()
        {
            KeyValuePair<string, int> max = bejegyzesek
                        .GroupBy(x => x.Nev)
                        .Select(x => new
                        {
                            Key = x.Key,
                            Value = bejegyzesek.Where(y => y.Nev == x.Key).Sum(y => y.AdasDb)
                        })
                        .ToDictionary(x => x.Key, x => x.Value)
                        .OrderByDescending(x => x.Value).FirstOrDefault();
            return  $"\tNév: {max.Key}\n" +
                    $"\tAdások száma: {max.Value} alkalom";
        }

        static void Main(string[] args)
        {
            Import("cb.txt");
            Console.WriteLine($"3. Feladat: Bejegyzések száma: {Third()} db");
            Console.WriteLine($"4. Feladat: {Fourth()}");
            Console.Write("5. Feladat: Kérek egy nevet: ");
            Console.WriteLine(Fifth(Console.ReadLine()));
            Seventh();
            Console.WriteLine($"8. Feladat: Sofőrök száma: {Eight()} fő");
            Console.WriteLine($"9. Feladat: Legtöbb adást indító sofőr: \n{Ninth()}");
        }
    }
}
