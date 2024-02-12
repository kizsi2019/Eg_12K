using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{

    class Program
    {
        static void Main()
        {
            List<Tanulo> tanulok = Beolvas("nevek.txt");

            // 3. Feladat: Kiírni a képernyőre, hány tanuló jár az iskolába
            Console.WriteLine($"3. Feladat: Az iskolába járó tanulók száma: {tanulok.Count}");

            // 4. Feladat: Kiírni a leghosszabb nevű tanulókat
            KiirLeghosszabbNev(tanulok);

            // 5. Feladat: Kiírni az első és az utolsó tanuló azonosítóját
            KiirAzonosito(tanulok);

            // 6. Feladat: Azonosító alapján tanuló keresése és adatainak kiírása
            Console.Write("6. Feladat: Kérem, adjon meg egy azonosítót: ");
            string keresettAzonosito = Console.ReadLine().ToLower();

            Tanulo keresettTanulo = KeresTanuloAzonositoAlapjan(tanulok, keresettAzonosito);

            if (keresettTanulo != null)
            {
                Console.WriteLine($"           A megadott azonosítóhoz tartozó tanuló adatai:");
                Console.WriteLine($"           Évfolyam: {keresettTanulo.Ev}");
                Console.WriteLine($"           Osztály: {keresettTanulo.Osztaly}");
                Console.WriteLine($"           Név: {keresettTanulo.Nev}");
            }
            else
            {
                Console.WriteLine("           Nincs megfelelő tanuló.");
            }

            Random random = new Random();

            // Példányosítjuk a JelszóGeneráló osztályt
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(random);

            if (tanulok.Count > 0)
            {
                // Véletlenszerűen válasszunk ki egy tanulót
                Tanulo valasztottTanulo = tanulok[random.Next(tanulok.Count)];

                // Generáljunk egy 8 karakteres jelszót a JelszóGeneráló osztály segítségével
                string generatedPassword = jelszoGeneralo.Jelszó(8);

                // Kiírjuk az eredményt
                Console.WriteLine($"7. Feladat: {valasztottTanulo.Nev} jelszava: {generatedPassword}");
            }
            else
            {
                Console.WriteLine("Nincs elérhető tanuló az adatokban.");
            }
        }

        static List<Tanulo> Beolvas(string fajlnev)
        {
            List<Tanulo> tanulok = new List<Tanulo>();

            try
            {
                foreach (var sor in System.IO.File.ReadLines(fajlnev))
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 3)
                    {
                        tanulok.Add(new Tanulo
                        {
                            Ev = adatok[0],
                            Osztaly = adatok[1],
                            Nev = adatok[2]
                        });
                    }
                    else
                    {
                        Console.WriteLine($"Hibás sor: {sor}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a fájl olvasása közben: {ex.Message}");
            }

            return tanulok;
        }

        static void KiirLeghosszabbNev(List<Tanulo> tanulok)
        {
            // 4. Feladat: Kiírni a leghosszabb nevű tanulókat
            int maxHossz = 0;
            foreach (var tanulo in tanulok)
            {
                int nevHossz = tanulo.Nev.Replace(" ", "").Length;
                if (nevHossz > maxHossz)
                {
                    maxHossz = nevHossz;
                }
            }

            Console.Write($"4. Feladat: A leghosszabb nevű tanulók: ");
            foreach (var tanulo in tanulok)
            {
                if (tanulo.Nev.Replace(" ", "").Length == maxHossz)
                {
                    Console.Write($"{tanulo.Nev}, ");
                }
            }
            Console.WriteLine($"Hossza: {maxHossz} karakter");
        }

        static void KiirAzonosito(List<Tanulo> tanulok)
        {
            // 5. Feladat: Kiírni az első és az utolsó tanuló azonosítóját
            if (tanulok.Count > 0)
            {
                string elsoAzonosito = AzonositoKeszit(tanulok[0]);
                string utolsoAzonosito = AzonositoKeszit(tanulok[tanulok.Count - 1]);

                Console.WriteLine($"5. Feladat: Az első tanuló azonosítója: {elsoAzonosito}");
                Console.WriteLine($"           Az utolsó tanuló azonosítója: {utolsoAzonosito}");
            }
            else
            {
                Console.WriteLine("Nincs elérhető tanuló azonosító.");
            }
        }

        static string AzonositoKeszit(Tanulo tanulo)
        {
            // 5. Feladat: Azonosító készítése az adott tanuló alapján
            string evUtolsoSzamjegy = tanulo.Ev.Substring(tanulo.Ev.Length - 1);
            string osztalyBetujel = tanulo.Osztaly;
            string vezeteknevElsoHarom = tanulo.Nev.Split(' ')[0].Substring(0, 3).ToLower();
            string keresztnevElsoHarom = tanulo.Nev.Split(' ')[1].Substring(0, 3).ToLower();

            return $"{evUtolsoSzamjegy}{osztalyBetujel}{vezeteknevElsoHarom}{keresztnevElsoHarom}";
        }

        static Tanulo KeresTanuloAzonositoAlapjan(List<Tanulo> tanulok, string keresettAzonosito)
        {
            // 6. Feladat: Tanuló keresése azonosító alapján
            foreach (var tanulo in tanulok)
            {
                if (AzonositoKeszit(tanulo) == keresettAzonosito)
                {
                    return tanulo;
                }
            }
            return null; // Ha nincs találat
        }
    }

    class Tanulo
    {
        public string Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }
    }
}
