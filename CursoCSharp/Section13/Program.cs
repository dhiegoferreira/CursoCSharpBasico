using System.IO;

namespace CursoCSharp.Section13
{
    class Program
    {

        static void Main(string[] args)
        {

            //File: membros estáticos -> Vai me fornecere métodos estáticos para criação, deleção, deslocamento, copia e outras funções.
            //FileInfo: necessária a instaciação -> Fornece os mesmos métodos acima porém só podem ser acessados se instanciados.

            string sourcePath = @"c:\temp\File1.txt";
            string targetPath = @"c:\temp\File3.txt";


            try
            {
                //FileInfo atua como um wrapper para um caminho de arquivo (Instância)

                /*
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.OpenRead();*/

                //Pergunta: Posso copiar ou mover o arquivo sem precisar lê-lo primeiro?
                //File.OpenRead(sourcePath);
                //Respota: sim, eu poderia usar o OpenRead apenas para verificar se o arquivo existe E está sendo lido.


                File.Copy(sourcePath, targetPath);


            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocurred an error!");
                System.Console.WriteLine(e.Message);

            }
        }
    }
}
