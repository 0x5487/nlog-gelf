using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogGelf
{
    public interface INGelfLogger
    {
        void Info(string requestId, string message);

        void Info(LogItem item);
    }
}
