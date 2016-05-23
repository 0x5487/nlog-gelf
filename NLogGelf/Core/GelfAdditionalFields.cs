namespace NLogGelf.Core
{
    public static class GelfAdditionalFields
    {
        public const string LoggerName = "logger_name";
        public const string ThreadName = "threadName";
        public const string Facility = "facility";
        public const string SourceFileName = "sourceFileName";
        public const string SourceLineNumber = "sourceLineNumber";
        public const string SourceMethodName = "sourceMethodName";
        public const string SourceClassName = "sourceClassName";
        public const string ExceptionMessage = "exception_message";
        public const string ExceptionStackTrace = "exception_stacktrace";
    }
}