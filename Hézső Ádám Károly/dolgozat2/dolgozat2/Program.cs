﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy söveget: ");
            string szovg = Console.ReadLine();
            szovg.Reverse();
        }
    }
}
