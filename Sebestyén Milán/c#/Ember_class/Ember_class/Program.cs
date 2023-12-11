namespace Ember_class
{
    internal class Program
    {
        class Ember
        {
            public string Név;
            public int Kor;
            public string Lakhely;
            public string Munkahely;
            public void Kiír()
            {
                Console.WriteLine("Név: "+Név);
                Console.WriteLine("Kor: " + Kor);
                Console.WriteLine("Lakhely: " + Lakhely);
                Console.WriteLine("Munkahely: " + Munkahely);

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Ember e=new Ember();
            e.Név = "Sebestyén Milán";
            e.Kor = 18;
            e.Lakhely = "Budapest";
            e.Munkahely = "Nincs";
            e.Kiír();

            Ember e2 = e;
            e2.Név = "Kiss Imre";

            e2.Kiír();
            Console.ReadKey();

        }
    }
}