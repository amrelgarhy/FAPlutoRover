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
