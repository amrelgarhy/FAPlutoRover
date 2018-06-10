using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Commands
{
    public class CommandParser
    {
        private string _commandText;

        public CommandParser(string commandText)
        {
            _commandText = commandText;
        }

        public List<ICommand> Commands
        {
            get
            {
                var commandChars = _commandText.ToArray();

                var allCommands = new AllCommands();
                var availableCommands = allCommands.Get();

                var matchedCommands = new List<ICommand>();
                for (int i = 0; i < commandChars.Length; i++)
                {
                    var commandToAdd = availableCommands.FirstOrDefault(x => x.IsMatched(commandChars[i]));
                    if (commandToAdd != null)
                        matchedCommands.Add(commandToAdd);
                }

                return matchedCommands;
            }
        }

    }
}
