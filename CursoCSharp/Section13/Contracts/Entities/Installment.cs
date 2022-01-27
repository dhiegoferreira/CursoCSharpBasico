using System;
using System.Collections.Generic;
using System.Text;

namespace Section13.Contracts.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }


        public Installment() { }


        public Installment(DateTime dueTime, double amount)
        {
            DueDate = dueTime;
            Amount = amount;

        }

    }




}
