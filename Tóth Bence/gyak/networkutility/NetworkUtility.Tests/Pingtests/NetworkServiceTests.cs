using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using networkutility.Ping;

namespace NetworkUtility.Tests.Pingtests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arange
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();
            //assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Succes:Ping sent!");
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_returnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.PingTimeout(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(expected);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
