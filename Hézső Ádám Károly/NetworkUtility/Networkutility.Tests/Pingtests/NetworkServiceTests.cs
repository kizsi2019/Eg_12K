using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NetworkUtility.Ping;

namespace Networkutility.Tests.Pingtests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_returnString()
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping sent");
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.PingTimeout(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
        [Theory]
        [InlineData(1, "Pozitív")]
        [InlineData(0, "Zero")]
        [InlineData(-2, "Negatív")]
        public void NetworkService_Teljes_Return(int a, string expected)
        {
            //Arrange
            var pinger = new NetworkService();
            //Act
            var result2 = pinger.Teljes(a);
            //Assert
            result2.Should().BeOneOf("Pozitív", "Zero", "Negatív");
            
        }
    }
}
