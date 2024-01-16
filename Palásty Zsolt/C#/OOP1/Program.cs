using System;
namespace OOP1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Ember e = new Ember();
            e.Név = "Tóth József";
            e.Életkor = 32;
            e.Lakhely = "Eger";
            e.Munkahely = "XYZ Kft.";
            e.Kiír();
            Ember e2 = e;
            e2.Név = "Horvát Béla";

            e2.Kiír();
            Console.ReadKey();
        }
    }
}