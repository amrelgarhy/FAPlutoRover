using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Directions
{
    public class East : IDirection
    {
        private readonly ISurface _surface;

        public East(ISurface surface)
        {
            _surface = surface;
        }

        public IDirection TurnLeft()
        {
            return new North(_surface);
        }

        public IDirection TurnRight()
        {
            return new South(_surface);
        }
    }
}
