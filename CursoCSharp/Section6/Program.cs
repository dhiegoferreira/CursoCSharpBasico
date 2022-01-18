using System.Collections.Generic;


namespace CursoCSharp.Section6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetor = new string[] { "Maria", "Bob", "Alex" };


            //Nesse caso o foreach percorre cada elemento do vetor e não apenas a posição. ele mostra o conteúdo daquela posição.
            foreach (string obj in vetor)
            {
                System.Console.WriteLine(obj);
            }

            //Lê-se: PARA CADA OBJETO 'obj' CONTIDO EM VETOR, faça


            //Temps uma lista do tipo inteiro
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);


            foreach (int i in numeros)
            {
                System.Console.WriteLine(i);
            }
          


        }
    }
}
