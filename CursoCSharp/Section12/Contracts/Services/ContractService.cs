using System;
using System.Collections.Generic;
using System.Text;
using Section12.Contracts.Entities;

namespace Section12.Contracts.Services
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
