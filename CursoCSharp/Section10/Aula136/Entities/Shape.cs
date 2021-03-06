using CursoCSharp.Section10.Aula136.Entities.Enums;


namespace CursoCSharp.Section10.Aula136.Entities
{
      abstract class Shape //Classe abstrata não pode ser instanciada (herança total)
    {
        public Color Color { get; set; }


        public Shape() { }

        //Método construtor 
        public Shape(Color color)
        {
            Color = color;
        }


        //Declarando a operação abstrata
        public abstract double Area();
    

    }
}
