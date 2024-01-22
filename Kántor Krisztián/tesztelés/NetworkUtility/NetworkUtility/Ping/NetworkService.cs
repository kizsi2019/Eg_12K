using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    
    public class NetworkService
    {
        public string SendPing()
        {
            return "Sikeres Ping";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
        public string PozitivNegativNulla()
        {
            int a = -1;
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
