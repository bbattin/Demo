using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180307_OpOverloadingDemo
{
    class Coordinate
    {
        public static bool operator ==(Coordinate c1, Coordinate c2)
        {
            return (c1.X == c2.X) && (c1.Y == c2.Y);
        }

        public static bool operator !=(Coordinate c1, Coordinate c2)
        {
            return !(c1 == c2);
        }


        public int X { get; set; }
        public int Y { get; set; }
    }
}
