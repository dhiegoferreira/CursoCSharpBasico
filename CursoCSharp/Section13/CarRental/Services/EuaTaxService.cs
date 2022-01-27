using System;
using System.Collections.Generic;
using System.Text;

namespace Section13.CarRental.Services
{
    class EuaTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.1; //Retorna imposto igual a 20% da quantidade (amount)
            }
            else
            {
                return amount * 0.05; //Retorna imposto igual a 15% da quantidade (amount)
            }

        }

    }
}
