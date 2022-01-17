using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OOPInicio
{
    class Ex03
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = Double.Parse(Console.ReadLine());

            Console.Write("Quantidade :");
            p.Quantidade = int.Parse(Console.ReadLine());


            //Retornando o estoque
            Console.WriteLine("Dados do produto: " + p);

            //Adicionando produtos e retornando o estoque
            Console.Write("Digite a quantidade de produtos que deseja adicionar ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));        
            Console.WriteLine("Dados do produto: " + p);

            //Removendo produtos e retornando o estoque
            Console.WriteLine("Digite o número de produtos a ser removidos: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine("Dados do produto: " + p);
        }
    }
}
