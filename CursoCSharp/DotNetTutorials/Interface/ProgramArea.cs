using System;
using System.Globalization;

namespace CursoCSharp.DotNetTutorials.Interface
{
    class ProgramArea
    {
        static void Main()
        {
            

            try
            {
                Console.Write("Enter to shape (Rectangle = 'r' or Circle 'c':");
                string asw = Console.ReadLine();
                Area area = new Circle();
                if (asw == "c")
                {
                    Console.Write("Enter to radius:");

                    //Instanciando a classe concreta Circle que implementa 
                    //a interfae Area
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    area.area(radius, 0);
                } 
                else if(asw == "r")
                {
                    Console.Write("Enter width:");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Enter height:");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Instanciando a classe concreta que implementa a interface
                    area = new Rectangle();
                    area.area(width, height);

                }


            } catch (FormatException e)
            {
                Console.Write("Error message: "+ e.Message);

            } finally
            {

                Console.WriteLine("End Program...");
            }
        }
    }
}
