using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember_class
{
    internal class Ember
    {

            public string Név;
            public int Kor;
            public string Lakhely;
            public string Munkahely;
            public void Kiír()
            {
                Console.WriteLine("Név: " + Név);
                Console.WriteLine("Kor: " + Kor);
                Console.WriteLine("Lakhely: " + Lakhely);
                Console.WriteLine("Munkahely: " + Munkahely);

            }
        
    }
}
