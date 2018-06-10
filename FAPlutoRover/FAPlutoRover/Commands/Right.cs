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
            throw new NotImplementedException();
        }

        public bool IsMatched(char commandChar)
        {
            return commandChar == 'R';
        }
    }
}
