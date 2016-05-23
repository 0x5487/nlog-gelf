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
    public class NGelfLogger : INGelfLogger
    {
        private readonly ILogger _logger;

        public NGelfLogger(ILogger logger)
        {
            _logger = logger;
        }

        public ILogger NLogger
        {
            get { return _logger; }
        }

        private static void SetValues(LogItem item, LogBuilder builder)
        {
            if (!string.IsNullOrWhiteSpace(item.RequestId))
            {
                builder.Property("request_id", item.RequestId);
            }

            if (!string.IsNullOrWhiteSpace(item.ShortMessage))
            {
                builder.Property("short_message", item.ShortMessage);
            }

            foreach (var customField in item.CustomFields)
            {
                var key = "_" + customField.Key;
                builder.Property(key, customField.Value);
            }
        }

        public void Debug(string requestId, string message)
        {
            _logger.Debug()
                .Message(message)
                .Property("request_id", requestId)
                .Write();
        }

        public void Debug(LogItem item)
        {
            var builder = _logger.Debug()
                .Exception(item.Exception)
                .Message(item.FullMessage);

            SetValues(item, builder);
            builder.Write();
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
                .Exception(item.Exception)
                .Message(item.FullMessage);

            SetValues(item, builder);
            builder.Write();
        }

        public void Warn(string requestId, string message)
        {
            _logger.Warn()
                .Message(message)
                .Property("request_id", requestId)
                .Write();
        }

        public void Warn(LogItem item)
        {
            var builder = _logger.Info()
                .Exception(item.Exception)
                .Message(item.FullMessage);

            SetValues(item, builder);
            builder.Write();
        }

        public void Error(string requestId, string message, Exception exception = null)
        {
            _logger.Error()
                .Message(message)
                .Exception(exception)
                .Property("request_id", requestId)
                .Write();
        }


        public void Error(LogItem item)
        {
            var builder = _logger.Error()
                .Message(item.FullMessage)
                .Exception(item.Exception);

            SetValues(item, builder);
            builder.Write();
        }

        public void Fatal(string requestId, string message, Exception exception = null)
        {
            _logger.Fatal()
                .Message(message)
                .Exception(exception)
                .Property("request_id", requestId)
                .Write();
        }

        public void Fatal(LogItem item)
        {
            var builder = _logger.Fatal()
                .Exception(item.Exception)
                .Message(item.FullMessage);

            SetValues(item, builder);
            builder.Write();
        }
    }
}
