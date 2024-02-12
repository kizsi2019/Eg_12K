using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using networkutility.Ping;

namespace NetworkUtility.Tests.Pingtests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;

        public NetworkServiceTests() 
        {
            _pingService = new NetworkService();
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arange

            //Act
            var result = _pingService.SendPing();
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
        [InlineData(1, "Positiv")]
        [InlineData(-2, "Negativ")]
        [InlineData(0, "Zero")]


        public void NetworkService_Teljes_Return(int a, string expected)
        {
            //Arrange
            var pinger = new NetworkService();
            //Act
            var result2 = pinger.Teljes(a);
            //Assert
            result2.Should().BeOneOf("Positiv", "Negativ", "Zero");
            

        }
    }
}
