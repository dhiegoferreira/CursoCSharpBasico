namespace Section13.Contracts.Services
{
    class PaypalService : IOnlinePaymentService
    {

        //DECLARAR AS TAXAS FIXAS COMO: private const 
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        //Método estabelecido no contrato da interface IOnlinePaymentService


        //Taxa de juros
        public double Interest(double amount, int months)
        {

            //amount será o valor de cada parcela ()
            // parcela + (1% x mês)

            return amount * MonthlyInterest * months;
        }



        //Taxa de pagamento
        public double PaymentFee(double amount)
        {

            //Recebe o amount que será a parcela
            //acresce dos juros simples de 2% a cada mês
            //E logo após, multiplica por 102% (2%) para termos
            //o valor da taxa de pagamento.
            return amount * FeePercentage;
        }

       
    }
}
