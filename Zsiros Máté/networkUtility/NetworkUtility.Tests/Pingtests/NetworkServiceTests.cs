using System;
using System.Collections.Generic;
using System.Configuration;
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
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
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
        [Theory]
        [InlineData(1, "Positive, it is.")]
        [InlineData(-2, "Negative, it is.")]
        [InlineData(0, "Zero, it is.")]
        public void NetworkService_PositiveOrNot_returnString(int a, string expected)
        {
            //Arrange
            var pinger = new NetworkService();
            //Act
            var result2 = pinger.PositiveOrNot(a);
            //Assert
            result2.Should().BeOneOf("Positive, it is.", "Negative, it is.", "Zero, it is.");
        }
    }
}
