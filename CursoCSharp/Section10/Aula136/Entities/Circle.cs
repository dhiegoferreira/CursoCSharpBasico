


namespace CursoCSharp.Section10.Aula136.Entities
{
    class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return (3.14 * (Radius * Radius));
        }

    }
}
