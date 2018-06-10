using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Directions
{
    public class East : IDirection
    {
        public East(ISurface surface)
        {
        }

        public IDirection TurnLeft()
        {
            throw new NotImplementedException();
        }

        public IDirection TurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
