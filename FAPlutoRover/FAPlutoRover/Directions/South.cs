using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Directions
{
    public class South : IDirection
    {
        private readonly ISurface _surface;

        public South(ISurface surface)
        {
            _surface = surface;
        }

        public void MoveForward()
        {
            _surface.StepYBackward();
        }

        public IDirection TurnLeft()
        {
            return new East(_surface);
        }

        public IDirection TurnRight()
        {
            return new West(_surface);
        }
    }
}
