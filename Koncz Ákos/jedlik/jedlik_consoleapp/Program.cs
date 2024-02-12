using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Net;
using System.Diagnostics.Tracing;
using System.Xml.Schema;

namespace jedlik_consoleapp
{
    struct Data
    {
        public int evszam;
        public string betujel;
        public string nev;
    }

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

            //--------------File Beolvasás----------------------

            List<Data> data = new List<Data>();
            StreamReader read = new StreamReader("nevek.txt");


            do
            {
                string sor = read.ReadLine();
                string[] tomb = sor.Split(';');

                Data data1 = new Data
                {
                    evszam = int.Parse(tomb[0]),
                    betujel = tomb[1],
                    nev = tomb[2]
                };

                data.Add(data1);
            } while (!read.EndOfStream);

            read.Close();

            // -------------------------------------------------

            Console.WriteLine($"3. feladat: Az iskolába {data.Count} tanuló jár.");

            int max = 0;

            foreach (Data i in data)
            {
                string[] tomb = i.nev.Split(' ');

                int ossz = 0;
                foreach (string resz in tomb)
                {
                    ossz += resz.Length;
                }

                if (tomb.Length == 3 && ossz > max)
                {
                    max = ossz;
                }
            }

            Console.WriteLine($"4. feladat: A leghosszabb ({max} karakter) nevű tanuló(k):");

            foreach (Data i in data)
            {
                string[] tomb = i.nev.Split(' ');

                int ossz = 0;
                foreach (string resz in tomb)
                {
                    ossz += resz.Length;
                }

                if (tomb.Length == 3 && ossz == max)
                {
                    Console.WriteLine($"\t{i.nev}");
                }
            }

            // elso tanulo
            string firstStudentID = IdCreator(data[0]);

            //utolso tanulo
            string lastStudentID = IdCreator(data[data.Count - 1]);


            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine($"\tElső: {data[0].nev} - {firstStudentID}");
            Console.WriteLine($"\tUtolsó: {data[data.Count - 1].nev} - {lastStudentID}");



            //-----------------6. feladat------------------

            Console.WriteLine("Kérek egy azonosítót [pl.: 4dvavkri]: ");

            //---------------------------------------------

            Console.ReadKey();
        }

        static string IdCreator(Data neve)
        {
            int evfolyamLastDigit = neve.evszam % 10;
            string osztalyBetujel = neve.betujel;
            string vezeteknevPrefix = neve.nev.Split(' ')[0].Substring(0, Math.Min(3, neve.nev.Length)).ToLower();

            // keresztnev

            string[] nevReszek = neve.nev.Split(' ');
            string keresztnevPrefix = "";
            if (nevReszek.Length > 1)
            {
                keresztnevPrefix = nevReszek[1].Substring(0, Math.Min(3, nevReszek[1].Length)).ToLower();
            }

            return $"{evfolyamLastDigit}{osztalyBetujel}{vezeteknevPrefix}{keresztnevPrefix}";
        }
    }
}
