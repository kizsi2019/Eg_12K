using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property1
{
    
    internal class Program
    {
        class Ember
        {
            public Ember(string n, int é, int isz)
            {
                Név = n; Életkor = é; Iranyitoszam = isz;
            }
            private string név;
            public string Név
            {
                get { return név; }
                set
                {
                    if (value.Length != 0) név = value;
                    else Exception("A név mező nem lehet üres! :(");
                }
            }

            private int életkor;
            public int Életkor
            {
                get { return életkor; }
                set
                {
                    if (value >= 0) életkor = value;
                    else Exception("Az életkor nem lehet negatív! :/");
                }
            }

            private int iranyitószam;
            public int Iranyitoszam
            {
                get { return iranyitószam; }
                set
                {
                    if (value.ToString().Length == 4) iranyitószam = value;
                    else Exception("Az irányítószá mező helytelen!");
                }
            }

            private void Exception(string s)
            {
                throw new FormatException(s);
            }

        }
        static void Main(string[] args)
        {
            Ember e = new Ember("Józsi", 10, 9999);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Iranyitoszam);
            Console.ReadKey();
        }

    }
}
