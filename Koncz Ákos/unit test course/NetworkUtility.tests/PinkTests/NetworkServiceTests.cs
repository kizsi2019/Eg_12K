using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.tests.PinkTests
{
    public class NetworkServiceTests
    {
        [Fact]

        public void NetworkService_SendPing_ReturnString()
        {
            int pingService = new NetworkService();
            int result = pingService.SendPing();

            result.Should().NotBeNullOrWhiteSpace();

            result.Should().Be("Success Ping sent");
            result.Should().Contain("Ping", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]

        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            var pingService = new NetworkService();

            var result = pingService.PingTimeout(a, b);

            result.Should().Be(expected);
            result.Should().BeGreaterThenOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

    }
}
