using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Felhasználó nevének bekérése
        Console.WriteLine("Kérem, adja meg a teljes nevét:");
        string teljesNev = Console.ReadLine();

        // Tantárgy nevének bekérése
        Console.WriteLine($"Kedves {teljesNev}, kérem, adja meg a tantárgy nevét:");
        string tantargyNev = Console.ReadLine();

        // Jegyek bekérése
        Console.WriteLine($"Kérem, adja meg a(z) {tantargyNev} tantárgy jegyeit, vesszővel elválasztva:");
        string jegyInput = Console.ReadLine();

        // Jegyek feldolgozása
        string[] jegyek = jegyInput.Split(',');
        int[] jegyekSzamokkent = new int[jegyek.Length];

        for (int i = 0; i < jegyek.Length; i++)
        {
            if (int.TryParse(jegyek[i], out int jegy))
            {
                jegyekSzamokkent[i] = jegy;
            }
            else
            {
                Console.WriteLine("Hibás jegyformátum. Kérem, csak számokat adjon meg.");
                return;
            }
        }

        // Legmagasabb és legalacsonyabb jegyek kiszámítása
        int legmagasabbJegy = int.MinValue;
        int legalacsonyabbJegy = int.MaxValue;

        foreach (var jegy in jegyekSzamokkent)
        {
            legmagasabbJegy = Math.Max(legmagasabbJegy, jegy);
            legalacsonyabbJegy = Math.Min(legalacsonyabbJegy, jegy);
        }

        // Jegyek átlagának kiszámítása
        double atlag = jegyekSzamokkent.Length > 0 ? jegyekSzamokkent.Average() : 0;

        // Eredmények kiírása nagybetűs névvel
        string nagybetusNev = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(teljesNev.ToLower());

        Console.WriteLine($"{nagybetusNev} legjobb jegye: {legmagasabbJegy}");
        Console.WriteLine($"{nagybetusNev} legrosszabb jegye: {legalacsonyabbJegy}");
        Console.WriteLine($"{nagybetusNev} jegyeinek az átlaga: {atlag:F1}");

        Console.ReadLine(); // Csak azért, hogy a konzolablak ne záródjon be azonnal
    }
}