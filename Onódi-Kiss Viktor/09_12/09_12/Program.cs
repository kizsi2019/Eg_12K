using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _09_12
{
    internal class Program
    {
        private static List<Feladvany> data = new List<Feladvany>();

        private static void Import(string filename)
        {
            data = File.ReadAllLines(filename).Select(x => new Feladvany(x)).ToList();
        }

        private static int Fourth(int size)
        {
            return data.Where(x => x.Meret == size).Count();
        }

        private static Feladvany Fifth(int size)
        {
            Random rand = new Random();

            return data.Where(x => x.Meret == size).ToList()[rand.Next(0, data.Where(x => x.Meret == size).Count())];
        }

        private static double Sixth(string sor)
        {
            int count = 0;

            for (int i = 0; i < sor.Length; i++) 
            {
                if (sor[i] == '0')
                {
                    count++;
                }
            }

            if(count == 0)
            {
                return 100;
            }
            else
            {
                return Math.Round(count / (double)sor.Count(), 2);
            }
        }

        static void Main(string[] args)
        {
            Import("feladvanyok.txt");

            //3. Feladat
            Console.WriteLine($"3. feladat: Beolvasva {data.Count()} feladvány");

            //4. Feladat
            int size = 0;
            while(size < 4 || size > 9)
            {
                Console.Write($"\n4. feladat: Kérem a feladvány méretét [4..9]: ");
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Rossz input!");
                }
            }
            Console.WriteLine($"A {size}x{size} méretü feladványból {Fourth(size)} darab van tárolva");

            Console.WriteLine("5. feladat: a kiválasztott feladvány:");
            Feladvany kiv = Fifth(size); 
            Console.WriteLine(kiv.Kezdo);

            Console.WriteLine($"6. feladat: a feladvány kitöltöttsége: {Sixth(kiv.Kezdo) * 100}%");

            Console.WriteLine("7. feladat: A feladvány kirajzolva:");
            kiv.Kirajzol();

            File.WriteAllLines($"sudoku{size}.txt", data.Where(x => x.Meret == size).Select(x => x.Kezdo).ToList());
            Console.WriteLine($"8. feladat: sudoku{size}.txt állomány {data.Where(x => x.Meret == size).Count()} darab feladvánnyal létrehozva");

        }
    }
}
