using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public class GridSurface : ISurface
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private readonly int _size;


        public GridSurface(int size)
        {
            X = 0;
            Y = 0;
            _size = size;
        }

        public void StepYBackward()
        {
            if (Y > 0)
                Y--;
        }

        public void StepYForward()
        {
            if (Y < _size)
                Y++;
        }

        public void StepXForward()
        {
            if (X < _size)
                X++;
        }

        public void StepXBackward()
        {
            if (X > 0)
                X--;
        }
    }
}
