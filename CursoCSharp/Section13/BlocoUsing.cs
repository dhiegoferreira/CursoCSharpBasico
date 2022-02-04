using System.IO;



namespace CursoCSharp.Section13
{
    class BlocoUsing
    {
        static void Main(string[] args)
        {

            //Sintaxe simplificada que garante que os objetos IDisposible serão fechados
            //Esses objetos IDisposible não são gerenciados pela CLR(Commom Language Runtime)
            //Ex: Fon, FileStream, FileReader, StreamWriter


            //Criar um path
            //Criar um objeto do tipo FileStrem passando o path e abrindo.
            //Ler o objeto FileStream com o StreamReader

            string path = @"c:\temp\texto6.txt";

            //Tente fazer isso

            try
            {

                //o bloco using utiliza implementa a interface IDisposable para chamar o método Dispose() dos objetos dentro do bloco.
                using (FileStream fs = new FileStream(path, FileMode.Open)) //Criando um canal (stream)
                {
                    using (StreamReader rs = new StreamReader(fs)) //StreamReader nos permitirá ler o conjunto de caractere da nossa stream fs
                    {
                        System.Console.WriteLine(rs.ReadLine());
                    }
                }
            } 
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um erro ao ler as linhas do seu arquivo");
                System.Console.WriteLine(e.Message);
            }
           
            /*   !!ATENÇÃO!!
             *   Perceba que não foi necessário utilizar o bloco finally
             *   pois utilizando o bloco using, nossos objetos são executados e FECHADOS nesse bloco.
             */
        }
    }
}
