using System;
namespace OOP1
{
    class Program
    {
        class Ember
        {
            public string Név;
            public int Életkor;
            public string Lakhely;
            public string Munkahely;
            public void Kiír()
            {
                Console.WriteLine("Név: " + Név);
                Console.WriteLine("Életkor: " + Életkor);
                Console.WriteLine("Lakhely: " + Lakhely);
                Console.WriteLine("Munkahely: " + Munkahely);
            }
        }
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