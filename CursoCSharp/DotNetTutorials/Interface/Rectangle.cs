using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.DotNetTutorials.Interface
{
    class Rectangle : Area
    {
       
        public void area(double a, double b)
        {
            double areaRectangle;

            areaRectangle = a * b;
            Console.WriteLine(areaRectangle);
        }
    }
}
