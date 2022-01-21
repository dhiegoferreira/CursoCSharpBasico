
namespace CursoCSharp.Section10.Aula137.Entities
{
    class Company : Person
    {

        public int NumberOfEmployees { get; set; }



        public Company (string name, double anualIncome, int numberOfEmployess) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployess;

        }


        public override double taxesPaid()
        {
            double taxes;
            if(NumberOfEmployees > 10)
            {
                taxes = AnualIncome * 0.14;
            } else
            {
                taxes = AnualIncome * 0.16;
            }

            return taxes;
        }
    }
}
