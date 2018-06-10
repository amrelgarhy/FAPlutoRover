using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public interface IRover
    {
        void TurnLeft();

        void TurnRight();

        void Forward();

        void Backward();
        
    }
}
