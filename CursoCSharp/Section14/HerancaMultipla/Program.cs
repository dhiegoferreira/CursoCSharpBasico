using CursoCSharp.Section14.HerancaMultipla.Entities;


namespace CursoCSharp.Section14.HerancaMultipla
{

    //Este programa tem como objetivo entender o motivo de não podermos ter duas subclasses que sobrescrevem o mesmo
    //método de uma classe base(super classe) e um classe que herda dessas suas subclasses. 
    //Este é o problema da herança multipla
    //Nesse problema, nós teríamos uma ambiguidade pois o mesmo método está sendo sobreescrito em duas subclasses e há um terceira que precisa sobrescever esses mesmos métodos.
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");


            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            System.Console.WriteLine(s.Scan()); //O método retorna uma string porém eu devo ou armazena-la ou exibi-la.

           


        }
    }
}
