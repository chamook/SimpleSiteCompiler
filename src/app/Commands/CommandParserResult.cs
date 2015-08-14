using System.Collections.Generic;
using System.Linq;

namespace SimpleSiteCompiler.Commands
{
    public class CommandParserResult
    {
        public CommandParserStatus Status { get; private set; }
        public IEnumerable<CommandParserMessage> Messages { get { return _messages.AsEnumerable(); }}

        private readonly IList<CommandParserMessage> _messages; 

        public CommandParserResult()
        {
            _messages = new List<CommandParserMessage>();
        }

        public void AddMessage(string message, CommandParserMessageStatus messageStatus)
        {
            _messages.Add(new CommandParserMessage(message, messageStatus));
        }

        public void AddMessage(CommandParserMessage message)
        {
            _messages.Add(message);
        }

        public void SetStatus(CommandParserStatus status)
        {
            Status = status;
        }
    }
}