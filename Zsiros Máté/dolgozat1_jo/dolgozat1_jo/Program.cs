using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat1_jo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek, add meg a neved:");
            string nev = Console.ReadLine().ToUpper();

            int[] szamok = new int[5];
            int osszeg = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine($"Kérlek, add meg a(z) {i + 1}. számot (1-5 között):");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                osszeg += szamok[i];
            }

            double atlag = (double)osszeg / szamok.Length;
            int min = szamok.Min();
            int max = szamok.Max();

            Console.WriteLine($"{nev} átlaga: {atlag}");
            Console.WriteLine($"{nev} minimuma: {min}");
            Console.WriteLine($"{nev} maximuma: {max}");

            Console.ReadKey();
        }
    }
}
