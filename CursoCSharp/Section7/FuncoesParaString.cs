using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section7
{
    internal class FuncoesParaString
    {
        static void Main(string[] args)
        {
            //                 Para formatar 
            //ToLower() : minúscula
            //ToUpper() : Maíuscula
            //Trim(): Apaga os espaços em branco apenas na frente do nome ou no fim dele.

            string s1 = "  Maria da silva  ";
      
            Console.WriteLine(s1.Trim());


            //                   Para buscar:
            string s2 = "trabalho tampão terapeutra t ";
            //IndexOf(): buscar por pela primeira ocorrência dentro da string (retorna a posição do item a buscar).

            Console.WriteLine(s2.IndexOf("t")); 
            //retorna zero se encontrar a ocorrência passada como parâmetro
            //podemos utilizar um char '' ou um conjunto de caracteres " "
            //Além disso, temos 8 sobrecargas.



            //LastIndexOf: retornar a última ocorrência passada como parâmetro

            Console.WriteLine(s2.LastIndexOf('t'));


            //        Para recortar 
            string s3 = "CPF: 076.378.254-23";
            //Substring(inicio)
            Console.WriteLine(s3.Substring(5));
            //vai recorta A PARTI da posiçã passada, então ele vai mostrar a posição passada mais o resto.

            //       Para substituir
            //Replace(char, char)
            string s4 = "copo";
            Console.WriteLine(s4.Replace('o', 'a')); //substritua todas as ocorrência de 'o' por 'a'.
            
            Console.WriteLine(s4);

            //Replace(string, string)
            Console.WriteLine(s4.Replace("copo", "capa"));



            //Substring(inicio, tamanho)
            //ex: os 4 primeiros dígitos do cpf
            string s5 = "CPF: 07637846578";
            Console.WriteLine("Quatro primeiros dígitos: "+ s5.Substring(5, 4));

            //         Para null ou vazio ou espaços em branco
            string s6 = "";
            //IsNullOrEmpty()
            Console.WriteLine(String.IsNullOrEmpty(s6));
            s6 = "nome";
            Console.WriteLine(String.IsNullOrEmpty(s6));
            //retorna true se a string estiver vazia, e false se não estiver

            //IsNullOrWhiteSpace
            //nula ou espaços em branco.
            s6 = "";
            Console.WriteLine(String.IsNullOrWhiteSpace(s6));

        }

    }
}
