using System;
using System.Text;

namespace CursoCSharp.Section10.Aula133.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }


        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }






        //Método para imprimir a section PRICE TAGS: com sobrescrita do método para virtual
        public override string PriceTag()
        {
            Console.WriteLine($"{Name} (used) ${Price} (Manufacture date: {ManufactureDate})");

            return base.PriceTag();
        }
      
    }
}
