namespace Ember_class
{
    internal class Program
    {
        

        
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