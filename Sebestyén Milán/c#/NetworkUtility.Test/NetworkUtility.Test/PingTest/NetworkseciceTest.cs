using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NetworkUtility.Ping;

namespace NetworkUtility.Test.PingTest
{
    public class NetworkseciceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            var pingservice = new NetworkService();

            var result = pingservice.SendPing();
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("ping sent");
            result.Should().Contain("sent", Exactly.Once());
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a,int b,int expected) {
            var pingservice = new NetworkService();

            var result=pingservice.PingTimeout(a,b);
            result.should().be(expected);
            result.Should().BeGreaterThanOrEqualTo(3);
            result.Should().NotBeInRange(-100000, 0);

        }
    }
}
