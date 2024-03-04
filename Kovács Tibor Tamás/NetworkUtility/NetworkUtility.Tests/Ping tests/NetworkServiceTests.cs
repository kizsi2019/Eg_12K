using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.DNS;
using NetworkUtility.Ping;
using NetworkUtility.DNS;
using FakeItEasy;

namespace NetworkUtility.Tests.Ping_tests
{
    public class NetworkServiceTests

    {
        private readonly IDNS _dNS;
        private readonly NetworkService _pingService;
        public NetworkServiceTests() 
        {
          
            _dNS =  A.Fake<IDNS>();

            _pingService = new NetworkService(_dNS);
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            A.CallTo(() => _dNS.sendDNS()).Returns(true);
            //Act
            var result = _pingService.SendPing();
            //Assert
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
            var pingService = new NetworkService(_dNS);
            //Act 
            var result = pingService.PingTimeOut(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

        
    
        
        [Theory]
        [InlineData(-1,"Negatív")]
        [InlineData(2,"Pozitív")]
        [InlineData(0, "Nulla")]
        public void NetworkServiceTeljesReturnString(int a, string expected)
        {
            var NumCheck = new NetworkService(_dNS);

            var result2 = NumCheck.Teljes();

           
            result2.Should().BeOneOf(
                "Pozitív",
                "Negatív",
                "Nulla"
                );
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            var result = _pingService.LastPingDate();

            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnsObject()
        {
            var expecter = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _pingService.GetPingOptions();

            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expecter);
            result.Ttl.Should().Be(1);
        }

        
    }
}
