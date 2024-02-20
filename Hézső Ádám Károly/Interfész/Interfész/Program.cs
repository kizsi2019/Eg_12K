using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfész
{
    internal class Program
    {
        interface IKöszönés
        {
            void Reggel();
            void Este();
            void Napközben();
        }
        interface IÜdvözlés
        {
            void Szia(string név);
        }
        class Köszönés_Üdvözlés : IKöszönés, IÜdvözlés
        {
            public void Reggel() { Console.WriteLine("Jó reggelt!"); }
            public void Este() { Console.WriteLine("Jó estét!"); }
            public void Napközben() { Console.WriteLine("Jó napot!"); }
            public void Szia(string név) { Console.WriteLine("Szia {0}!", név); }
        }

        static void Main(string[] args)
        {
            Köszönés_Üdvözlés kosz = new Köszönés_Üdvözlés();
            kosz.Reggel();
            kosz.Este();
            kosz.Napközben();
            kosz.Szia("Lajos");
            





            Console.ReadKey();
        }
    }
}
