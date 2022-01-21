
namespace CursoCSharp.Section10.Aula137.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }


        public Person() { }

        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;

        }

        //Um método abstrato é finalizado com ponto e vírgula.
        public abstract double taxesPaid();

        
    }
}
