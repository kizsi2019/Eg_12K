using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility2.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        private readonly NetWorkService _pingService;

        public NetworkServiceTests() 
        {
            // SUT
            _pingService = new NetWorkService();
        }
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            
            // Act
            var result = _pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Succes: Ping sent!");
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var _pingService = new NetWorkService();
            //Act
            var result = _pingService.PingTimeout(a, b);
            //Assert 
            result.Should().Be(expected);   
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
        [Fact]
        public void NetworkService_LasPingDate_ReturnDate()
        {
            //Arrange

            // Act
            var result = _pingService.LastPingDate();
            //Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
            
        }
        [Fact]
        public void NetworkService_GetPingOptions_ReturnsObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act
            var result = _pingService.GetPingOptions();

            //Assert Warning: "Be carefull"
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnsObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act
            var result = _pingService.MostRecentPings();
            //Assert Warning: "Be carefull"
            result.Should().BeOfType<PingOptions[]> ();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
        }
    }
}
