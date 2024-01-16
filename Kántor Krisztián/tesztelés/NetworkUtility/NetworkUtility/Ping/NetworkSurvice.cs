using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    
    public class NetworkSurvice
    {
        public string SendPing()
        {
            return "Sikeres Ping";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
    }
}
