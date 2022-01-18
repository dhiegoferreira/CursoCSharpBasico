﻿using CursoCSharp.Section9.Entities;
using CursoCSharp.Section9.Entities.Enums;
using System; 


namespace CursoCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };


            Console.WriteLine(order);

            //Converter de enum para string 
            string txt = OrderStatus.PendingPayment.ToString();

        
            //Converter de string para enum
            //Dentro da classe "Enum" há o método parse e então conseguiremos passar uma string para enum.
            OrderStatus os = (OrderStatus) Enum.Parse(typeof(OrderStatus), "Delivered");
            
            
        }













    }
}
