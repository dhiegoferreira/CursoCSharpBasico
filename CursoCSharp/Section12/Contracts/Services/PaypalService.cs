
namespace Section12.Contracts.Services
{
    class PaypalService : IOnlinePaymentService
    {

        //Método estabelecido no contrato da interface IOnlinePaymentService
        
        //Taxa de pagamento
        public double PaymentFee(double amount)
        {

            //Recebe o amount que será a parcela
            //acresce dos juros simples de 2% a cada mês
            //E logo após, multiplica por 102% (2%) para termos
            //o valor da taxa de pagamento.
            return amount *1.02;  
        }

        //Taxa de juros
        public double Interest(double amount, int months)
        {

            //amount será o valor de cada parcela ()
            // parcela + (1% x mês)

            return amount + (0.01 * months);
        }


        //O amount de PaymentFee será o Interest(double amount, int months);
    }
}
