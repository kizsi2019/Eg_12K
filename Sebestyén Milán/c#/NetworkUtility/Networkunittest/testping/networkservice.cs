using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networkunittest.testping;

namespace Networkunittest.testping
{
    public class networkservice
    {
        [Fact]
        public void networkseviceSendPingreturnString()
        {
            var pingservices = new networksevice();

            var result = pingservices.SendPing();
        }
    }
}
