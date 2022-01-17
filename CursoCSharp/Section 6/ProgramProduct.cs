using System;
using System.Globalization;

namespace CursoCSharp.S6.ComportamentodeMemoriaArraysListas
{
    class ProgramProduct
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Product[] prod = new Product[n];



            for(int i = 0; i < prod.Length; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Product { Name = name, Price = price };

                
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += prod[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE  = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            

            
            //AVERAGE PRICE SIGNIFICA PREÇO MÉDIO
            
            
            

            




        }

    }
}
