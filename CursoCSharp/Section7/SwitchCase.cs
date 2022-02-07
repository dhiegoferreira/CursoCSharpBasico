using System;

namespace CursoCSharp.Section7
{
    internal class SwitchCase
    {

        //Estrutura opcional a vários if-else encadeado, quando a condição envolve o teste do valor de uma variável.


        static void Main(string[] args)
        {
            var minhaVariavel = 3;


            switch (minhaVariavel)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                default:
                    Console.WriteLine("Caso padrão");
                    break;

            }
        }
    }
}
