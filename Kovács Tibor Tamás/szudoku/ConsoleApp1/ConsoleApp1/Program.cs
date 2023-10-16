using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
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
        class Feladvany
        {
            public string beginner { get; private set; }
            public int size { get; private set; }

            public Feladvany(string sor)
            {
                beginner = sor;
                size = Convert.ToInt32(Math.Sqrt(sor.Length));
            }

            public void Kirajzol()
            {
                for (int i = 0; i < beginner.Length; i++)
                {
                    if (beginner[i] == '0')
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(beginner[i]);
                    }
                    if (i % size == size - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

    }
