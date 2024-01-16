using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.ping;

namespace NetworkUtility.pingTest
{
    internal class networkservicetest
    {
        
        public void networkseviceSendPingreturnString()
        {
            var pingservices = new networksevice();

            var result = pingservices.SendPing();
        }
    }
}
