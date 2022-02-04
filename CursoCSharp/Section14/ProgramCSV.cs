using System.IO;
using CursoCSharp.Section14.IComparable.Entities;
using System.Collections.Generic;


namespace CursoCSharp.Section14
{
    class ProgramCSV
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employees = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));

                    }
                    employees.Sort();


                    foreach (Employee emp in employees)
                    {
                        System.Console.WriteLine(emp);
                    }


                }

            } catch (IOException e)
            {
                System.Console.WriteLine("An error ocurred");
                System.Console.WriteLine(e.Message);

            }


            //Como saber qual excessão global pegar? Podemos pensar no que estamos trabalhando e então associar uma excessão ao nosso projeto.
        }

    }
}
