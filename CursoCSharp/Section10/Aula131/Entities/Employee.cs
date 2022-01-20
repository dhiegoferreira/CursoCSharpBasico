using System.Text;


namespace CursoCSharp.Section10.Aula131.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }



        //Método virtual que nos permite a sobre escrita ou sobrescrição.
        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }




        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} - ${Payment()}");
            return sb.ToString();
        }

    }
}
