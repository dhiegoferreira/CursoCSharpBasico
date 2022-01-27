using System;
using System.Collections.Generic;
using System.Text;

namespace Section12.Services
{
    interface ITaxService
    {
        //Definindo o contrato 
        //Tipo do contrato, nome do contrato, tipo de parâmetro, nome do parâmetro
        double Tax(double amount);
    }
}
