using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class Ex02
    {
        static void Main(string[] args)
        {
            //Criando as variáveis do tipo de classee Pessoa
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            //Pessoa 1
            Console.WriteLine("Dados do primeiro Funcionário");
            p1.Nome = Console.ReadLine();
            p1.Salario = Double.Parse(Console.ReadLine());

            //Pessoa 2
            Console.WriteLine("Dados do segundo Funcionário");
            p2.Nome = Console.ReadLine();
            p2.Salario = Double.Parse(Console.ReadLine());



            Console.WriteLine("A média salarial é de: " + ((p1.Salario + p2.Salario) / 2));




        }
    }
}
