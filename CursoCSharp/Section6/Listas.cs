using System.Collections.Generic;

namespace CursoCSharp.Section6
{
    class Listas
    {
        static void Main(string[] args)
        {

            //Creating a list of the string type
            List<string> list = new List<string>();


            //Insert element in list: Add(), Insert(index, data)
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }


            //Tamanho da lista: Count
            System.Console.WriteLine("List count: " + list.Count);



            //O Find espera um predicado como argumento
            //predicado é uma função que pega um valor e retorrna true or false.
            string s1 = list.Find(Test);

            //Com expressão lambda
            string s2 = list.Find(x => x[0] == 'A');
            //Lê-se: Eu quero o objeto x tal que x na posição 0 seja igual a 'A'
            
            System.Console.WriteLine("First 'A' : " + s1);


            System.Console.WriteLine("Lambda First 'A' : "+ s2);


            //Último elemento da lista: FindLast
            string s3 = list.FindLast(x => x[0] == 'A');
            System.Console.WriteLine("Last 'A' : "+ s3);


            //ENCONTRAR POSIÇÃO

            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("First position 'A' :" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("Last position 'A' :" + pos2);

            //Filtrar a lista com base em um predicado:FindAll()
            //Pegar somente os valores que possuem 5 caracteres
            //Criar nova lista para receber o resultado do filtro

            List<string> list2 = list.FindAll(x => x.Length == 5);

            //E para mostrar? foreach!
            System.Console.WriteLine("----------------------");
            foreach (string obj in list2)
            {
                System.Console.WriteLine(obj);
            }


            //Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

            //Remove(string item)
            
            list.Remove("Alex");
            System.Console.WriteLine("-------------------");
            foreach(string obj in list)
            {
                System.Console.WriteLine(obj);
            }


            //RemoveAll(<predicate> lambda)

            list.RemoveAll(x => x[0] == 'M');
            System.Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            //RemoveAt (int index) precisamos do índice para remover
            list.RemoveAt(2);

            //RemoveRange (int index, int count)
        }

        //Função estática que retorna verdadeira todo vez que houver uma ocorrência do caractere 'A'
        static bool Test(string s)
        {

            return s[0] == 'A';
        }

        //Podemos trocar essa estrutura por uma expressão Lambda.

    }
}
