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
            return "Ping sent";
        }
        public int PinkTimeout(int a, int b)
        {
            return a + b;
        }
    }
}
