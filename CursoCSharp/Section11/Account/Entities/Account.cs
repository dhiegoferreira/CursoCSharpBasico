using CursoCSharp.Section11.Account.Entities.Exceptions;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Section11.Account.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; } //Limite de saque

        //Constructor method
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }



        //ATENÇÃO: nesse caso não precisamos que o método retone algo
        //Apenas que faça a verificação e relacione os atributos: retorno void
        public void Deposit(double amount)
        {
            //Tratamento para depósito menor ou igual a zero.
            if(amount <= 0)
            {
                throw new AccountExceptions("amount must be not a less than zero value.");
            }


            Balance -= amount;
        }


        public void WithDraw(double amount)
        {
            if (Balance == 0)
            {
                throw new AccountExceptions("amount less than balance.");
            }

            if (amount > WithDrawLimit)
            {
                throw new AccountExceptions("amount more than withdraw limit.");
            }
            if(amount > Balance)
            {
                throw new AccountExceptions("amount more than Balance.");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------INFO-----------------");
            sb.Append("Account: "+ Number);
            sb.AppendLine("Holder: " + Holder);
            sb.AppendLine("Balance: " + Balance);
            sb.AppendLine("WithDraw Limit: " + WithDrawLimit);

            return sb.ToString();
        }
    }
}
