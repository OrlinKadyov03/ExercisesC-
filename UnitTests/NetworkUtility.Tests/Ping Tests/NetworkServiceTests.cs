using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.Dns;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.Ping_Tests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDns _dns;
        public NetworkServiceTests()
        {
            _dns = A.Fake<IDns>();
            _pingService = new NetworkService(_dns);
        }
        [Fact]

        public void NetworkService_SendPing_ReturnString() 
        {
            A.CallTo(() => _dns.SendDNS()).Returns(true);
            // arrange - variables , classes, mocks

            // Act

            var result = _pingService.SendPing();

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

            // act
            var result = _pingService.PingTimeout(a,b);

            // assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);
        }

        [Fact]
        public void NetworkService_LastDatePing_ReturnDate()
        {
            // arrange

            // act
            var result = _pingService.LastDatePing();

            // assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnObject()
        {
            // arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            // act
            var result = _pingService.GetPingOptions();

            // assert
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }
        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            // arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            // act
            var result = _pingService.MostRecentPings();

            // assert
           // result.Should().BeOfType<IEnumerable<PingOptions>>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x  => x.DontFragment == true);
        }
        [Fact]

        public void NetworkService_SendPingTwo_ReturnString()
        {
            // arrange - variables , classes, mocks

            // Act

            var result = _pingService.SendPingTwo();

            //Assert

            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Two sent!");
            result.Should().Contain("Success", Exactly.Once());


        }
    }
}
