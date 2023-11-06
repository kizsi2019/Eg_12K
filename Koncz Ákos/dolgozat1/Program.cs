using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bekeres = true;
            string nev = "";

            while (bekeres == true)
            {
                Console.WriteLine("Add meg a neved");
                nev = Console.ReadLine().ToUpper();

                /*if (nev == string)
                {
                    bekeres = false;
                }*/
                bekeres = false;
            }
            

            // adatszerkezet
            List<int> jegyek = new List<int>();
            jegyek.Add(1);
            jegyek.Add(2);
            jegyek.Add(3);
            jegyek.Add(2);
            jegyek.Add(2);
            jegyek.Add(4);
            jegyek.Add(5);
            jegyek.Add(3);

            double count = 0;
            double summ = 0;
            double atlag = 0;

            foreach (int i in jegyek)
            {
                summ += i;
                count += 1;
                atlag = summ / count;
            }
            Console.WriteLine($"{nev} átlaga: {Math.Round(atlag, 2)}");

            // legjobb jegy

            int max = 0;


            foreach (int i in jegyek)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine($"{nev} legjobb jegye: {max}");


            //legrosszabb jegy

            int min = 999;


            foreach (int i in jegyek)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine($"{nev} legrosszabb jegye: {min}");
            Console.ReadKey();
        }
    }
}
