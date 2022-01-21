using System.Text;


namespace CursoCSharp.Section10.Aula133.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }


        //Sobrescrita do construtor

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;

        }




        //Sobrescrita do método PriceTag
        public override string PriceTag()
        {
            
            System.Console.WriteLine(TotalPrice() + $"Customs fee: {CustomsFee}");

            return base.PriceTag();
        }


        public double TotalPrice()
        {

            return Price + CustomsFee;
        }


    }
}
