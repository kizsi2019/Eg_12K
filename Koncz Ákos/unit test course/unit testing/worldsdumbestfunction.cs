﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing
{
    public class worldsdumbestfunction
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if (num == 0)
            {
                return "PIKACHU";
            }
            else
            {
                return "Sajnos nem PIKACHU";
            }
        }
    }
}
