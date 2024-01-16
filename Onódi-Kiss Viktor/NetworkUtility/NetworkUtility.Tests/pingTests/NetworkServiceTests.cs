using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.pingTests
{
    internal class NetworkServiceTests
    {
        public void NetworkService_SendPing_returnString()
        {
            // Arrange
            var ping = new NetworkService();

            // Act
            var result = ping.SendPing();

            // Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping sent!");
        }
    }
}
