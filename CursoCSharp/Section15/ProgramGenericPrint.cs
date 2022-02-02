using System;
using CursoCSharp.Section15.Services;

namespace CursoCSharp.Section15
{
    class ProgramGenericPrint
    {
        static void Main(string[] args)
        {


            Console.Write("How many values?");
            int n = int.Parse(Console.ReadLine());


            //Agora eu posso parametrizar o meu PrintService de acordo com o tipo de dados que o programa necessitar
            //Pode ser int, string, object ou qualquer outro tipo.
            PrintService<string> printService = new PrintService<string>();

            for (int i = 0; i < n; i++)
            {
                printService.AddValue((Console.ReadLine()));
            }


            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First: "+ printService.First());
            
            
        }
    }
}
