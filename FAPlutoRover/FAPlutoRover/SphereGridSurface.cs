using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public class SphereGridSurface : ISurface
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private readonly int _size;


        private readonly List<Obstacle> _obstacles;

        public SphereGridSurface(int size, List<Obstacle> obstacles) : this(size)
        {
            _obstacles = obstacles;
        }

        public SphereGridSurface(int size)
        {
            X = 0;
            Y = 0;
            _size = size;
        }

        private bool HasObstacle()
        {
            foreach (Obstacle obstacle in _obstacles)
            {
                if (obstacle.X == X && obstacle.Y == Y)
                {
                    return true;
                }
            }
            return false;
        }

        public void StepYBackward()
        {
            Y--;
            if (Y < 0)
                Y = _size;

            if (HasObstacle())
            {
                StepYForward();
            }
        }

        public void StepYForward()
        {
            Y++;
            if (Y > _size)
                Y = 0;

            if (HasObstacle())
            {
                StepYBackward();
            }
        }

        public void StepXForward()
        {
            X++;
            if (X > _size)
                X = 0;

            if (HasObstacle())
            {
                StepXBackward();
            }
        }

        public void StepXBackward()
        {
            X--;
            if (X < 0)
                X = _size;

            if (HasObstacle())
            {
                StepXForward();
            }
        }
    }
}
