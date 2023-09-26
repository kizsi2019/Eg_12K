using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SudokuCLI_Solution
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }
        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] != '0')
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
        class Program
        {
            static List<Feladvany> lista = new List<Feladvany>();
            static void Main(string[] args)
            {
                //beolvasás
                System.IO.StreamReader sr = new System.IO.StreamReader("feladvanyok.txt", Encoding.UTF8);
                string sor = "";
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    Feladvany f = new Feladvany(sor);
                    lista.Add(f);
                }
                sr.Close();
                Console.WriteLine("3. feladat");
                Console.WriteLine("Beolvasva ennyi feladvány: " + lista.Count);

                Console.WriteLine("4. feladat");
                int meret = 0;
                do
                {
                    Console.WriteLine("Kérem a méretét 4 és 9 között: ");
                    meret = Convert.ToInt32(Console.ReadLine());
                } while (meret<4 || meret > 9);
                int meretDB = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Meret == meret)
                    {
                        meretDB++;
                    }
                }
                Console.WriteLine("A megadott méretből ennyi van: " + meretDB);

                Console.WriteLine("5. feladat");

                Random r = new Random();
                int kivalasztottIndex = 0;
                do
                {
                    kivalasztottIndex = r.Next(0, lista.Count);
                } while (lista[kivalasztottIndex].Meret != meret);
                Console.WriteLine("A kisorsolt elem kezdő állapota: " + lista[kivalasztottIndex].Kezdo);

                Console.WriteLine("6. feladat");
                int nemNullaDb = 0;
                int hossz = lista[kivalasztottIndex].Kezdo.Length;
                for(int i = 0; i<hossz; i++)
                {
                    if (lista[kivalasztottIndex].Kezdo[i] != '0')
                    {
                        nemNullaDb++;
                    }
                }
                double kitoltottseg = (double)nemNullaDb / hossz * 100;
                Console.WriteLine("A feladvány kitöltöttsége : " + kitoltottseg + '%');

                Console.ReadKey();
            }
        }
    }
}