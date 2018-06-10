using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Commands
{
    public class AllCommands
    {
        public List<ICommand> Get()
        {
            return new List<ICommand> {
                new Forward(),
                new Backward(),
                new Left(),
                new Right()
            };
        }
    }
}
