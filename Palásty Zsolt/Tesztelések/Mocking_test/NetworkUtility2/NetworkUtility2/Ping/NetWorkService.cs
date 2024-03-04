using NetworkUtility2.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility2.Ping
{
    public class NetWorkService
    {
        private readonly IDNS _dNS;
        public NetWorkService(IDNS dNS)
        {
            _dNS = dNS;
        }
        public string SendPing()
        {
            var dnsSucces = _dNS.SendDNS();
            if (dnsSucces)
            {
                return "Succes: Ping sent!";
            }
            else
            {
                return "Failed: Ping not sent!";
            }
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
            IEnumerable<PingOptions> pingOtions = new[]
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
            return pingOtions;
        }
    }
}
