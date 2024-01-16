using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitytest
{
    public class Calculator
    {
        public int AddTwoNumbers(int first, int second)
        {
            return first + second;
        }

        public string IsAString(object input)
        {
            if (input == null || !(input is string))
            {
                return "It's not a text";
            }

            return (string)input;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
        }
    }
}
