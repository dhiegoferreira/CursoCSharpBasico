using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section6
{
    struct Point
    {
        //Representar um ponto no sistema cartesiano 2D
        public double X, Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
