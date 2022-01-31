using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.DotNetTutorials.Interface
{

    //Primeira conclusão:
    //Não podemos modificar o contrato!
    //Se declaramos a assinatura do método area com dois parâmetros
    //Devemos então implementar o método na classe concreta exatamente igual
    //ao método assinado na interface.
    class Circle : Area
    {
        public const double PI = 3.14;

        
        public void area(double a, double b)
        {
            double areaCircle;

            areaCircle = PI * a * a;
            Console.WriteLine(areaCircle);

        }

    }
}
