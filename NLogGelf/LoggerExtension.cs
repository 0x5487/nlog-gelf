using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogGelf
{
    public static class LoggerExtension
    {
        public static NGelfLogger ToGelfLogger(this ILogger source)
        {
            return new NGelfLogger(source);
        }
    }
}
