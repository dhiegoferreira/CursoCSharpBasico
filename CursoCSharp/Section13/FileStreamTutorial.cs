using System.IO;
using System;
namespace CursoCSharp.Section13
{
    class FileStreamTutorial
    {
        static void Main(string[] args)
        {
            //FileStream: disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita.
            //Basicamente podemos inserir textos pelo código
            //Namespace: System.IO;

            //StreamReader: É uma stream capaz de ler caracteres a partir de uma stream binária(ex: FileSream)


            //Exessões: IOException
            //Instanciação: File / FileInfo

            //Read bytes
            //Write bytes
            string path = @"c:\temp\texto6.txt";
            FileStream fs = null;
            StreamReader sr = null;


            try
            {
                if (File.Exists(path))
                {

                   
                    fs = new FileStream(path, FileMode.Open); //File.OpenRead(path);
                    sr = new StreamReader(fs);
                    //A classe StreamReade possui 10 sobrecargas
                    // rs = File.OpenText(path) pois a classe File já cria um StreamReader

                   
                    //Como podemos ler várias linhas?
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    
                    //Lê apenas uma linha do meu arquivo
                    
                    /*
                    string line = sr.ReadLine(); //Lê uma linha de caractere do fluxo atual
                    Console.WriteLine(line);
                    */
                } else
                {
                    File.Create(path);
                    fs = new FileStream(path, FileMode.Open); //File.OpenRead(path);
                    sr = new StreamReader(fs);
                    //A classe StreamReade possui 10 sobrecargas

                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            } 
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro ao fazer esta operação");
                Console.WriteLine(e.Message);

            }
            finally //Aqui iremos fechar a stream de StreamReade e FileStream 
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }


        }
    }
}
