using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek szépen egy szöveget");
            string text = Console.ReadLine();
            
            bool palindrom = false;

            if(text[-1] == text[0])
            {
                palindrom = true;
                Console.WriteLine("A szöveg palindrom!");
            }
            else
            {
                Console.WriteLine("A szöveg nem palindrom!");
            }
        }
    }
}
