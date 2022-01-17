using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoaObjetos
{
    class Departamento
    {
        public string Nome { get; set; }
        public IList<Curso> Cursos { get; }
        

        public void RegistrarCurso(Curso c)
        {

            Cursos.Add(c);
        }

        public int ObterQuantidadeDeCursos()
        {
            return Cursos.Count;
        }

        public Curso ObterCursoPorIndice(int indice)
        {
            return Cursos[indice];
        }



    }
}
