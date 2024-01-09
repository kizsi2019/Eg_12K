using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        class Kutya
        {
            public string Név;
            private int ÉhségJelző = 50;
            public void Etet(int étel)
            {
                ÉhségJelző -= étel;
            }
            public void Játék()
            {
                if (ÉhségJelző<=80)
                {
                    ÉhségJelző += 50;
                    Console.WriteLine("Játék...");
                }
                else
                {
                    Console.WriteLine("A kutya éhes, nem tudsz játszani vele!");
                }
            }
        }
        
        static void Main(string[] args)
        {
            Kutya k = new Kutya();
            k.Játék();
            k.Játék();
            k.Etet(50);
            k.Játék();
            k.Játék();
            Console.ReadKey();
        }
    }
}
