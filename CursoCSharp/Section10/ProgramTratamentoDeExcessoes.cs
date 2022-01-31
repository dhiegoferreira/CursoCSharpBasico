using System;


namespace CursoCSharp
{
    class ProgramTratamentoDeExcessoes
    {
        static void Main()
        {
            try
            {

                int numA = int.Parse(Console.ReadLine());
                int numB = int.Parse(Console.ReadLine());
                int result = (numA / numB);
                Console.WriteLine(result);

            } catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not permited (inderteminate)");

            } catch (FormatException)
            {
                Console.WriteLine("Inputs are not numbers.");
            }


        }


    }
}
