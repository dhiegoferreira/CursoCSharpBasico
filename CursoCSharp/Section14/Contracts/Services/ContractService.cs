using System;
using System.Collections.Generic;
using System.Text;
using Section13.Contracts.Entities;

namespace Section13.Contracts.Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinepaymentService;

        public ContractService(IOnlinePaymentService onlinepaymentService)
        {
            _onlinepaymentService = onlinepaymentService;

        }


        public void ProcessContract(Contract contract, int months)
        {
            //Pega o valor total de divide pela quantidade de mesese
            double basicQuota = contract.TotalValue / months;

            //Em seguida faremos uma laço de repetição
            //para criarmos as parcelas com as informações necessárias
            //Altera a o mês da data de entrada do contrato
            //Calcula a taxa de juros acrescida do valor de cada parcela
            //Calcula a taxa de pagamentos acrescida de cada parcela
            for (int i = 1; i <= months; i++)
            {
                //.AddMonths adicionar a ao mês da data declarada a quantidade passada como param
                DateTime date = contract.Date.AddMonths(i);

                //Pega o valor de cada parcela e acresce da taxa de juros.
                //Aqui chamaremos o método da classe concreta PayPal Service que implementa a interface IOnlinePaymentService através do método Interest
                //O Método Interest pega o valor da parcela e multiplica por 0.01 (1%) e pelo seu respectivo mês (parcela*0.01*1,2,3,4..)

                double updatedQuota = basicQuota + _onlinepaymentService.Interest(basicQuota, i);

                //Pega o valor de cada parcela e acresce da taxa de pagamento.
                //Aqui chamaremos o método da classe conreta PayPal Service que implementa a interface IOnlinePaymentService atrvés do método PaymentFee.
                //O método PaymentFee pega o valor da parcela, agora já calculado o juros, (updateQuota) e multiplica por 0.02 (2%).

                double fullQuota = updatedQuota + _onlinepaymentService.PaymentFee(updatedQuota);

                //Agora, com o mês da data de vencimento atualizado e com os valores da taxa de juros (updateQuota) e os valores da taxa da pagamento(fullQuota) poderemos adicionar ao contrato a parcela correspondente a cada mês.


                //Perceba que podemos fazer desta, forma, instanciando um objeto do tipo Installment no qual iremos passar a data de vencimento (dueDate) e o valor da parcela (amount);

                // Installment installment = new Installment(date, fullQuota);

                //Devemos passar um obejeto do tipo Installment(PARCELA)
                contract.AddInstallment(new Installment(date, fullQuota));

                

            }
        }
    }
}
