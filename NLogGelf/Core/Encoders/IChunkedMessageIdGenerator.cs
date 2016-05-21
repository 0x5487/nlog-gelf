namespace NLogGelf.Core.Encoders
{
    public interface IChunkedMessageIdGenerator
    {
        byte[] GenerateId(byte[] message);
    }
}