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
            Console.WriteLine("Add meg a jegyek mennyiségét: ");
            int jegyekszama = Convert.ToInt32(Console.ReadLine());


            // adatszerkezet + Bekeres
            int input;

            List<int> numbers = new List<int>();

            while (numbers.Count < jegyekszama)
            {
                Console.WriteLine("Jegy: ");


                input = Convert.ToInt32(Console.ReadLine());

                if (input >= 1 && input <= 5)
                {
                    numbers.Add(input);
                }
                else
                {
                    Console.WriteLine("Jegy: ");

                    input = Convert.ToInt32(Console.ReadLine());
                    if (input >= 1 && input <= 5)
                    {
                        numbers.Add(input);
                    }
                }
            }

            double count = 0;
            double summ = 0;
            double atlag = 0;

            foreach (int i in numbers)
            {
                summ += i;
                count += 1;
                atlag = summ / count;
            }
            Console.WriteLine($"{nev} átlaga: {Math.Round(atlag, 2)}");

            // legjobb jegy

            int max = 0;


            foreach (int i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine($"{nev} legjobb jegye: {max}");


            //legrosszabb jegy

            int min = 999;


            foreach (int i in numbers)
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
