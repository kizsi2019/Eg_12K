using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
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
           Köszönés_Üdvözlés asd=new Köszönés_Üdvözlés();


            asd.Reggel();
            asd.Este();
            asd.Napközben();
            asd.Szia("szia");
            

            Console.ReadKey();
        }
    }
}
