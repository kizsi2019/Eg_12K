using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.Ping_tests
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
            //Arrange

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
            var pingService = new NetworkService();
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
            var NumCheck = new NetworkService();

            var result2 = NumCheck.Teljes();

           
            result2.Should().BeOneOf(
                "Pozitív",
                "Negatív",
                "Nulla"
                );
        }

        

    }
}
