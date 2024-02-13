using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Ember
    {
        public string Név;
        public int Életkor;
        public string Lakhely;
        public string Munkahely;
        public void Kiír()
        {
            Console.WriteLine("Név: " + Név);
            Console.WriteLine("Életkor: " + Életkor);
            Console.WriteLine("Lakhely: " + Lakhely);
            Console.WriteLine("Munkahely: " + Munkahely);
        }
    }
}
