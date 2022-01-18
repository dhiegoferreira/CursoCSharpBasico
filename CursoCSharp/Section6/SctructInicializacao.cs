using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section6
{
    class SctructInicializacao
    {
        static void Main(string[] args)
        {
            Point p;

            //Console.WriteLine(p); erro: variável não atribuída.

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            //também podemos inicializar
            //Point p = new Point();

            Console.WriteLine(p);


        }
    }
}
