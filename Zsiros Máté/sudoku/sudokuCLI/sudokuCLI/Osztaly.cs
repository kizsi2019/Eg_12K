using System;
using System.Collections.Generic;

class Feladvany
{
    public string Kezdo { get; private set; }
    public int Meret { get; private set; }

    public Feladvany(string sor)
    {
        Kezdo = sor;
        Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
    }

    public List<Feladvany> lista = new List<Feladvany>();

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

    public void Import()
    {
        System.IO.StreamReader read = new System.IO.StreamReader("feladvanyok.txt", System.Text.Encoding.UTF8);
        string line = " ";
        while (!read.EndOfStream)
        {
            line = read.ReadLine();
            Feladvany hozza = new Feladvany(line);
            lista.Add(hozza);
        }
        read.Close();
    }
}
