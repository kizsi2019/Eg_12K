using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTests
{

    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Sikeres Ping");
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            int result = pingService.PingTimeout(a, b);
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

        [Theory]
        [InlineData(1, "Pozitív")]
        [InlineData(-1, "Negatív")]
        [InlineData(0, "Nulla")]
        public void NetworkService_PozitivNegativNulla_ReturnString(int a, string expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            string result = pingService.PozitivNegativNulla();
            result.Should().BeOneOf("Pozitív", "Negatív", "Nulla");
        }

    }
}
