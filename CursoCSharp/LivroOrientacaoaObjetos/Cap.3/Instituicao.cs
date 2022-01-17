using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.LivroOrientacaoaObjetos
{
    class Instituicao
    {

        public string Nome { get; set; }
        //public string Endereco { get; set; }
        public Endereco Endereco { get; set; }



        public Departamento[] Departamentos { get; } = new Departamento[10];

        private int quantidadedeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        {
            if(quantidadedeDepartamentos < 10)
            {
                Departamentos[quantidadedeDepartamentos++] = d;
            }

        } 

        public int ObterQuantidadedeDepartamentos()
        {
            return quantidadedeDepartamentos;
        }


        //Retorna um departamento específico de acordo com o índice passado.
        public Departamento DepartamentoPorIndice(int indice)
        {

            return Departamentos[indice];
        }
    }
}
