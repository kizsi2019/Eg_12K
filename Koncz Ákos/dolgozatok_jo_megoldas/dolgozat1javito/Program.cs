using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adj meg egy nevet:");
        string nev = Console.ReadLine().ToUpper();

        Console.WriteLine($"{nev} jegyeinek számát add meg:");
        int jegySzam = int.Parse(Console.ReadLine());

        int[] jegyek = new int[jegySzam];

        for (int i = 0; i < jegySzam; i++)
        {
            Console.WriteLine($"{nev} {i + 1}. jegye:");
            jegyek[i] = int.Parse(Console.ReadLine());
        }

        double atlag = SzamoldAtlag(jegyek);
        int legjobbJegy = LegjobbJegy(jegyek);
        int legrosszabbJegy = LegrosszabbJegy(jegyek);

        Console.WriteLine($"{nev} átlaga: {atlag:F1}");
        Console.WriteLine($"{nev} legjobb jegye: {legjobbJegy}");
        Console.WriteLine($"{nev} legrosszabb jegye: {legrosszabbJegy}");

        Console.ReadKey();
    }

    static double SzamoldAtlag(int[] jegyek)
    {
        if (jegyek.Length == 0)
            return 0;

        int osszeg = 0;
        foreach (var jegy in jegyek)
        {
            osszeg += jegy;
        }

        return (double)osszeg / jegyek.Length;
    }

    static int LegjobbJegy(int[] jegyek)
    {
        if (jegyek.Length == 0)
            return 0;

        int legjobb = jegyek[0];
        foreach (var jegy in jegyek)
        {
            if (jegy > legjobb)
                legjobb = jegy;
        }

        return legjobb;
    }

    static int LegrosszabbJegy(int[] jegyek)
    {
        if (jegyek.Length == 0)
            return 0;

        int legrosszabb = jegyek[0];
        foreach (var jegy in jegyek)
        {
            if (jegy < legrosszabb)
                legrosszabb = jegy;
        }

        return legrosszabb;
    }
}
