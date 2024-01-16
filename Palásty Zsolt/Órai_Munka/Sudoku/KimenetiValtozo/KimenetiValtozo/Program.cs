using System;
namespace KimenetiValtozo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool paros;
            Paros(10, out paros);
            Console.ReadKey();
        }
        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0)
            {
                log = true;
                Console.WriteLine("Páros");
            }
            else
            {
                log = false;
            }
        }
    }
}