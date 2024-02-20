using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Extensions;
using networkutility.Ping;
using networkutility.DNS;

namespace NetworkUtility.Tests.Pingtests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dNS;
        public NetworkServiceTests() 
        {
            _dNS = A.Fake<IDNS>();

            _pingService = new NetworkService(_dNS);
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
        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            var result = _pingService.LastPingDate();

            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }
        [Fact]
        public void NetworkService_GetPingOptions_ReturnObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _pingService.GetPingOptions();


            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);

        }

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions
                {
                    DontFragment= true,
                    Ttl= 1
                },
                new PingOptions
                {
                    DontFragment= true,
                    Ttl= 1
                },
                new PingOptions
                {
                    DontFragment= true,
                    Ttl= 1
                },
            };
            return pingOptions;
        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _pingService.MostRecentPings();


            result.Should().BeOfType<PingOptions>();
            result.Should().ConainEquivalent(expected);
            result.Should().Contain(1);

        }
    }
}
