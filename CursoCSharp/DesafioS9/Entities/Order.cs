using System;
using CursoCSharp.DesafioS9.Entities.Enums;
using System.Collections.Generic;
namespace CursoCSharp.DesafioS9.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }//Enumeração
        public List<OrderItem> items = new List<OrderItem>(); //Lista de produtos - Composição - "tem muitos" (Relação parte-todo)

        
        //Construtor vazio
        public Order() { }

        //Construtor com parâmetros 
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;

        }


        //Método para adicionar
        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }

        //Método para remover
        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }

        //Total

        public double Total()
        {
            //Percorrer os itens do pedido e incrementar o subtotal 
            

            return 2.0;
        }




    }
}
