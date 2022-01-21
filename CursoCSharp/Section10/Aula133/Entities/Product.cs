using System.Text;
using System.Globalization;
namespace CursoCSharp.Section10.Aula133.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { } //São necessários pois sem essa estrutur, não conseguiremos fazer a herança

        public Product(string name, double price)
        {
            Name = name;
            Price = price;

        }

        //Método para imprimir a section PRICE TAGS: com sobrescrita do método para virtual
        public virtual string PriceTag()
        {
            return $"{Name}  $ {Price.ToString("F2" , CultureInfo.InvariantCulture)}";
        }
    }
}
