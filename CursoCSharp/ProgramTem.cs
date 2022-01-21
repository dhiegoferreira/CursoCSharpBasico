using CursoCSharp.Section10.Aula137.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;


namespace CursoCSharp

{
    class ProgramTem
    {

        static void Main()
        {
            List<Person> people = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int numberPayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberPayers; i++)
            {
                Console.WriteLine($"Tax payer {i+1} data:");
                Console.Write("Indiviual or Company(i/c):");
                string asw = Console.ReadLine();

                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Comparação para o tipo de person (individual or Company)
                if(asw == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    people.Add(new Individual(name, anualIncome, healthExpenditures));

                } else if (asw == "c")
                {
                    Console.Write("Number of employess:");
                    int numberOfEmployess = int.Parse(Console.ReadLine());

                    people.Add(new Company(name, anualIncome, numberOfEmployess));

                } 
                else
                {

                    Console.WriteLine("Invalid Input! :/");
                }

            }

            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            //Percorrendo a lista e exibindo os resultados
            Console.WriteLine("Taxes Paid:");

            double totalTaxes =0;
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}  $ {person.taxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += person.taxesPaid();
            }

            Console.Write($"Total taxes: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}" );

        }
    }
}
