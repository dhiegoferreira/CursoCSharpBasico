using System;


namespace CursoCSharp.Section6
{ 
    class CalculatorProgram
    {
        static void Main(string[] args)
        {

            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine("A soma é: " + result);


        }
    }
}
