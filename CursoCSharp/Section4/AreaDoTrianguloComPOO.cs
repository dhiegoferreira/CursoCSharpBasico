using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section4
{
    class AreaDoTrianguloComPOO
    {
        static void Main(string[] args)
        {
            double p, areaX, areaY;

            //Estamos criando duas variáveis do tipo ClasseTrianguloa
            //Então, podemos criar variáveis locais de tipos de valores comuns e
            //podemos criar variáveis de tipo classe, que faz referência ao atributos declarados dentro desta classe.

            ClasseTriangulo x, y;


            x = new ClasseTriangulo();
            y = new ClasseTriangulo();

            x.A = Double.Parse(Console.ReadLine());
            x.B = Double.Parse(Console.ReadLine());
            x.C = Double.Parse(Console.ReadLine());

            y.A = Double.Parse(Console.ReadLine());
            y.B = Double.Parse(Console.ReadLine());
            y.C = Double.Parse(Console.ReadLine());

            p = ((x.A + x.B + x.C) / 2);
            areaX = Math.Sqrt((p * (p - x.A) * (p - x.B) * (p - x.C)));


            p = ((y.A + y.B + y.C) / 2);

            areaY = Math.Sqrt((p * (p - y.A) * (p - y.B) * (p - y.C)));


            //Fazendo a comparação

            if(areaX > areaY)
            {
                Console.WriteLine("A Maior área é: " + areaX);
            } else
            {
                Console.WriteLine("A Maior área é: " + areaY); 
            }

            Console.WriteLine("A área do triângulo X é: " + areaX.ToString("F2"));
            Console.WriteLine("A área do triângulo Y é: " + areaY.ToString("F2"));









            
        }

    }
}
