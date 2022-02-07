using System;
using System.Globalization;
namespace CursoCSharp.Section7
{
    internal class EDateTime
    {
        static void Main(string[] args)
        {
            //Tipos struct (tipo valor)
            //Representa um instante

            //Intanciação: contrutores, builders/ conversão String -> DateTime
            //Formatação: DateTime -> String

            
            //Data atual
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2022, 5, 2);
            var d3 = DateTime.Today; //gera a data atual com o horário 00:00

            DateTime d4 = DateTime.UtcNow;
            
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);


            //Conversão de datas
            
            DateTime d5 = DateTime.Parse("2000-08-15"); //padrão do banco de dados
            DateTime d6 = DateTime.Parse("2000-08-15 13:55");

            //Formatação personalizada.
            DateTime d7 = DateTime.ParseExact("15/08/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);


            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);


            
        }
    }
}
