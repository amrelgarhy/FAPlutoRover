using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover.Directions
{
    public  interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();
        void MoveForward();
        void MoveBackward();
    }
}
