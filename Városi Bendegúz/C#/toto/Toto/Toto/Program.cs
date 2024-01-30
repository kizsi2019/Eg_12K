using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Toto
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //2
            List<Fordulo> lista = new List<Fordulo>();
            foreach(var i in File.ReadAllLines("toto.txt").Skip(1))
            {
                lista.Add(new Fordulo(i));
            }

            //3
            Console.WriteLine($"3. feladat: Fordulók száma: {lista.Count}");

            //4
            int count = 0;
            foreach(var i in lista)
            {
                count += i.talalatDb;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma {count} db.");

            //5
            double avg = 0.0;
            Int64 nev = 0;
            foreach(var i in lista)
            {
                if(i.talalatDb > 0)
                {
                    nev += i.talalatDb * i.talalatNyeremeny;
                }
            }
            avg = Convert.ToDouble(nev) / lista.Count;
            Console.WriteLine($"5. feladat:Átlag: {Math.Round(avg)} Ft");

            //6
            Console.WriteLine("6. feladat: ");
            int max = -1;
            int min = -1;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].talalatDb > 0)
                {
                    if(max == -1)
                    {
                        max = i;
                    }
                    if(min == -1)
                    {
                        min = i;
                    }
                    if (lista[i].talalatNyeremeny > lista[max].talalatNyeremeny)
                    {
                        max = i;
                    }
                    if (lista[i].talalatNyeremeny < lista[min].talalatNyeremeny)
                    {
                        min = i;
                    }
                }
            }
            Console.WriteLine("\t Legnagyobb: ");
            lista[max].Kiir();
            Console.WriteLine("\t Legkisebb: ");
            lista[min].Kiir();



            //8
            bool Nemdontetlen = false;
            foreach(var i in lista)
            {
                EredmenyElemzo elemzo = new EredmenyElemzo(i.eredmeny);
                if (elemzo.NemvoltDontetlenMerkozes)
                {
                    Nemdontetlen = true;
                }
            }
            Console.WriteLine($"8. feladat: {(Nemdontetlen ? "Volt" : "Nem volt")} döntetlen nélküli forduló!");

            Console.ReadKey();
        }
    }
}
