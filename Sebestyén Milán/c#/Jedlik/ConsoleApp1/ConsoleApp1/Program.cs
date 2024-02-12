

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class JelszóGeneráló
{
    private Random Rnd;
    
    public JelszóGeneráló(Random r)
    {
        Rnd = r;
    }
    
    public string Jelszó(int jelszóHossz)
    {
        string jelszó = "";
        while (jelszó.Length < jelszóHossz)
        {
            char c = (char)Rnd.Next(48, 123);
            if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
            {
                jelszó += c;
            }
        }
        return jelszó;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            foreach(var i in File.ReadAllLines("nevek.txt"))
            {
                string[] sor=i.Split(';');
                tanulok.Add(new Tanulo
                {
                    Ev = int.Parse(sor[0]),
                    Osztaly = sor[1],
                    Nev = sor[2]
                });
            }

            Console.WriteLine($"3. feladat: Az iskolába {tanulok.Count} tanuló jár");


            int maxi = tanulok[0].Nevhosz;
            for (int i = 1; i < tanulok.Count; i++)
            {
                if (maxi < tanulok[i].Nevhosz)
                {
                    maxi = tanulok[i].Nevhosz;
                }
            }

            Console.WriteLine("4. feladat: A leghosszab ({0} karakter) nevű tanuló(k):", maxi);
            foreach (Tanulo t in tanulok)
            {
                if (t.Nevhosz == maxi)
                {
                    Console.WriteLine("\t{0}", t.Nev);
                }
            }


            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső: {0} - {1}", tanulok[0].Nev, tanulok[0].Azonosito);
            Console.WriteLine("\tUtolsó: {0} - {1}", tanulok[tanulok.Count - 1].Nev, tanulok[tanulok.Count - 1].Azonosito);


            Random rand = new Random();
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(rand);
            int index = rand.Next(tanulok.Count);
            Console.WriteLine("7. feladat: Jelszó generálása");
            Console.WriteLine("\t{0} - {1}", tanulok[index].Nev, jelszoGeneralo.Jelszó(8));



            Console.ReadKey();
        }
    }
}