using FluentAssertions;
using NetWorkUtility.Ping;
using Xunit;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Succes: Ping Sent!");
            result.Should().Contain("Ping", Exactly.Once());


        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 2, 4)]

        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.PingTimeout(a,b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000,0);
        }
    }
}
