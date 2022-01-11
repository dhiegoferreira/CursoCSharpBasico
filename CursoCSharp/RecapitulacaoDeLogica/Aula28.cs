using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.RecapitulacaoDeLogica
{
    class Aula28
    {
        static void Main(string[] args)
        {
            //Escopo e inicialização

            //Se quisermos usar uma variável, devemos inicializá-la

            double preco = double.Parse(Console.ReadLine());


            if(preco > 100.0)
            {
               // double desconto = preco * 0.1;

            }

            //Console.WriteLine(desconto);
            //A variável desconto só funcionará dentro do escopo do if

            //O escopo maior não enxerga as variáveis dos escopos internos.

            //Solução: declarar a variável fora do escopo.

            double desconto;
            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }



        }
    }
}
