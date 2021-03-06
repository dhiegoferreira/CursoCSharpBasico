
using System.Globalization;

namespace CursoCSharp.Section4
{ 
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return (Preco * Quantidade);
        }

        public void AdicionarProdutos(int qtd)
        {
            
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
           

            Quantidade -= qtd;
        }

        //Ao chamarmos o WriteLine ele irá formatar automaticamente

        public override string ToString()
        {

            return (Nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " +
                +Quantidade
                + " unidade, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}
