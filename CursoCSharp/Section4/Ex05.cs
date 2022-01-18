using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class Ex05
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            f.SalarioLiquido();

            Console.WriteLine("");
            Console.WriteLine("------------Informações---------------");
            Console.WriteLine(f);
            Console.WriteLine("Digite a porcentagem para aumentar o salário");
            f.AumentarSalario(double.Parse(Console.ReadLine()));



        }
    }
}
