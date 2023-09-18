using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace szudoku
{
    struct Data
    {
        public string strings { get; set; }
    }
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
                    Console.Write(".");
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
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Data> lista = new List<Data>();
            Import(lista);

            foreach(Data i in lista)
            {
                Console.WriteLine(i);
            }

            // 2. feladat

            Console.WriteLine("Adj egy szamot 4 és 9 között");
            string szam = Console.ReadLine();

            while (Convert.ToInt32(szam) >= 4 && Convert.ToInt32(szam) <= 9)
            {
                Console.WriteLine(szam);
            }
        }

        static void Import(List<Data> lista)
        {
            try
            {

                using (StreamReader sr = new StreamReader("feladvanyok.txt"))
                {
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
