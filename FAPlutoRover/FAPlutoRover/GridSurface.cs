using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPlutoRover
{
    public class GridSurface : ISurface
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        private readonly int _size;


        public GridSurface(int size)
        {
            X = 0;
            Y = 0;
            _size = size;
        }
    }
}
