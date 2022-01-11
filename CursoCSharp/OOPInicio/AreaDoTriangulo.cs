using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CursoCSharp.OOPInicio
{
    class AreaDoTriangulo
    {
        
       

        static void Main(string[] args)
        {

           
           
            //Este programa calcula a área do triângulo sem POO
            //This program calculate the area of triangle without OOP

            //Definindo três variáveis para representar os lados do triângulo
            double a1, b1, c1, p1, area1;
            double a2, b2, c2, p2, area2;


            //Calculo da área do primeiro triângulo
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            c1 = double.Parse(Console.ReadLine());


            //Cálculo da pare do segundo triângulo
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());


            p1 = ((a1 + b1 + c1)/2);
            p2 = ((a2 + b2 + c2)/2);


            area1= (p1 * ((p1 - a1) * (p1 - b1) * (p1 - c1)));
            area2 = (p1 * ((p2 - a2) * (p2 - b2) * (p2 - c2)));

            area1 = Math.Sqrt(area1);
            area2 = Math.Sqrt(area2);
            Console.WriteLine($"A área do primeiro triângulo é: {area1:F2}");
            Console.WriteLine($"A área do segundo triângulo é: {area2:F2}");
            

            


            

        }
    }
}
