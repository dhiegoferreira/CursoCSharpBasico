using System;
using System.Globalization;


namespace CursoCSharp.Section5
{
    class ProdutosPropertis
    {


        private string _nome;
        private double _preco;
        private int _quantidade;

        //Os dois métodos construtores abaixo é caracterizados como SOBRECARGA
        public ProdutosPropertis(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }

        public ProdutosPropertis(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; //Não precisava
        }


        //---------------------Propertis(acessadores)---------------------
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                } else
                {
                    Console.WriteLine("Não conseguimos receber o nome.");
                }

            }

        }

       

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        
        //Podemos também definir um construtor padrão
        public ProdutosPropertis() { }




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
                +_quantidade
                + " unidade, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

        }
  







}
}
