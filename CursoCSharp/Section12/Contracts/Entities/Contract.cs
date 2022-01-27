using System;
using System.Collections.Generic;
using System.Text;

namespace Section12.Contracts.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments = new List<Installment>();


        //Métodos construtores
        public Contract(){}

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
        

    }
}
