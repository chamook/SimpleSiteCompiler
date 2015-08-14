namespace SimpleSiteCompiler.Commands
{
    public class CommandParserMessage
    {
        public CommandParserMessageStatus Status { get; private set; }
        public string Message { get; private set; }

        public CommandParserMessage(string message) : this(message, CommandParserMessageStatus.Success)
        { 
        }

        public CommandParserMessage(string message, CommandParserMessageStatus status)
        {
            Message = message;
            Status = status;
        }
    }
}