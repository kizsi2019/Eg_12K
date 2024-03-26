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
    
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dNS;

        public NetworkServiceTests()
        {
            //Dependencies
            _dNS = A.Fake<IDNS>();
            
                //SUT
            _pingService = new NetworkService(_dNS);
        }
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            A.CallTo(() => _dNS.SendDNS()).Returns(true);
            //Act
            var result=_pingService.SendPing();
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Succes: Ping sent!");
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService=new NetworkService(_dNS);
            //Act
            int result = pingService.PingTimeout(a, b);
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

        public void NetworkService_LastPingDate_ReturnString()
        {
            //Arrange

            //Act
            var result = _pingService.LastPingDate();
            
            //Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }
        [Fact]
        public void NetwrokService_GetPingOptions_ReturnsObject()
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
        public void NetwrokService_MostRecentPings_returnsObject()
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
            result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
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
        }
        
    }
}
