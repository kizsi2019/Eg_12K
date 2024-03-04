using NetworkUtility.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace NetworkUtility.Ping
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
            var dnsSucces=_dNS.sendDNS();
            if (dnsSucces)
            {
                return "succesful Ping";
            }
            else { return "failed"; }
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
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
                new PingOptions
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions
                {
                    DontFragment = true,
                    Ttl = 1
                },
            };
            return pingOptions;
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
