using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kérem, adja meg a nevét:");
        string nev = Console.ReadLine();

        List<int> jegyek = new List<int>();
        int szamlalo = 0;

        Console.WriteLine($"Kérem, adja meg {nev} jegyeit (1-5), maximum 6 jegyig, majd üssön Enter-t a befejezéshez.");

        while (szamlalo < 6)
        {
            Console.Write($"{nev} jegye ({szamlalo + 1}. jegy): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            int jegy;
            if (int.TryParse(input, out jegy) && jegy >= 1 && jegy <= 5)
            {
                jegyek.Add(jegy);
                szamlalo++;
            }
            else
            {
                Console.WriteLine("Érvénytelen jegy! Kérem, adjon meg egy érvényes jegyet (1-5).");
            }
        }

        if (jegyek.Count > 0)
        {
            double atlag = SzamolAtlag(jegyek);
            int legjobbJegy = SzamolLegjobbJegy(jegyek);
            int legrosszabbJegy = SzamolLegrosszabbJegy(jegyek);

            Console.WriteLine($"{nev.ToUpper()} átlaga: {atlag:F2}");
            Console.WriteLine($"{nev.ToUpper()} legjobb jegye: {legjobbJegy}");
            Console.WriteLine($"{nev.ToUpper()} legrosszabb jegye: {legrosszabbJegy}");
        }
        else
        {
            Console.WriteLine("Nincs megadott jegy.");
        }

        Console.ReadLine();
    }

    static double SzamolAtlag(List<int> jegyek)
    {
        int osszeg = 0;
        foreach (var jegy in jegyek)
        {
            osszeg += jegy;
        }

        return (double)osszeg / jegyek.Count;
    }

    static int SzamolLegjobbJegy(List<int> jegyek)
    {
        int legjobb = int.MinValue;
        foreach (var jegy in jegyek)
        {
            if (jegy > legjobb)
                legjobb = jegy;
        }
        return legjobb;
    }

    static int SzamolLegrosszabbJegy(List<int> jegyek)
    {
        int legrosszabb = int.MaxValue;
        foreach (var jegy in jegyek)
        {
            if (jegy < legrosszabb)
                legrosszabb = jegy;
        }
        return legrosszabb;
    }
}
