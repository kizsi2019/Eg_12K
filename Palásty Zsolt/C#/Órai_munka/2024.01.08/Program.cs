using System;
namespace Properti1
{
    class Program
    {
        class Ember
        {
            public Ember(string n, int é, int isz)
            {
                Név = n;
                Életkor = é;
                Irányítószám = isz;
            }
            private string név;
            public string Név
            {
                get { return név; }
                set
                {
                    if (value.Length != 0)
                    {
                        név = value;
                    }
                    else
                    {
                        Exception("A név mező nem lehet üres!");
                    }
                }
            }
            private int életkor;
            public int Életkor
            {
                get { return életkor; }
                set
                {
                    if (value >= 0)
                    {
                        életkor = value;
                    }
                    else
                    {
                        Exception("A életkor mező nem lehet negatív!");
                    }
                }
            }
            private int irányítószám;
            public int Irányítószám
            {
                get { return irányítószám; }
                set
                {
                    if (value.ToString().Length == 4)
                    {
                        irányítószám = value;
                    }
                    else
                    {
                        Exception("Az irányítószám mező helytelen!");
                    }
                }
            }
            private void Expection(string s)
            {
                throw new FormatException(s);
            }

        }
        static void Main(string[] args)
        {
            Ember e = new Ember("Józsi, 10, 9456");
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Irányítószám);
        }
    }
}