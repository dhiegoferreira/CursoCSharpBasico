using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Section5
{
    class Produtos
    {


        private string _nome;
        private double _preco;
        private int _quantidade;

        //Os dois métodos construtores abaixo é caracterizados como SOBRECARGA
        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }
        
        public Produtos(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; //Não precisava
        }


        //---------------------MÉTODOS CONTRUTORES------------------------
        
        //MÉTODO GET (OBTER)
        public string GetNome()
        {
            return _nome;
        }

        
        //MÉTODO SET (DEFINIR)
        public void SetNome(string nome)
        {
            //A verificação deve ocorrer no parâmetro de chegada para depois ocorrer a associação
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            } else
            {
                Console.WriteLine("Campo nome não recebido.");
            }
            
        }


        public double GetPreco()
        {
            return _preco;
        }


        public int GetQuantidade()
        {
            return _quantidade;
        }

        //Podemos também definir um construtor padrão
        public Produtos() {  }
        public double ValorTotalEmEstoque()
        {
            return (_preco * _quantidade);
        }

        public void AdicionarProdutos(int qtd)
        {

            _quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {

            _quantidade -= qtd;
        }

        //Ao chamarmos o WriteLine ele irá formatar automaticamente

        public override string ToString()
        {

            return (_nome + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " +
                + _quantidade
                + " unidade, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
