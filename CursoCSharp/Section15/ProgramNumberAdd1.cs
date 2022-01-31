using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.Section15.Entities;
using CursoCSharp.Section15.Services;

namespace CursoCSharp.Section15
{
    class ProgramNumberAdd1
    {
        static void Main()
        {
            Console.Write("How many values:");
            int values = int.Parse(Console.ReadLine());

            //Instanciando um objeto Numbers para pegar a lista
            Numbers numbers = new Numbers();


            //Instanciando o serviço de Print
            PrintService printService = new PrintService();


            for (int i = 0; i < values; i++)
            {
                numbers.ListNumbers.Add(int.Parse(Console.ReadLine()));
            }

            printService.Print(numbers.ListNumbers);
            Console.WriteLine();
            Console.WriteLine("First: " + printService.First(numbers.ListNumbers)); 

        }


    }
}
