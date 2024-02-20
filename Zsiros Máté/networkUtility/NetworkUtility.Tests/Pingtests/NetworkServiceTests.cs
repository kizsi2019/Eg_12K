using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using networkutility.DNS;
using networkutility.Ping;

namespace NetworkUtility.Tests.Pingtests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dNS;
        public NetworkServiceTests() 
        { 
            _dNS = A.Fake<IDNS>();
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

        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            // Arrange

            //Act
            var result = _pingService.LastPingDate();

            //Assert
            result.Should().BeAfter(1.January(2012));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnObject()
        {
            // Arrange

            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act
            var result = _pingService.GetPingOptions();

            //Assert
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            // Arrange

            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act
            var result = _pingService.MostRecentPings();

            //Assert
            result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
        }
    }
}
