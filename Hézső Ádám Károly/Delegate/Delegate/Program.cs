using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            Console.WriteLine("Üdvözzöllek {0}!", név);
        }
        static void Üzenet(string név)
        {
            Console.WriteLine("Kedves {0}, köszönjük a belépésedet a rendszerbe...", név);
        }
        static void Main(string[] args)
        {
            Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üzenet);
            Console.Write("Add meg a nevedet: ");
            string név = Console.ReadLine();
            b(név);
            Console.ReadKey();
        }
    }
}
