using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Commands
{
    public interface ICommand
    {
        void Execute(IRover rover);
    }
}
