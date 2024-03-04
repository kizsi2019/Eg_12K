using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility2.Ping
{
    public class NetWorkService
    {
        public string SendPing()
        {
            return "Succes: Ping sent!";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
    }
}
