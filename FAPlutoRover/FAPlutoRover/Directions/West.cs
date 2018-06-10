using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Directions
{
    public class West : IDirection
    {
        private readonly ISurface _surface;

        public West(ISurface surface) 
        {
            _surface = surface;
        }

        public void MoveBackward()
        {
            _surface.StepXForward();
        }

        public void MoveForward()
        {
            _surface.StepXBackward();
        }

        public IDirection TurnLeft()
        {
            return new South(_surface);
        }

        public IDirection TurnRight()
        {
            return new North(_surface);
        }
    }
}
