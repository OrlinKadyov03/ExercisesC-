using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.Ping_Tests
{
    public class NetworkServiceTests
    {
        [Fact]

        public void NetworkService_SendPing_ReturnString() 
        {
            // arrange - variables , classes, mocks

            var pingService = new NetworkService();
            // Act

            var result = pingService.SendPing();

            //Assert

            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping sent!");
            result.Should().Contain("Success", Exactly.Once());


        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected) 
        {
            // arrange
            var pingService = new NetworkService();
            // act
            var result = pingService.PingTimeout(a,b);

            // assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);
        }
    }
}
