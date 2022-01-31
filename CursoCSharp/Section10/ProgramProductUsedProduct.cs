using System;
using CursoCSharp.Section10.Aula133.Entities;
using System.Collections.Generic;
using System.Globalization;

//Herança de polimorfismo
namespace CursoCSharp.Section10
{
    class ProgramProductUsedProduct

    {

        static void Main()
        {

            System.Console.Write("Enter the number of products:");
            int numProducts = int.Parse(Console.ReadLine());

            //Creating a list of Products

            List<Product> products = new List<Product>();

            for(int i = 0; i < numProducts; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string asw = Console.ReadLine();
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(asw == "i")
                {
                    Console.Write("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                    

                } else if (asw == "u") {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                } else
                {
                    //Commom Product
                    products.Add(new Product(name, price));

                }

                
            }

            Console.WriteLine("PRICE TAGS:");

            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }

    }
}
