using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public class Obstacle
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public Obstacle(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
