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

                Exception ex = new Exception("oops...something went wrong");

                _logger.Debug(requestID, "debug...debug...debug");

                LogItem item = new LogItem();
                item.RequestId = requestID;
                item.ShortMessage = "short message";
                item.FullMessage = "full message";
                _logger.Info(item);

                _logger.Info(requestID, "info...info...info");
                _logger.Warn(requestID, "warn...warn...warn");
                _logger.Warn(requestID, "warn...warn...warn");
                _logger.Error(requestID, "err...eerr..eeer.", ex);
                _logger.Fatal(requestID, "fatal..fatal..fatal", ex);

                Thread.Sleep(TimeSpan.FromMilliseconds(10));
            }
        }
    }
}
