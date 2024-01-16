using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_course
{
    public class worlds_dumbest_function
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if(num == 0)
            {
                return "PIKACHU";
            }
            else
            {
                return "Sajnos nem Pikachu";
            }
        }
    }
}
