
namespace CursoCSharp.DesafioS9.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        //Fazendo a agregação entre os objetos Product e OrderItem
        Product product = new Product();
       

        //Construtor null
        public OrderItem() { }


        //Construtor com parâmetros
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

    }
}
