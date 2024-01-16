using System;
using System.Collections.Generic;
using System.Text;

namespace OP1
{
    internal class Ember
    {
        public string Név;
        public int Életkor;
        public string Lakhely;
        public string Munkahely;
        public void Kiir()
        {
            Console.WriteLine("Név: " + Név);
            Console.WriteLine("Életkor: " + Életkor);
            Console.WriteLine("Lakhely: " + Lakhely);
            Console.WriteLine("Munkahely: " + Munkahely);
        }
    }
}
