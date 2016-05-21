using System;
using NLog.Common;
using NLogGelf.Core;

namespace NLogGelf.NLog
{
    public sealed class VerboseLogger : IEasyGelfLogger
    {
        public void Error(string message, Exception exception)
        {
            InternalLogger.Error(string.Format("{0} ---> {1}", message, exception));
        }

        public void Debug(string message)
        {
            InternalLogger.Debug(message);
        }
    }
}