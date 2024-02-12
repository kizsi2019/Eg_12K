using System;
using System.Collections.Generic;
using System.IO;


class JelszoGeneralo
{
    private Random Rnd;

    public JelszoGeneralo(Random r)
    {
        Rnd = r;
    }

    public string Jelszo(int jelszoHossz)
    {
        string jelszo = "";
        while (jelszo.Length < jelszoHossz)
        {
            char c = (char)Rnd.Next(48, 123);
            if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
            {
                jelszo += c;
            }
        }
        return jelszo;
    }
}

class Program
{
    static void Main()
    {
        List<string> adatok = new List<string>();

        try
        {
            using (StreamReader sr = new StreamReader("nevek.txt"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    adatok.Add(sor);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hiba történt: {e.Message}");
        }

        // 3. Feladat: Tanulók számának kiírása
        Console.WriteLine($"Az iskolába járó tanulók száma: {adatok.Count}");

        // 4. Feladat: Legehosszabb név és hossza
        // 4. Feladat: Legehosszabb név és hossza
        int maxHossz = 0;
        List<string> leghosszabbNevek = new List<string>();

        foreach (var sor in adatok)
        {
            string[] adat = sor.Split(';');
            string nev = adat[2].Trim();

            // Szóközök eltávolítása a névből
            nev = nev.Replace(" ", "");

            if (nev.Length > maxHossz)
            {
                maxHossz = nev.Length;
                leghosszabbNevek.Clear();
                leghosszabbNevek.Add(adat[2].Trim());
            }
            else if (nev.Length == maxHossz)
            {
                leghosszabbNevek.Add(adat[2].Trim());
            }
        }

        Console.WriteLine($"A leghosszabb nevű tanuló(k): {string.Join(", ", leghosszabbNevek)}");
        Console.WriteLine($"A leghosszabb név hossza: {maxHossz}");


        // 5. Feladat: Azonosítók kiírása
        string AzonositoLetrehozas(string sor)
        {
            string[] adat = sor.Split(';');
            int evfolyamUtolsóSzamjegy = int.Parse(adat[0].Substring(3, 1));
            char osztalyBetujel = adat[1][0];
            string vezeteknev = adat[2].Split(' ')[0];
            string keresztnev = adat[2].Split(' ')[1];

            return $"{evfolyamUtolsóSzamjegy}{osztalyBetujel}{vezeteknev.Substring(0, 3).ToLower()}{keresztnev.Substring(0, 3).ToLower()}";
        }



        Console.WriteLine($"Az első tanuló azonosítója: {AzonositoLetrehozas(adatok[0])}");
        Console.WriteLine($"Az utolsó tanuló azonosítója: {AzonositoLetrehozas(adatok[adatok.Count - 1])}");

        // 6. Feladat: Azonosító alapján diák keresése és adatainak kiírása
        Console.Write("Kérem, adja meg az azonosítót: ");
        string keresettAzonosito = Console.ReadLine().ToLower(); // Azonosítókat kisbetűkkel tároljuk

        bool talalat = false;

        foreach (var sor in adatok)
        {
            string azonosito = AzonositoLetrehozas(sor).ToLower(); // Azonosítókat kisbetűkkel hasonlítjuk össze

            if (azonosito == keresettAzonosito)
            {
                string[] adat = sor.Split(';');
                Console.WriteLine($"A keresett tanuló adatai:\nÉvfolyam: {adat[0]}\nOsztály: {adat[1]}\nNév: {adat[2].Trim()}");
                talalat = true;
                break;
            }
        }

        if (!talalat)
        {
            Console.WriteLine("Nincs megfelelő tanuló.");
        }

        // 7. Feladat: JelszóGeneráló használata
        Random random = new Random();
        JelszoGeneralo jelszoGeneralo = new JelszoGeneralo(random);

        // Választunk egy tanulót véletlenszerűen
        string[] valasztottTanulo = adatok[random.Next(adatok.Count)].Split(';');
        string tanuloNev = valasztottTanulo[2].Trim();

        // Generálunk egy 8 karakteres jelszót a JelszóGeneráló osztály segítségével
        string generaltJelszo = jelszoGeneralo.Jelszo(8);

        // Kiírjuk az eredményt a minta szerint
        Console.WriteLine($"A választott tanuló neve: {tanuloNev}");
        Console.WriteLine($"Generált jelszó: {generaltJelszo}");


    }
}

