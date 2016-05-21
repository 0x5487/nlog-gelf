using System.Collections.Generic;

namespace NLogGelf.Core.Encoders
{
    public interface ITransportEncoder
    {
        IEnumerable<byte[]> Encode(byte[] bytes);
    }
}