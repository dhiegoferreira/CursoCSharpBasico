

namespace CursoCSharp.Section10.Aula137.Entities
{
    class Individual : Person
    {

        public double HealthExpenditures { get; set; }


        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;


        }



        //Sobreescrita dos métodos abstratos da classe Person
        public override double taxesPaid()
        {
            //Cálculo para pessoa física 
            double taxes;
            if(AnualIncome < 20000.00)
            {
                taxes = AnualIncome * 0.15;
            } else 
            {
                taxes = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);

            }

            return taxes;
        }


    }
}
