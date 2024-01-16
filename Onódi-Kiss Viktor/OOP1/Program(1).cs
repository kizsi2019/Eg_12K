using System;

namespace OP1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Ember e = new Ember();
            e.Név = "Tóth József";
            e.Életkor = 32;
            e.Lakhely = "Eger";
            e.Munkahely = "XYZ Kft.";
            e.Kiir();
            Ember e2 = e;
            e2.Név = "Horváth Béla";

            e2.Kiir();
            Console.ReadKey();
        }
    }
}
