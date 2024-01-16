using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.PingTests
{
    class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_PositiveNegativeZero_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping sent:");
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InLineData(1,1,2)]
        [InLineData(2,2,4)]
        public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.RingTimeout(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanI
        }
    }
}
