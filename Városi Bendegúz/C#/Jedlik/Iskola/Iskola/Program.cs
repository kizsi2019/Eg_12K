using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Iskola
{
    struct Adat
    {
        public int kezdes;
        public string osztaly;
        public string nev;
    }


    
    class Program
    {


        static void Main(string[] args)
        {
            List<Adat> lista = new List<Adat>();
            StreamReader read = new StreamReader("nevek.txt");
            do
            {
                string line = read.ReadLine();
                string[] tomb = line.Split(";");
                Adat adat = new Adat
                {
                    kezdes = int.Parse(tomb[0]),
                    osztaly = tomb[1],
                    nev = tomb[2]
                };
                lista.Add(adat);
            } while (!read.EndOfStream);
            read.Close();

            //3
            Console.WriteLine($"Az iskolába {lista.Count} tanuló jár");

            //4
            int max = 0;
            foreach (Adat item in lista)
            {
                string[] tomb = item.nev.Split(' ');
                int hossz = 0;
                foreach (string r in tomb)
                {
                    hossz += r.Length;
                }
                if (tomb.Length == 3 && hossz > max)
                {
                    max = hossz;
                }
            }
            Console.WriteLine($"4. feladat: A leghosszabb {max} karakter nevű tanuló(k): ");
            foreach (Adat item in lista)
            {
                string[] tomb = item.nev.Split(' ');
                int hossz = 0;
                foreach (string r in tomb)
                {
                    hossz += r.Length;
                }
                if (tomb.Length == 3 && hossz == max)
                {
                    Console.WriteLine($"\t {item.nev}");
                }
            }

            //5
            string azonosito = CreateUniqueID(lista[0]);
            string azonosito2 = CreateUniqueID(lista[lista.Count - 1]);

            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine($"\tElső: {lista[0].nev} - {azonosito}");
            Console.WriteLine($"\tUtolsó: {lista[lista.Count - 1].nev} - {azonosito2}");

            static string CreateUniqueID(Adat tanulo)
            {
                int evfolyamUtolso = tanulo.kezdes % 10;
                string osztalyBetu = tanulo.osztaly;
                string vezeteknev = tanulo.nev.Split(' ')[0].Substring(0, Math.Min(3, tanulo.nev.Length)).ToLower();

                string[] nevReszek = tanulo.nev.Split(' ');
                string keresztnev = "";
                if (nevReszek.Length > 1)
                {
                    keresztnev = nevReszek[1].Substring(0, Math.Min(3, nevReszek[1].Length)).ToLower();
                }

                return $"{evfolyamUtolso}{osztalyBetu}{vezeteknev}{keresztnev}";
            }

            //6


            Console.ReadKey();

        }
    }
}