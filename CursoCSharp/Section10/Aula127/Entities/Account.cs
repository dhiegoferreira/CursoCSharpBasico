

namespace CursoCSharp.Section10.Aula127.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }





        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }



        //WithDraw = retirar with interestRate
        public virtual void WithDraw (double amount)
        {
            Balance -= amount + 5.00;
        }


        //Deposit = adicionar
        public void Deposit(double amount)
        {

            Balance += amount;
        }




    }
}
