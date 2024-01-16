using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace network_utility.Ping
{
    internal class NetworkService
    {
        public string PositiveNegativeZero(int a)
        {
            if (a > 0)
            {
                return "Pozitív";

            }
            else if (a < 0)
            {
                return "Negatív";
            }
            else
            {
                return "Nulla";
            }
        }
    }
}
