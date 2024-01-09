namespace oraii
{
    internal class Program
    {
        class Ember
        {
            public string Név;
            public int Életkor;
            public string Lakhely;
            public string Munkahely;
            public void Kiir()
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
            e.Név = "Toth Jozsef";
            e.Életkor = 19;
            e.Lakhely = "Budapest";
            e.Munkahely = "Lakatos testverek";
            Ember e2 = e;
            e2.Név = "Horváth Béla";
            e2.Kiir();
            Console.ReadKey();
        }
    }
}
