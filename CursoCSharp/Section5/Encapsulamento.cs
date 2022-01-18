using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section5
{
    class Encapsulamento
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos("TV", 900.00, 10);
            //recebendo um outro nome do produto
            p.SetNome("Carro");

            Console.Write("Digite seu nome:");
            p.SetNome(Console.ReadLine());

            



        }


    }
}
