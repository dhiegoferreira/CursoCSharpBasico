

namespace CursoCSharp.Section10.Aula131.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee() { }



        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        //Sobrescrevendo o método Payment();
        public override double Payment()
        {
            double payment = base.Payment();
            // Payment() receberá o mesmo valor do método principal herdado

            return payment += (1.1*AdditionalCharge);

        }

    }
}
