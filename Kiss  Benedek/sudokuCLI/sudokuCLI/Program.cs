﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuCLI
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
        class Program
        {
            static void Main(string[] args)
            {
                System.IO.StreamReader read = new System.IO.StreamReader("feladvanyok.txt");
                read.ReadLine();
                List<Feladvany> lista = new List<Feladvany>();
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                }


                
            }
        }
    }
}
