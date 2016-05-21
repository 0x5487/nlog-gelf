using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogGelf
{
    public class LogItem
    {
        public LogItem()
        {
            CustomFields = new Dictionary<string, string>();
        }

        public string RequestId { get; set; }

        public string ShortMessage { get; set; }

        public string FullMessage { get; set; }

        public IDictionary<string, string> CustomFields { get; set; }
    }
}
