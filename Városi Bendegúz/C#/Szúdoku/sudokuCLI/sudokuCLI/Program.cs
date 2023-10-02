using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace sudokuCLI
{
    public struct Data
    {
       public string stg { get; set; }
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
            foreach(Data item in lista)
            {
                Console.WriteLine(item);
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
               
                Console.WriteLine("Nem jó");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    }

