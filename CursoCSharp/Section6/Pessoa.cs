using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section6
{
    class Pessoa
    {
        //Atributo ou campo público para teste
        public string nome;


        //Atributo ou campo privado para teste
        //Não posso utilizar autoproperties linha única para atributos privativos.
        public int idade { get; set; }


        //Para atributos privativos
        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set {
                //Instruções para verificação (antes de receber)

                _idade = value;
            }


        }


      


    }
}
