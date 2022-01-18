using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section6
{
    class Produtos
    {
        private string _nome { get; set; }
        private double _preco { get; set; }
        private int _quantidade { get; set; }

        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }

    }
}
