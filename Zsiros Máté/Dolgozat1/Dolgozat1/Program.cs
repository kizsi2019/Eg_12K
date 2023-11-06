using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = true;
            string name = "";

            while(input == true)
            {
                Console.WriteLine("Adj meg egy nevet");
                name = Console.ReadLine().ToUpper();
                input = false;
            }

            List<int> grades = new List<int>();
            grades.Add(1);
            grades.Add(3);
            grades.Add(4);

            double count = 0;
            double sum = 0;
            double avg = 0;

            foreach(int i in grades)
            {
                sum += i;
                count += 1;
                avg = sum / count;
            }
            Console.WriteLine($"{name} átlaga: {Math.Round(avg,2)}");

            int maximum = 0;
            foreach(int i in grades)
            {
                if(maximum < i)
                {
                    maximum = i;
                }
            }
            Console.WriteLine($"{name} legjobb jegye: {maximum}");

            int minimum = 999;
            foreach(int i in grades)
            {
                if(minimum > i)
                {
                    minimum = i;
                }
            }
            Console.WriteLine($"{name} legrosszabb jegye {minimum}");
            Console.ReadKey();
        }
    }
}
