using System;
using CursoCSharp.DesafioS9.Entities.Enums;
using System.Collections.Generic;
using System.Text;


namespace CursoCSharp.DesafioS9.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }//Enumeração
        public List<OrderItem> Items = new List<OrderItem>(); //Lista de produtos - Composição - "tem muitos" (Relação parte-todo)
        public Client client = new Client();


        
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
            Items.Add(item);
        }

        //Método para remover
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        //Total

        public double Total()
        {
            //Percorrer os itens do pedido e incrementar o subtotal 
            double sum = 0;
            //Fazendo o incremendo para o preço
            foreach (OrderItem oi in Items)
            {
                //Devo pegar de OrderItem oi.SubTotal(Price * quanity) pois o preço do produto pode mudar, porém o preço (price) no OrderItem funcionará como um histórico do preço na data de realização do pedido.
                sum += oi.SubTotal();
            }

            return sum;
        }



        //Pesquisar sobre override (sobre escrita de métodos)

        public override string ToString()
        {
            //Utilizando o StringBuilder 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------------------------");
            sb.AppendLine("ORDER SUMARY:");
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {client.Name} {client.BirthDate.ToString("dd/MM/yyyy")} - {client.Email}");
            sb.AppendLine("Order Items:");
            
            //Percorrer a lista de itens (Items)
            foreach (OrderItem oi in Items)
            {
                sb.AppendLine($"{oi.product.Name}, ${oi.product.Price}, Subtotal: ${oi.SubTotal()}");
            }

            sb.AppendLine($"Total price: ${Total()}");

            //retorno o próprio método sobrescrito
            return sb.ToString();
        }



    }
}
