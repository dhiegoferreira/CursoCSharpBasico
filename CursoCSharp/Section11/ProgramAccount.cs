using System;
using System.Globalization;
using CursoCSharp.Section11.Account.Entities;
using CursoCSharp.Section11.Account.Entities.Exceptions;

namespace CursoCSharp
{ 
    class ProgramAccount
    {
        static void Main()
        {

            try
            {


                Console.WriteLine("Enter account data:");

                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder:"); //titular
                string holder = Console.ReadLine();

                Console.Write("Initial Balance:");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("WithDraw Limit:");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withDrawLimit);


                Console.Write("Enter for withdraw:");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.WithDraw(withDraw);

                Console.WriteLine(acc);

            }
            catch (AccountExceptions e)
            {
                Console.WriteLine("Error message: " + e.Message);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Error message: "+ e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error message: " + e.Message);
            }


        }
    }
}
