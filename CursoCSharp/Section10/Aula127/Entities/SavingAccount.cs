
namespace CursoCSharp.Section10.Aula127.Entities
{
    class SavingAccount : Account
    {

        public double InterestRate { get; set; }

        
        
        
        public SavingAccount() { }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {

            InterestRate = interestRate;
        }


        public override void WithDraw(double amount)
        {
            Balance -= amount;

        }

       

        public double UpdateBalance()
        {
            Balance += Balance * InterestRate;

            return Balance;
        }




    }
}
