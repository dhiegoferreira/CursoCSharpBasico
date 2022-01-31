using System;
using System.Globalization;


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

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }


}
