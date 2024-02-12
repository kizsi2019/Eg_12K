using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWorkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            return "Succes: Ping Sent!";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
    }
}
