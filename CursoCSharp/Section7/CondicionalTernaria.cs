using System;
using System.Globalization;

namespace CursoCSharp.Section7
{
    class CondicionalTernaria
    {

        static void Main(string[] args)
        {

            //Expressão condicional ternária
            /*
                Sintaxe: (condição) ? valor_se_verdadeiro : valor_se_falso


            */

            //Exemplo programinha que lê um preço e se o preço for maior que 100, desconto de 10%, senão desconto de 5%


            //Modo padrão
           
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*
            if(price > 100.00)
            {
                price -= price * 0.1;
            } 
            else
            {
                price -= price * 0.05; 
            }
            */
            
            //F2 significa ponto flutuante com até duas casas decimais. ou decimal de até duas casas.


            //Modo com Condicional ternária.

            // !! Atenção !!
            // A comparação deve ser armazenada em alguma variável
            price = (price > 100.00) ? price - price * 0.1 : price - price * 0.05;

            Console.WriteLine("New Price: " + price.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
