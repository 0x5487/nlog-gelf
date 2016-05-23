using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogGelf
{
    public interface INGelfLogger
    {
        void Debug(string requestId, string message);

        void Debug(LogItem item);

        void Info(string requestId, string message);

        void Info(LogItem item);

        void Warn(string requestId, string message);

        void Warn(LogItem item);

        void Error(string requestId, string message, Exception exception = null);

        void Error(LogItem item);

        void Fatal(string requestId, string message, Exception exception = null);

        void Fatal(LogItem item);
    }
}
