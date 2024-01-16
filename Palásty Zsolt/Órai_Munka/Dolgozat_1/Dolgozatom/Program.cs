using System;
namespace Dolgozat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Feladat: Írj egy olyan programot, ami bekéri a felhasználó nevét, és egy általa választott tantárgyának a jegyeit. Ez után a program írja ki,
            mennyi a felhasználónak az átlaga (két tizedesjegyre kerekítve), melyik a legjobb jegye és melyik a legrosszabb jegye. A nevet nagy betűvel írja ki a program.*/
            Console.WriteLine("Kérlek, add meg a nevedet: ");
            string name = Console.ReadLine();
            Console.WriteLine("Kérlek, vesszővel elválasztva add meg egy általad választott tatnárgyad jegyeit: ");
            string grades = Console.ReadLine();

            Console.WriteLine(ToUpper(name) + "átlaga: " + GradeAvg());
            Console.WriteLine(ToUpper(name) + "legnagyobb osztályzata: " + maximum);
            Console.WriteLine(ToUpper(name) + "legkisebb osztályzata: : " + minimum);

            List<int> grade_list = new List<int>();
            foreach (int i in grades)
            {
                int osztalyzat = Convert.ToInt32(grades.Split(',')[i]);
                grade_list.Add(osztalyzat);

            }
            int maximum= 0;
            foreach (int i in grade_list)
            {
                if (i > maximum) { 
                    maximum = i;
                }
            }
            int minimum = 11;
            foreach (int i in grade_list)
            {
                if(i<minimum)
                {
                    minimum = i;
                }
            }
            static float GradeAvg()
            {
                int count = 0;
                foreach(int i in grade_list)
                {
                    count += i;
                }
                float avg = count / grade_list.Length;
                float r_avg = Math.Round(avg, 2);
                return r_avg;
            }
        }
    }
}