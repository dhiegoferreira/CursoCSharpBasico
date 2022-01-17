

namespace CursoCSharp.LivroOrientacaoaObjetos.Cap._3
{
    class Livro
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        


        private Editora editora;
        public Editora Editora
        {
            get { return this.editora; }
            set
            {
                this.editora = value; //recebe o valor input
                this.editora.RegistrarLivros(this);
            }

        }
        
        
  
        
        
        public Autor[] Autores { get; set; } = new Autor[5];
    }
}
