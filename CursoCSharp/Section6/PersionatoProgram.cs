using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section6
{ 
    class PersionatoProgram
    {
        static void Main(string[] args)
        {
            Persionato[] quartos;
            
            Console.WriteLine("Quantos quartos serão alugados? (1 a 10):");
            if (int.Parse(Console.ReadLine()) > 0 && int.Parse(Console.ReadLine()) <= 10)
            {
                int n = int.Parse(Console.ReadLine());
                //Criar um vetor com a quantidade de quartos recebida
                quartos = new Persionato[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Escolha um quarto (0 a 9) : ");
                    if (int.Parse(Console.ReadLine()) > 0 && int.Parse(Console.ReadLine()) < 10)
                    {
                        int numquarto = int.Parse(Console.ReadLine());
                        Console.Write("Informe o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe um Email: ");
                        string email = Console.ReadLine();
                        quartos[numquarto].Nome = nome;
                        quartos[numquarto].Email = email;

                    } else
                    {
                        Console.WriteLine("Quarto inválido");
                    }

                }

            }
            else
            {
                Console.WriteLine("Quantidade inválida");

            }
          

            /*
            for (int i =0; i <= 10; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine();
                }
            }

           */

            

            

        }
    }
}
