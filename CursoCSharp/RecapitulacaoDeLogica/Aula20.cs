using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.RecapitulacaoDeLogica
{
    class Aula20
    {
        static void Main()
        {
            //Aula sobre Conversão implícita e casting

            //caso de conversão implícita

            float a; //possui 8 bytes
            double b; //possui 4 bytes

            a = 4.5f;
            double y = a;
            //Nesse caso podemos associar o valor float a double porém não o contrário

            double maior = 3.4;
            //float menor = maior;

            //Nesse caso (implicitamente) signfica apenas atribuir o valor desejado a varivável sem envolvê-la com nada.

            //O correto seria 

            float menor = (float)maior;

            int n1 = int.Parse(Console.ReadLine());
           
        }
        

        
    }
}
