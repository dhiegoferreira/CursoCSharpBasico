using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class Ex01
    {
        
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            //Pessoa 1
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            //Pessoa 2

            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            //Comparando as idades;

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é : {p1.Nome}");
            } else
            {
                Console.WriteLine($"A pessoa mais velha é : {p2.Nome}");
            }

                    


        }
        
        
        
    }
}
