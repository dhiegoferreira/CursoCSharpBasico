using System;
using System.Collections.Generic;
using System.Text;
using Section13.Contracts.Entities;

namespace Section13.Contracts.Services
{
    class ContractService
    {


        private IOnlinePaymentService _paymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _paymentService = paymentService;

        }


        public void ProcessContract(Contract contract, int months)
        {

        }
    }
}
