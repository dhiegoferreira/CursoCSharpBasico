using System.IO;

namespace CursoCSharp.Section13
{
    class Program
    {

        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\File1.txt";
            string targetPath = @"c:\temp\File2.txt";


            try
            {
                //FileInfo atua como um wrapper para um caminho de arquivo
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.OpenRead();



            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocurred an error!");
                System.Console.WriteLine(e.Message);

            }
        }
    }
}
