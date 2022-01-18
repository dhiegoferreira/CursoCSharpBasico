
namespace CursoCSharp.Section9.Entities.Enums
{
    enum OrderStatus : int //estado do pedido
    {
        //Posso omitir os índice e ele contará a patir do 0.

        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }

}
