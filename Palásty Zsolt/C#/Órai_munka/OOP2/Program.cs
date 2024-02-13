using System;
namespace OOP2
{
    class Program
    {
        class Kutya
        {
            public string Név;
            private int ÉhségJelző = 50;
            public void Etet(int étel)
            {
                ÉhségJelző -= étel;
            }
        }
        public void Játék()
        {
            if (ÉhségJelző <= 80)
            {
                ÉhségJelző += 50;
                Console.WriteLine("Játék...");
            }
            else
            {
                Console.WriteLine("A kutya éhes, nem tudsz játszani vele!");
            }
        }
        static void Main(string[] args)
        {
            Kutya k = new Kutya();
            k.Játék();
            k.Játék();

            k.Etet(100);
            k.Játék();
            Console.ReadKey();
        }
    }
}