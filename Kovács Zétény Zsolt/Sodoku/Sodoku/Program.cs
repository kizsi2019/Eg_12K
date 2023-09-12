using System;
using System.Collections.Generic;
using System.IO;

namespace sudokuCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader read = new StreamReader("feladvanyok.txt");
            while (!read.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(read.ReadLine()));
            }
            read.Close();
            Console.WriteLine("3. feladat: Beolvasva {0} feladvány", feladvanyok.Count);

            int meret;
            do
            {
                Console.Write("4. feladat: Kérem a feladvány méretét [4..9]: ");
            }
            while (!int.TryParse(Console.ReadLine(), out meret) || meret < 4 || meret > 9);


            List<Feladvany> nElemuFeladvanyok = new List<Feladvany>();
            foreach (var f in feladvanyok)
            {
                if (f.Meret == meret)
                {
                    nElemuFeladvanyok.Add(f);
                }
            }

            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", meret, nElemuFeladvanyok.Count);

         
            Random rand = new Random();
            int index = rand.Next(nElemuFeladvanyok.Count);
            var kivalasztottFeladvany = nElemuFeladvanyok[index];

            Console.WriteLine("5. feladat: A kiválaszott feladvány: ");
            Console.WriteLine(kivalasztottFeladvany.Kezdo);

            double db = 0;
            foreach (char szamjegy in kivalasztottFeladvany.Kezdo)
            {
                if (szamjegy != '0')
                {
                    db++;
                }
            }
            Console.WriteLine("6. feladat: A feladvány kitöltöttsége: {0:f0}%)", 100 * db / kivalasztottFeladvany.Kezdo.Length);

        }
    }
}