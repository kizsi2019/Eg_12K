﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellenorzott_adatbekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A megaott szá? " + EllBekerf("Adj meg egy szamot 10-20 kött!", 10, 20));
            Console.ReadKey();
        }
        static int EllBekerf(string bekeresuzi, int mettol=int.MinValue, int meddig=int.MaxValue )
        {
            int szam;
            do
            {
                Console.WriteLine(bekeresuzi);
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            return szam;
        }
    }
}
