using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class ClasseTriangulo
    {
        public double A;
        public double B;
        public double C;
        
       
        


        //método para o cálculo da área
        public double CalcularArea()
        {          
            double P = ((A + B + C) / 2);
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C)); ;
        }





    }
}
