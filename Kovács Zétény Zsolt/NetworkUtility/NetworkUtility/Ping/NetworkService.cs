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
            return "Succes: Ping sent!";
        }   
        public int PingTimeOut(int a, int b)
        {
            return a + b;
        }

        public string Teljes()
        {
            int a = 0;
            if (a > 0)
            {
                return "Pozitív";
            }
            else if (a < 0)
            {
                return "Negatív";
            }
            else { return "Nulla"; }
        }
    }
}
