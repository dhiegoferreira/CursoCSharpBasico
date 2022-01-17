using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoaObjetos
{
    class Editora
    {
        public string RazaoSocial { get; set; }
        public string EMail { get; set; }
        public string Whatsapp { get; set; }

        private int quantidadeLivros = 0;
        public Livro[] Livros { get; } = new Livro[10];

        public void RegistrarLivros(Livro livro)
        {
            if(this.quantidadeLivros < 10) //Limite
            {
                Livros[this.quantidadeLivros++] = livro;
            }

        }


    }
}
