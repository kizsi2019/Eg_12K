using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class Program
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if(num == 0)
            {
                return "PIKACHU!";
            }
            else
            {
                return "Sajnos nem Pikachu";
            }
        } 

        static void Main(string[] args)
        {
        }
    }
}
