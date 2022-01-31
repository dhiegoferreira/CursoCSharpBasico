using System;
using CursoCSharp.Section10.Aula131.Entities;
using System.Collections.Generic;
using System.Globalization;


//Programa sobre empregados e terceirizados.
namespace CursoCSharp.Section10
{
    class ProgramEmployeeAndOutSourcedEmplyee
    {

        static void Main()
        {
            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)?");
                string asw = Console.ReadLine();
                //OutSourcedEmployee
                //Pergunta: Criar um objeto do tipo OutSourceEmployee
                //Ou criar um Employee que receb um OutSourceEmployee?
                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(asw == "y")
                {
                    Console.Write("Additional Charge:");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, addCharge));

                } 
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));

                }

            }

            //IMPRIMINDO
            Console.WriteLine("PAYMENTS");

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
