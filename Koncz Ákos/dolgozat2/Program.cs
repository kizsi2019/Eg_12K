using System;
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
            Console.WriteLine("Adj meg egy szöveget");
            string palindrom = Console.ReadLine();

            palindrom.ToCharArray();
            IEnumerable<char> palind = palindrom.Reverse();

            if (palind == palindrom)
            {
                Console.WriteLine("Ez egy palindrom");
            }
            else
            {
                Console.WriteLine("Ez nem egy palindrom");
            }




            Console.ReadKey();
        }
    }
}
