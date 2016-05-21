using System.Net;

namespace NLogGelf.Core.Transports.Tcp
{
    public sealed class TcpTransportConfiguration
    {
        public IPEndPoint Host { get; set; }
    }
}