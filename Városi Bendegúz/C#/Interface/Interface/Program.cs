using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Interface // Note: actual namespace depends on the project name.
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



            static void Main(string[] args)
                {
                    Köszönés_Üdvözlés koszi = new Köszönés_Üdvözlés();
                    koszi.Reggel();
                    koszi.Este();
                    koszi.Napközben();
                    koszi.Szia("Béla");
                    Console.ReadKey();
                }
            }
        }
    }
