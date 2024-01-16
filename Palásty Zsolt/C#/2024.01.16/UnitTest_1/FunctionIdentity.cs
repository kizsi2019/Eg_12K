using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_1
{
    public class FunctionIdentity
    {
        public string ReturnIdentityOfNumber(int num)
        {
            if (num >= 0)
            {
                return "The number is positive";
            }
            else if (num == 0)
            {
                return "The number is zero";
            }
            else
            {
                return "The number is negative";
            }

        }
    }
}
