using System;
using System.Collections.Generic;

namespace Section13.Contracts.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments = new List<Installment>();


        //Métodos construtores
        public Contract() { }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        //Criando um método vazio que adicionará um installment(parcela) à minha lista de parcelsas.

        public  void AddInstallment(Installment installment)
        {
            installments.Add(installment);
        }


    }
}
