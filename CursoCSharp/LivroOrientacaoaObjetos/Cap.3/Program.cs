using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.LivroOrientacaoaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Podemos passar os valores para os atributos no ato da instanciação do objeto;
            var iesUTFPR = new Instituicao()
            {
                Nome = "UTFPR",
                Endereco = new Endereco()
                {
                    Rua = "Brasil",
                    Numero = "1000"

                }
            };



            var iesCC = new Instituicao()
            {
                Nome = "Casa do Código",
                Endereco = new Endereco()
                {
                    Bairro = "Liberdade"
                }


            };
     
          

            //Departamentos para a ies UTFPR
            var dptoEnsino = new Departamento();
            dptoEnsino.Nome = "Computação";

            var dptoAlimentos = new Departamento();
            dptoAlimentos.Nome = "Alimentos";


            //Departamento para a ies Casa do Código
            var dptoRevisao = new Departamento();
            dptoRevisao.Nome = "Revisão Escrita";

            iesUTFPR.RegistrarDepartamento(dptoEnsino);
            iesUTFPR.RegistrarDepartamento(dptoAlimentos);

            iesCC.RegistrarDepartamento(dptoRevisao);
            Console.WriteLine("---------------------------------------------------");


            //Exibi uma lista dos departamentos registrados na iesUTFPR
            Console.WriteLine("UTFPR");
            for (int i =0; i < iesUTFPR.ObterQuantidadedeDepartamentos() ; i++)
            {

                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }



            Console.WriteLine("");

            //Exibi uma lista dos departamentos registrados na iesCC
            Console.WriteLine("Casa do Código");
            for (int i=0; i < iesCC.ObterQuantidadedeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}");

            }


               
        }
    }
}
