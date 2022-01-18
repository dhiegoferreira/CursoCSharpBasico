using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class AreaDoTrinaguloComDelegacao
    {
        static void Main(string[] args)
        {
            ClasseTriangulo x, y;

            x = new ClasseTriangulo();
            y = new ClasseTriangulo();

            x.A = Double.Parse(Console.ReadLine());
            x.B = Double.Parse(Console.ReadLine());
            x.C = Double.Parse(Console.ReadLine());

            y.A = Double.Parse(Console.ReadLine());
            y.B = Double.Parse(Console.ReadLine());
            y.C = Double.Parse(Console.ReadLine());

            Console.WriteLine("A área do trinângulo X é:" + x.CalcularArea());        
            Console.WriteLine("A área do triângulo Y é:" + y.CalcularArea());
           
            

        }
    }
}
