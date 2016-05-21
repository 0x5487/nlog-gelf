using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Fluent;

namespace NLogGelf
{
    public class Logger
    {
        private readonly ILogger _logger;

        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public ILogger NLogger
        {
            get { return _logger; }
        }

        public void Info(string requestId, string message)
        {
            _logger.Info()
                .Message(message)
                .Property("request_id", requestId)
                .Write();
        }

        public void Info(LogItem item)
        {
            var builder = _logger.Info()
                .Message(item.FullMessage)
                .Property("request_id", item.RequestId)
                .Property("short_message", item.ShortMessage);

            foreach (var customField in item.CustomFields)
            {
                var key = "_" + customField.Key;
                builder.Property(key, customField.Value);
            }

            builder.Write();
        }
    }
}
