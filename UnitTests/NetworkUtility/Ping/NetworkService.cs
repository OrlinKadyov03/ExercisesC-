using NetworkUtility.Dns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        private readonly IDns _dns;

        public NetworkService(IDns dns)
        {
            this._dns = dns;
        }
        public string SendPing()
        {
            var dnsSuccess = _dns.SendDNS();
            if (dnsSuccess)
            {
                return "Success: Ping sent!";
            }else 
            {
                return "Failed: Ping not sent!";
            }
        }

        public string SendPingTwo()
        {
            return "Success: Ping Two sent!";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public DateTime LastDatePing()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }
        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingsOptions = new[]
            {
             new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            },
             new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            },
             new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            }

            };
            return pingsOptions;
        }
    }
}
