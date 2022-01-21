using System.Text;
using System.Globalization;

namespace CursoCSharp.Section10.Aula133.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }



        public ImportedProduct() { }
        //Sobrescrita do construtor

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;

        }



        //Sobrescrita do método PriceTag
        public override string PriceTag()
        {

            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee) {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)}";
        }


        public double TotalPrice()
        {

            return Price + CustomsFee;
        }


    }
}
