using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.DNS;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTests
{
    
    public class NetworkServiceTest
    {

        private readonly new NetworkService _pingService;
        private readonly IDNS _dNS;
        public NetworkServiceTest()
        {
            _dNS = A.Fake<IDNS>();
            //SUIT
            _pingService=new NetworkService(_dNS);
        }
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            A.CallTo(() => _dNS.sendDNS()).Returns(true);

            //Act
            var result=_pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("succesful Ping");
            result.Should().Contain("Ping", Exactly.Once());
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Act
            int result = _pingService.PingTimeout(a, b);
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

        [Theory]
        [InlineData(1, "Pozitív")]
        [InlineData(-1, "Negatív")]
        [InlineData(0, "Nulla")]
        public void NetworkService_PozitivNegativNulla_ReturnString(int a,string expected)
        {
            //Arrange
            var pingService = new NetworkService(_dNS);
            //Act
            string result = pingService.PozitivNegativNulla();
            result.Should().BeOneOf("Pozitív", "Negatív", "Nulla");
            result.Should().BeOneOf("Pozitív", "Negatív", "Nulla");
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            //Act
            var result = _pingService.LastPingDate();
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnObject()
        {
            var expected=new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.GetPingOptions();
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
            result.DontFragment.Should().BeTrue();
        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.MostRecentPings();
            result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x=> x.DontFragment==true);
        }

    }
}
