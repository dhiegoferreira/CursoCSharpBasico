using System;
using System.Collections.Generic;
using System.Text;

namespace Section13.Contracts.Services
{
    interface IOnlinePaymentService
    {
        //Método de referência para Taxa de Pagamento
        double PaymentFee(double amount);

        //Método de referência para a Taxa de Juros
        double Interest(double amount, int months);
        //Temos uma quantidade e um número de meses no qual aquele contrato está definido.

    }
}
