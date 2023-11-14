using System;
using System.Linq;

namespace dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szöveget");
            string palindrom = Console.ReadLine();

            char[] charArray = palindrom.ToCharArray();
            Array.Reverse(charArray);
            string reversedPalindrom = new string(charArray);

            if (palindrom == reversedPalindrom)
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
