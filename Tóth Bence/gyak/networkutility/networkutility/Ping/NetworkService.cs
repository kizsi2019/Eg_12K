using networkutility.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace networkutility.Ping
{
    public class NetworkService
    {
        private readonly IDNS _dNS;
        public NetworkService(IDNS dNS)
        {
            _dNS = dNS;
        }    
        
        public string SendPing()
        {
            return "Succes:Ping sent!";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public string Teljes(int a)
        {
            if (a < 0)
            {
                return ("Negativ");
            }
            else if (a == 0)
            {
                return ("Zero");
            }
            else
            {
                return ("Positiv");
            }

        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }
    }
}
