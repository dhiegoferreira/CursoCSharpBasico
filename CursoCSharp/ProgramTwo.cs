using CursoCSharp.Section9;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace CursoCSharp
{
    class ProgramTwo
    {
        static void Main(string[] args)
        {

           


          

            //Pelo método construtor

            Console.Write("Enter department´s name:");
            string nameDepartment = Console.ReadLine();

            Console.Write("Name:");
            string nameWorker = Console.ReadLine();
            
            Console.Write("Level (Junior/MidLevel/Senior):");
            //Definindo uma string para level worker
            string levelWorker = Console.ReadLine();
            //Convertendo levelworker de string para enum
            WorkerLevel level = (WorkerLevel) Enum.Parse(typeof(WorkerLevel), $"{levelWorker}");

            Console.Write("Base Salaray :");
            double salaryWorker = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Creating a object Worker type
            Worker worker = new Worker(nameWorker, level, salaryWorker, nameDepartment);

            Console.Write("How many contracts to this worker: ");
            int contractsCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < contractsCount; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Enter #{i + 1} Contract Data: ");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Adding contracts in list of contracts of w1 listContracts
                worker.addContract(new HourContract(data, valuePerHour, hours));
            }



            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear =  Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department: " + worker.NameDepartment.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
