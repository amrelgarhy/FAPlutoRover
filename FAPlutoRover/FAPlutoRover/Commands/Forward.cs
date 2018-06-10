using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Commands
{
    public class Forward : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.Forward();
        }

        public bool IsMatched(char commandChar)
        {
            return commandChar == 'F';
        }
    }
}
