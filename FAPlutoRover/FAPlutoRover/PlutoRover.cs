using FAPlutoRover.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public class PlutoRover : IRover
    {
        public IDirection Direction { get; set; }
        private readonly ISurface _surface;

        public PlutoRover(ISurface surface)
        {
            Direction = new North(_surface);
            _surface = surface;
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }
    }
}
