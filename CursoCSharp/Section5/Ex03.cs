using System;

namespace CursoCSharp.Section5
{ 
    class Ex03
    {
        static void Main()
        {

            //AGORA ELE PEDE OS PARÂMETROS Produtos p = new Produtos();
            
            

           
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            
            //Passando as informações coletadas para os parâmetros do método construtor
            Produtos p = new Produtos(nome,preco);



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
