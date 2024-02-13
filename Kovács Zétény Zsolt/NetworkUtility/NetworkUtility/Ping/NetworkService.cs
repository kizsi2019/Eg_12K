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
        private readonly IDNS _dNS;
        public NetworkService(IDNS dNS)
        {
            _dNS = dNS;
        }
        public string sendPing()
        {
            var dnsSucces = _dNS.sendDNS();
            if (dnsSucces)
            {
                return "Succes: Ping sent";
            }
            else
            {
                return "Failed!";
            }
        }
    }
}
