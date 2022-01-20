using CursoCSharp.DesafioS9.Entities;
using CursoCSharp.DesafioS9.Entities.Enums;
using System;
using System.Globalization;


namespace CursoCSharp
{
    class ProgramFour
    {

        static void Main()
        {

            Console.WriteLine("Enter Cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            string status = Console.ReadLine(); //Converter para enum
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), status);


            //Instanciando Order com Client e OrderStatus


            Order order = new Order(DateTime.Now, os);
            order.client.Name = name;
            order.client.Email = email;
            order.client.BirthDate = birthDate;


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            //Laço
            for (int i =0 ; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                //Criar um OrderItem (instanciar e passar para o construtor)
                OrderItem oi = new OrderItem(quantityProduct, priceProduct);

                oi.product.Name = nameProduct;
                oi.product.Price = priceProduct;


                //Instanciar a lista de Order
                order.Items.Add(oi);

            }


            Console.WriteLine(order);

        }
    }
}
