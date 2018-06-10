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

        public int X { get { return _surface.X; } }
        public int Y { get { return _surface.Y; } }

        public PlutoRover(ISurface surface)
        {
            _surface = surface;
            Direction = new North(surface);
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void Forward()
        {
            Direction.MoveForward();
        }

        public void Backward()
        {
            throw new NotImplementedException();
        }
    }
}
