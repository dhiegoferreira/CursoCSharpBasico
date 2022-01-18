using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class Ex04
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Informe a largura do retângulo: ");
            r.width = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do retângulo: ");
            r.hight = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------Características do Retângulo---------------");
            Console.WriteLine("");
            Console.WriteLine(r);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");




        }


    }
}
