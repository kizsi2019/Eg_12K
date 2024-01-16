using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.ping
{
    public class networksevice
    {
        public string SendPing()
        {
            return "succes Ping";
        }
        public int PingTimeout(int a,int b) {
            return a + b;
        }

    }
}
