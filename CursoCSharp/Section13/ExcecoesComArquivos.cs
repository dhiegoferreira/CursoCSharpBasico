using System;
using System.IO;
namespace CursoCSharp.Section13
{
    class ExcecoesComArquivos
    {
        static void Main(string[] args)
        {
            //FileStream: disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita.
            //Basicamente podemos inserir textos pelo código
            //Namespace: System.IO;

            //Exessões: IOException
            //Instanciação: File / FileInfo

            //Read bytes
            //Write bytes
            string path = @"c:\temp\texto1.txt";
            string sourcepath = @"c:\temp\texto5.txt";

            try
            {
                File.OpenRead(sourcepath);

            }
            catch (IOException e)
            {
                Console.WriteLine("Não conseguimos completar sua operação");
                Console.WriteLine("Mensagem do erro: "+ e.Message);
                Console.WriteLine(e.InnerException); //Podemos obter qual instância esse erro está localizado
                //Se é um DirectoryNotFoundExcepion
                //DriveNotFoundExceptrion
                //EndOfStreamExceptions
                //FileLoadException
                //FileNotFoundException
                //PathTooLongException
                //PipeExcpetion
            }
            
            
           
        }

    }
}
