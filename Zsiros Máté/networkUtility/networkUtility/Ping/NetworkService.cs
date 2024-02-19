using networkutility.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
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

        public NetworkService()
        {
        }

        public string SendPing()
        {
            return "Succes:Ping sent!";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public string PositiveOrNot(int a)
        {
            if (a < 0)
            {
                return ("Negative, it is.");
            }
            else if (a == 0)
            {
                return ("Zero, it is.");
            }
            else
            {
                return ("Positive, it is.");
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

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions()
                {
                DontFragment = true,
                Ttl = 1
                },
                new PingOptions()
                {
                DontFragment = true,
                Ttl = 1
                },
                new PingOptions()
                {
                DontFragment = true,
                Ttl = 1
                }
            };
            return pingOptions;
        }
    }
}
