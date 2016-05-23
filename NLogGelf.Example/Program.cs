using System;
using System.Threading;
using NLog;

namespace NLogGelf.Example
{
    public static class Program
    {
        public static void Main()
        {
            var _logger = LogManager.GetLogger("example").ToGelfLogger();
            
            while (true)
            {
                string requestID = Guid.NewGuid().ToString();

                LogItem item = new LogItem();
                item.RequestId = requestID;
                item.ShortMessage = "short message";
                item.FullMessage = "full message";
                

                _logger.Info(item);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
