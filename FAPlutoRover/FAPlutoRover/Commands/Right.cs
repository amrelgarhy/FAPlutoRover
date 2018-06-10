using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Commands
{
    public class Right : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }

        public bool IsMatched(char commandChar)
        {
            return commandChar == 'R';
        }
    }
}
