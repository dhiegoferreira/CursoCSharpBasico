using System;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Section10.Aula133.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }


        public UsedProduct() { }


        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }



        //Método para imprimir a section PRICE TAGS: com sobrescrita do método para virtual
        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date): {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
      
    }
}
