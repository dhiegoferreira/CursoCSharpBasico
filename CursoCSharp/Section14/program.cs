using System;
using System.IO;
using System.Collections.Generic;

namespace CursoCSharp.Section14
{
    class program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";


            try
            {
                //StreamReader: Permite a leitura de uma cadeia de caracteres
                //File:
                //Fornece métodos estáticos para Criação, cópia, exclusão, deslocamento e abertura de um arquivo. Além de ajudar na criação de objetos do tipo FileStream.

                //A variável do tipo StreamReader irá receber um TextReader do tipo File.OpenText, passando como parâmetro o caminho do arquivo in.txt
                using (StreamReader sr = File.OpenText(path))
                {
                    //Criando uma lista de caracteres.
                    List<string> list = new List<string>();

                    //
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }


                    list.Sort();


                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }



                }

            } catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine("Message: "+ e.Message);

            }
        }
    }
}
