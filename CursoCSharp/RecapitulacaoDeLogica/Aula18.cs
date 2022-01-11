using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CursoCSharp.RecapitulacaoDeLogica
{
    class Aula18
    {

        static void Main()
        {
            //PlaceHolder, Concatenação e interpolação

           

            String nome = "Maria";
            double saldo = 54.3343;
            int idade = 34;

            //PlaceHolder: lugar indicado
            Console.WriteLine("O nome é {0} e sua idade é {1} e seu saldo é {2:F2}", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"O nome é {nome} e sua idade é {idade} e seu saldo é {saldo:F2}");

            //Concatenação
            Console.WriteLine("O nome é" + nome + "e sua idade é" + idade + "e seu saldo é " + saldo.ToString("F2"));

        }
        
        

    }
}
