using System;
using CursoCSharp.Section10.Aula136.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace CursoCSharp
{
    //Programa sobre herança e classes abstratas
    class ProgramShape
    {

        static void Main()
        {
            List<Shape> listShapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numShape = int.Parse(Console.ReadLine());


            for (int i = 0; i < numShape; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string asw = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red):");
                string color = Console.ReadLine();

                if (asw == "r")
                {
                    Console.Write("Width:");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height:");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Rectangle(width, height));



                }
                else if (asw == "c")
                {
                    Console.Write("Radius:");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listShapes.Add(new Circle(radius));


                }
                else
                {
                    Console.WriteLine("Shape Not Found!  :/");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("---------SHAPE AREAS--------");
            foreach(Shape sp in listShapes)
            {
                Console.WriteLine(sp.Area().ToString("F2", CultureInfo.InvariantCulture));

            }




        }

    }
}
