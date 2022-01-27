using System.Globalization;


namespace Section12.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        

        //´Método consturtor
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }


        //Propriedade calculada já definida
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }



        public override string ToString()
        {
            return "BasicPayment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + $"\nTax: "
                +Tax.ToString("F2", CultureInfo.InvariantCulture)
                + $"\nTotalPayment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
