


namespace CursoCSharp.Section10.Aula136.Entities
{
    //Devo ter métodos construtores personalizados e vazios para que não precise instanciar um Shape ao herdar
    //Devo implementar a sobrescrita do método abstrado da SuperClasse ao herdar seu conteudo.

    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle() { }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        //Nessa caso, não precisaremos colocar o "virtual" antes de override, pois o tipo
        //Abstract já supõe a sobreescrita.
        public override double Area()
        {
            return Width * Height;
        }

    }
}
