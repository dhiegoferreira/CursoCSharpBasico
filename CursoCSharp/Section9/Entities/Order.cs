
using System;
using CursoCSharp.Section9.Entities.Enums;


namespace CursoCSharp.Section9.Entities
{
    
    class Order//Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    
        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }


    }
}
