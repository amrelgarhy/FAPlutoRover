using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public interface ISurface
    {
        int X { get; }
        int Y { get; }

        void StepYBackward();
        void StepYForward();

        void StepXForward();
        void StepXBackward();
    }
}
