using System.Net;

namespace NLogGelf.Core.Transports.Udp
{
    public sealed class UdpTransportConfiguration
    {
        public IPEndPoint Host { get; set; }
    }
}