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
            Console.WriteLine("Kérek szépen egy nevet: ");
            string name = Console.ReadLine();
            name.ToUpper();
            listAdd();
            double avg = 0.0;
            int sum = 0;
            int count = 0;
            foreach (int item in gradeList)
            {
                sum += item;
                count += 1;
            }
            avg = sum / count;
            double avgRounded = Math.Round(avg, 2);
            Console.WriteLine($"{name} átlaga: {avgRounded}");
            bestGrade();
            worstGrade();
            Console.WriteLine($"{name} legjobb jegye: {bestGrade()}");
            Console.WriteLine($"{name} legrosszabb jegye: {worstGrade()}");
            Console.ReadKey();
        }

        static List<int> gradeList = new List<int>();
        static void listAdd()
        {
            gradeList.Add(4);
            gradeList.Add(2);
            gradeList.Add(3);
            gradeList.Add(4);
            gradeList.Add(5);
            gradeList.Add(5);
            gradeList.Add(5);
            gradeList.Add(5);
            gradeList.Add(3);
            gradeList.Add(4);
        }    
        
        
        static int bestGrade()
        {
            int best = 0;
            foreach(int item in gradeList)
            {
                if(item > 1)
                {
                    best += item;
                }
            }
            return best;
        }

        static int worstGrade()
        {
            int worst = 0;
            foreach(int item in gradeList)
            {
                if (item < 1)
                {
                    worst += item;
                }
            }
            return worst;
        }
    }
}
