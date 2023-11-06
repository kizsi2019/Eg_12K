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
            //1feladat
            Console.WriteLine("Kérek egy nevet");
            string name = Console.ReadLine().ToUpper();

            bool igaz = true;

            List<int> lista = new List<int>();
            do
            {
                Console.WriteLine("Jegyek vesszővel elválasztva");
                string[] grades = Console.ReadLine().Split(',');
                int a = 0;
                foreach (string item in grades)
                {
                    if (Convert.ToInt32(item) < 1 || Convert.ToInt32(item) > 5)
                    {
                        a = 1;
                    }
                }
                if (a != 1)
                {
                    igaz = false;
                }
                if (a != 1)
                {
                    foreach (string item2 in grades)
                    {
                        lista.Add(Convert.ToInt32(item2));
                    }
                }
            } while (igaz == true);

            int sum = 0;
            foreach (int item in lista)
            {
                sum += item;
            }
            double avg = Math.Round(Convert.ToDouble(sum) / lista.Count(), 2);
            Console.WriteLine(name + " Átlag" + avg);

            int maximum = 0;
            foreach (int item in lista)
            {
                if (item > maximum)
                {
                    maximum = item;
                }
            }
            Console.WriteLine(name + " legjobb:" + maximum);

            int minimum = 999999;
            foreach (int item in lista)
            {
                if (item < minimum)
                {
                    minimum = item;
                }
            }

            Console.WriteLine(name + " legrosszabb:" + maximum);
            Console.ReadKey();
        }
    }
}