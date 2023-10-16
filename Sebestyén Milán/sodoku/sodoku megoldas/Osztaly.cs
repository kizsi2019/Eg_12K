using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly
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
                if (Kezdo[i] == '0')
                {
                    Console.Write(". ");
                }
                else
                {
                    Console.Write(Kezdo[i]+" ");
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
        class program
        {
            static List<Feladvany> lista = new List<Feladvany>();
            static void Main(string[] args)
            {
                StreamReader sr = new StreamReader("feladvanyok.txt", Encoding.UTF8);
                string sor = "";
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    Feladvany f = new Feladvany(sor);
                    lista.Add(f);
                }
                sr.Close();

                Console.WriteLine("3. feladat");
                Console.WriteLine(lista.Count());

                Console.WriteLine("4. feladat");
                int meret = 0;
                do
                {
                    Console.WriteLine("kerema meretet 4es 9 közöttt");
                    meret = Convert.ToInt32(Console.ReadLine());
                } while (4 > meret || meret > 9);
                int meretdb = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Meret == meret)
                    {
                        meretdb++;
                    }

                }
                Console.WriteLine("alegnagyobbmeretbőlennyialegnagyobb");
                Console.WriteLine(  meretdb);

                Console.WriteLine("5.feladat");
                Random r = new Random();
                int kivalasztottindex = 0;
                do
                {
                    kivalasztottindex = r.Next(0, lista.Count);
                } while (lista[kivalasztottindex].Meret != meret);
                Console.WriteLine("a kisorsolt elem kezdoallapota"+ lista[kivalasztottindex].Kezdo);

                Console.WriteLine("6. feladat");
                int nemNulldb = 0;
                int hossz = lista[kivalasztottindex].Kezdo.Length;
                for (int i = 0; i < hossz; i++)
                {
                    if (lista[kivalasztottindex].Kezdo[i]!=0)
                    {
                        nemNulldb++;
                    }

                }
                double kitoltotseg =(double)nemNulldb / hossz * 100;

                Console.WriteLine("a feladvany kitoltotsege"+  Math.Round(kitoltotseg,0)+"%");

                Console.WriteLine("7. feladat");
                Console.WriteLine("kep");

                lista[kivalasztottindex].Kirajzol();

                Console.WriteLine("8. feladat");
                string faljneve = "sodoku" + meret + ".txt";
                StreamWriter sw = new StreamWriter(faljneve);
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Meret == meret)
                    {
                        sw.WriteLine(lista[i].Kezdo);
                    }
                    
                }
                sw.Close();







                Console.ReadKey();

            }
        }
    }
}
