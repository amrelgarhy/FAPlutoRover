using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Directions
{
    public class North : IDirection
    {
        private readonly ISurface _surface;

        public North(ISurface surface)
        {
            _surface = surface;
        }

        public void MoveBackward()
        {
            _surface.StepYBackward();
        }

        public void MoveForward()
        {
            _surface.StepYForward();
        }

        public IDirection TurnLeft()
        {
            return new West(_surface);
        }

        public IDirection TurnRight()
        {
            return new East(_surface);
        }
    }
}
